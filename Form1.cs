using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Editor_de_Texto
{
    public partial class F_editor_texto : Form
    {
        StringReader leitor = null;
        public bool Saved = false;
        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();
        public F_editor_texto()
        {
            InitializeComponent();
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void Novo()
        {
            if (richTextBox1.TextLength > 0)
            {
                if (!Saved)
                {
                    MessageBox.Show("Lembre-se de salvar seu arquivo antes de criar um novo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Salvar();
                }
            }
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Salvar()
        {
            try
            {
                saveFileDialog1.Title = "Salvar arquivo";
                saveFileDialog1.Filter = "Arquivo RTF (*.rtf)|*.rtf|Arquivo de Texto (*.txt)|*.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(saveFileDialog1.FileName).ToLower();

                    if (ext == ".rtf")
                    {
                        // Salva com formatação
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        // Salva texto puro
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }

                    Saved = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abrir()
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.Filter = "Arquivo RTF (*.rtf)|*.rtf|Arquivo de Texto (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = Path.GetExtension(openFileDialog1.FileName).ToLower();

                    if (ext == ".rtf")
                    {
                        // Abre com formatação
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        // Abre como texto puro
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void Negrito()
        {
            try
            {
                if (richTextBox1.SelectionFont != null)
                {
                    // Pega a fonte atual
                    Font currentFont = richTextBox1.SelectionFont;
                    FontStyle currentStyle = currentFont.Style;

                    // Alterna apenas o Bold sem perder os outros estilos
                    FontStyle newStyle;

                    if (currentFont.Bold)
                    {
                        newStyle = currentStyle & ~FontStyle.Bold; // remove o Bold
                    }
                    else
                    {
                        newStyle = currentStyle | FontStyle.Bold;  // adiciona o Bold
                    }

                    // Aplica a nova fonte com os estilos preservados
                    richTextBox1.SelectionFont = new Font(currentFont, newStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar negrito: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Italico()
        {
            try
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle currentStyle = currentFont.Style;

                FontStyle newStyle;

                if (currentFont.Italic)
                {
                    newStyle = currentStyle & ~FontStyle.Italic; // remove o Italic
                }
                else
                {
                    newStyle = currentStyle | FontStyle.Italic;  // adiciona o Italic
                }

                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar itálico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sublinhar()
        {
            try
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle currentStyle = currentFont.Style;

                FontStyle newStyle;

                if (currentFont.Underline)
                {
                    newStyle = currentStyle & ~FontStyle.Underline; // remove o Underline
                }
                else
                {
                    newStyle = currentStyle | FontStyle.Underline;  // adiciona o Underline
                }

                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar sublinhado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void AlinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Imprimir()
        {
            // Implementar funcionalidade de impressão
            printDialog1.Document = printDocument1;
            leitor = new StringReader(this.richTextBox1.Text);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void Recortar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void Refazer()
        {
            if (redoStack.Count > 0)
            {
                string estado = redoStack.Pop();
                undoStack.Push(estado);
                richTextBox1.Rtf = estado;
            }
        }

        private void Desfazer()
        {
            if (undoStack.Count > 1) // tem histórico
            {
                redoStack.Push(undoStack.Pop()); // salva estado atual
                richTextBox1.Rtf = undoStack.Peek(); // volta pro anterior
            }
        }

        private void Cor()
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void TamanhoFonte(float tamanhofonte)
        {
            tamanhofonte = tb_tamanho.Text.Length > 0 ? Convert.ToSingle(tb_tamanho.Text) : 12;
            if (tamanhofonte >= 6 && tamanhofonte <= 64)
            {
                float newSize = tb_tamanho.Text.Length > 0 ? Convert.ToSingle(tb_tamanho.Text) : 12;

                if (richTextBox1.SelectionFont != null)
                {
                    // Pega a fonte atual (nome e estilos)
                    Font fonteAtual = richTextBox1.SelectionFont;
                    // Cria nova fonte com o tamanho escolhido e preserva os estilos (negrito, itálico, etc.)
                    Font novaFonte = new Font(fonteAtual.FontFamily, newSize, fonteAtual.Style);

                    // Aplica na seleção
                    richTextBox1.SelectionFont = novaFonte;
                }
                tb_tamanho.Text = richTextBox1.SelectionFont.Size.ToString();
            }
            else
            {
                MessageBox.Show("Tamanho da fonte inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_tamanho.Text = richTextBox1.Font.Size.ToString();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Salva sempre que o texto muda
            undoStack.Push(richTextBox1.Rtf);
            redoStack.Clear();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Z: // Ctrl + Z para Desfazer
                            Desfazer();
                            e.SuppressKeyPress = true; // Evita o som de alerta
                            break;

                        case Keys.Y: // Ctrl + Y para Refazer
                            Refazer();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.B: // Ctrl + B para Negrito
                            Negrito();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.I: // Ctrl + I para Itálico
                            Italico();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.U: // Ctrl + U para Sublinhar
                            Sublinhar();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.S: // Ctrl + S para Salvar
                            Salvar();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.O: // Ctrl + O para Abrir
                            Abrir();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.N: // Ctrl + N para Novo
                            Novo();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.P: // Ctrl + P para Imprimir
                            Imprimir();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.C: // Ctrl + C para Copiar
                            Copiar();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.V: // Ctrl + V para Colar
                            Colar();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.X: // Ctrl + X para Recortar
                            Recortar();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.L: // Ctrl + L para Alinhar à Esquerda
                            AlinharEsquerda();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.E: // Ctrl + E para Centralizar
                            AlinharCentro();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.R: // Ctrl + R para Alinhar à Direita
                            AlinharDireita();
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.F: // Ctrl + F para Fonte
                            btn_fonte_Click(sender, e);
                            e.SuppressKeyPress = true;
                            break;

                        case Keys.Q: // Ctrl + Q para Sair
                            F_editor_texto.ActiveForm.Close();
                            e.SuppressKeyPress = true;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPorPagina = 0;
            float posicaoY = 0;
            int contadorLinhas = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }
            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPorPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitor.ReadLine();

            while (contadorLinhas < linhasPorPagina && linha != null)
            {
                posicaoY = margemSuperior + (contadorLinhas * fonte.GetHeight(e.Graphics));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, posicaoY, new StringFormat());
                contadorLinhas++;
                linha = leitor.ReadLine();
            }

            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();
        }

        private void btn_fonte_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                fontDialog1.Font = richTextBox1.SelectionFont;
            }
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void F_editor_texto_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;         // Cor padrão
            richTextBox1.SelectionBackColor = Color.White; // Cor de fundo padrão
            richTextBox1.SelectionIndent = 10;       // margem esquerda
            richTextBox1.SelectionRightIndent = 10; // margem direita
            tb_tamanho.Text = richTextBox1.Font.Size.ToString(); // Tamanho da fonte
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_abir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhar_Click(object sender, EventArgs e)
        {
            Sublinhar();
        }

        private void sublinharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhar();
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void alinharÀEsquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void ainharÀDireitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void btn_centralizar_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }    

        private void btn_cortar_Click(object sender, EventArgs e)
        {
            Recortar();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recortar();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_editor_texto.ActiveForm.Close();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desfazer();
        }

        private void refazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refazer();
        }

        private void btn_cor_Click(object sender, EventArgs e)
        {
            Cor();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tb_tamanho.Text = tam_6.Text;
            TamanhoFonte(float.Parse(tam_6.Text));
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tb_tamanho.Text = tam_8.Text;
            TamanhoFonte(float.Parse(tam_8.Text));
        }

        private void tam_10_Click(object sender, EventArgs e)
        {
            tb_tamanho.Text = tam_10.Text;
            TamanhoFonte(float.Parse(tam_10.Text));
        }

        private void tam_12_Click(object sender, EventArgs e)
        {
            tb_tamanho.Text = tam_12.Text;
            TamanhoFonte(float.Parse(tam_12.Text));
        }

        private void tam_16_Click(object sender, EventArgs e)
        {
            tb_tamanho.Text = tam_16.Text;
            TamanhoFonte(float.Parse(tam_16.Text));
        }

        private void tam_20_Click(object sender, EventArgs e)
        {
            tb_tamanho.Text = tam_20.Text;
            TamanhoFonte(float.Parse(tam_20.Text));
        }

        private void tam_24_Click(object sender, EventArgs e)
        {
            tb_tamanho.Text = tam_24.Text;
            TamanhoFonte(float.Parse(tam_24.Text));
        }

        private void tam_32_Click(object sender, EventArgs e)
        {
            tb_tamanho.Text = tam_32.Text;
            TamanhoFonte(float.Parse(tam_32.Text));
        }

        private void tb_tamanho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float tamanhofonte = float.Parse(tb_tamanho.Text);
                TamanhoFonte(tamanhofonte);
                e.SuppressKeyPress = true; // Evita o som de alerta
            }
        }

        private void btn_desfazer_Click(object sender, EventArgs e)
        {
            Desfazer();
        }
    }
}