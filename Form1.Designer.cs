using System.Drawing;
using System.Windows.Forms;

namespace Editor_de_Texto
{
    partial class F_editor_texto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_editor_texto));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharÀEsquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ainharÀDireitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_novo = new System.Windows.Forms.ToolStripButton();
            this.btn_abir = new System.Windows.Forms.ToolStripButton();
            this.btn_salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_desfazer = new System.Windows.Forms.ToolStripButton();
            this.btn_copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_cortar = new System.Windows.Forms.ToolStripButton();
            this.btn_colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_fonte = new System.Windows.Forms.ToolStripButton();
            this.btn_tamanho = new System.Windows.Forms.ToolStripDropDownButton();
            this.tam_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tam_8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tam_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tam_12 = new System.Windows.Forms.ToolStripMenuItem();
            this.tam_16 = new System.Windows.Forms.ToolStripMenuItem();
            this.tam_20 = new System.Windows.Forms.ToolStripMenuItem();
            this.tam_24 = new System.Windows.Forms.ToolStripMenuItem();
            this.tam_32 = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_tamanho = new System.Windows.Forms.ToolStripTextBox();
            this.btn_cor = new System.Windows.Forms.ToolStripButton();
            this.btn_negrito = new System.Windows.Forms.ToolStripButton();
            this.btn_italico = new System.Windows.Forms.ToolStripButton();
            this.btn_sublinhar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_esquerda = new System.Windows.Forms.ToolStripButton();
            this.btn_centralizar = new System.Windows.Forms.ToolStripButton();
            this.btn_direita = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1185, 491);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.desfazerToolStripMenuItem_Click);
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.refazerToolStripMenuItem.Text = "Refazer";
            this.refazerToolStripMenuItem.Click += new System.EventHandler(this.refazerToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinharToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinharToolStripMenuItem
            // 
            this.sublinharToolStripMenuItem.Name = "sublinharToolStripMenuItem";
            this.sublinharToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.sublinharToolStripMenuItem.Text = "Sublinhar";
            this.sublinharToolStripMenuItem.Click += new System.EventHandler(this.sublinharToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.alinharÀEsquerdaToolStripMenuItem,
            this.ainharÀDireitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // alinharÀEsquerdaToolStripMenuItem
            // 
            this.alinharÀEsquerdaToolStripMenuItem.Name = "alinharÀEsquerdaToolStripMenuItem";
            this.alinharÀEsquerdaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.alinharÀEsquerdaToolStripMenuItem.Text = "Alinhar à esquerda";
            this.alinharÀEsquerdaToolStripMenuItem.Click += new System.EventHandler(this.alinharÀEsquerdaToolStripMenuItem_Click);
            // 
            // ainharÀDireitaToolStripMenuItem
            // 
            this.ainharÀDireitaToolStripMenuItem.Name = "ainharÀDireitaToolStripMenuItem";
            this.ainharÀDireitaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ainharÀDireitaToolStripMenuItem.Text = "Ainhar à direita";
            this.ainharÀDireitaToolStripMenuItem.Click += new System.EventHandler(this.ainharÀDireitaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_novo,
            this.btn_abir,
            this.btn_salvar,
            this.toolStripSeparator1,
            this.btn_desfazer,
            this.btn_copiar,
            this.btn_cortar,
            this.btn_colar,
            this.toolStripSeparator2,
            this.btn_fonte,
            this.btn_tamanho,
            this.tb_tamanho,
            this.btn_cor,
            this.btn_negrito,
            this.btn_italico,
            this.btn_sublinhar,
            this.toolStripSeparator3,
            this.btn_esquerda,
            this.btn_centralizar,
            this.btn_direita});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1185, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            this.btn_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_novo.Image = global::Editor_de_Texto.Properties.Resources.novo;
            this.btn_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(29, 24);
            this.btn_novo.Text = "Novo";
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_abir
            // 
            this.btn_abir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_abir.Image = global::Editor_de_Texto.Properties.Resources.Abrir;
            this.btn_abir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_abir.Name = "btn_abir";
            this.btn_abir.Size = new System.Drawing.Size(29, 24);
            this.btn_abir.Text = "Abrir";
            this.btn_abir.Click += new System.EventHandler(this.btn_abir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salvar.Image = global::Editor_de_Texto.Properties.Resources.salvar;
            this.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(29, 24);
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_desfazer
            // 
            this.btn_desfazer.Image = global::Editor_de_Texto.Properties.Resources.seta_para_a_esquerda;
            this.btn_desfazer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_desfazer.Name = "btn_desfazer";
            this.btn_desfazer.Size = new System.Drawing.Size(91, 24);
            this.btn_desfazer.Text = "Desfazer";
            this.btn_desfazer.Click += new System.EventHandler(this.btn_desfazer_Click);
            // 
            // btn_copiar
            // 
            this.btn_copiar.Image = global::Editor_de_Texto.Properties.Resources.Copiar1;
            this.btn_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(77, 24);
            this.btn_copiar.Text = "Copiar";
            this.btn_copiar.Click += new System.EventHandler(this.btn_copiar_Click);
            // 
            // btn_cortar
            // 
            this.btn_cortar.Image = global::Editor_de_Texto.Properties.Resources.tesoura;
            this.btn_cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cortar.Name = "btn_cortar";
            this.btn_cortar.Size = new System.Drawing.Size(74, 24);
            this.btn_cortar.Text = "Cortar";
            this.btn_cortar.Click += new System.EventHandler(this.btn_cortar_Click);
            // 
            // btn_colar
            // 
            this.btn_colar.Image = global::Editor_de_Texto.Properties.Resources.Colar;
            this.btn_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_colar.Name = "btn_colar";
            this.btn_colar.Size = new System.Drawing.Size(68, 24);
            this.btn_colar.Text = "Colar";
            this.btn_colar.Click += new System.EventHandler(this.btn_colar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_fonte
            // 
            this.btn_fonte.Image = global::Editor_de_Texto.Properties.Resources.mudar;
            this.btn_fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_fonte.Name = "btn_fonte";
            this.btn_fonte.Size = new System.Drawing.Size(70, 24);
            this.btn_fonte.Text = "Fonte";
            this.btn_fonte.Click += new System.EventHandler(this.btn_fonte_Click);
            // 
            // btn_tamanho
            // 
            this.btn_tamanho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tam_6,
            this.tam_8,
            this.tam_10,
            this.tam_12,
            this.tam_16,
            this.tam_20,
            this.tam_24,
            this.tam_32});
            this.btn_tamanho.Image = global::Editor_de_Texto.Properties.Resources.tamanho_da_fonte;
            this.btn_tamanho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_tamanho.Name = "btn_tamanho";
            this.btn_tamanho.Size = new System.Drawing.Size(103, 24);
            this.btn_tamanho.Text = "Tamanho";
            // 
            // tam_6
            // 
            this.tam_6.Name = "tam_6";
            this.tam_6.Size = new System.Drawing.Size(108, 26);
            this.tam_6.Text = "6";
            this.tam_6.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tam_8
            // 
            this.tam_8.Name = "tam_8";
            this.tam_8.Size = new System.Drawing.Size(108, 26);
            this.tam_8.Text = "8";
            this.tam_8.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // tam_10
            // 
            this.tam_10.Name = "tam_10";
            this.tam_10.Size = new System.Drawing.Size(108, 26);
            this.tam_10.Text = "10";
            this.tam_10.Click += new System.EventHandler(this.tam_10_Click);
            // 
            // tam_12
            // 
            this.tam_12.Name = "tam_12";
            this.tam_12.ShowShortcutKeys = false;
            this.tam_12.Size = new System.Drawing.Size(108, 26);
            this.tam_12.Text = "12";
            this.tam_12.Click += new System.EventHandler(this.tam_12_Click);
            // 
            // tam_16
            // 
            this.tam_16.Name = "tam_16";
            this.tam_16.Size = new System.Drawing.Size(108, 26);
            this.tam_16.Text = "16";
            this.tam_16.Click += new System.EventHandler(this.tam_16_Click);
            // 
            // tam_20
            // 
            this.tam_20.Name = "tam_20";
            this.tam_20.Size = new System.Drawing.Size(108, 26);
            this.tam_20.Text = "20";
            this.tam_20.Click += new System.EventHandler(this.tam_20_Click);
            // 
            // tam_24
            // 
            this.tam_24.Name = "tam_24";
            this.tam_24.Size = new System.Drawing.Size(108, 26);
            this.tam_24.Text = "24";
            this.tam_24.Click += new System.EventHandler(this.tam_24_Click);
            // 
            // tam_32
            // 
            this.tam_32.Name = "tam_32";
            this.tam_32.Size = new System.Drawing.Size(108, 26);
            this.tam_32.Text = "32";
            this.tam_32.Click += new System.EventHandler(this.tam_32_Click);
            // 
            // tb_tamanho
            // 
            this.tb_tamanho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_tamanho.Name = "tb_tamanho";
            this.tb_tamanho.Size = new System.Drawing.Size(25, 27);
            this.tb_tamanho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_tamanho_KeyDown);
            // 
            // btn_cor
            // 
            this.btn_cor.BackColor = System.Drawing.Color.White;
            this.btn_cor.Image = global::Editor_de_Texto.Properties.Resources.cor;
            this.btn_cor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cor.Name = "btn_cor";
            this.btn_cor.Size = new System.Drawing.Size(56, 24);
            this.btn_cor.Text = "Cor";
            this.btn_cor.Click += new System.EventHandler(this.btn_cor_Click);
            // 
            // btn_negrito
            // 
            this.btn_negrito.BackColor = System.Drawing.SystemColors.Control;
            this.btn_negrito.CheckOnClick = true;
            this.btn_negrito.Image = global::Editor_de_Texto.Properties.Resources.negrito1;
            this.btn_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_negrito.Name = "btn_negrito";
            this.btn_negrito.Size = new System.Drawing.Size(84, 24);
            this.btn_negrito.Text = "Negrito";
            this.btn_negrito.Click += new System.EventHandler(this.btn_negrito_Click);
            // 
            // btn_italico
            // 
            this.btn_italico.CheckOnClick = true;
            this.btn_italico.Image = global::Editor_de_Texto.Properties.Resources.italico1;
            this.btn_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_italico.Name = "btn_italico";
            this.btn_italico.Size = new System.Drawing.Size(74, 24);
            this.btn_italico.Text = "Itálico";
            this.btn_italico.Click += new System.EventHandler(this.btn_italico_Click);
            // 
            // btn_sublinhar
            // 
            this.btn_sublinhar.CheckOnClick = true;
            this.btn_sublinhar.Image = global::Editor_de_Texto.Properties.Resources.sublinhado;
            this.btn_sublinhar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sublinhar.Name = "btn_sublinhar";
            this.btn_sublinhar.Size = new System.Drawing.Size(95, 24);
            this.btn_sublinhar.Text = "Sublinhar";
            this.btn_sublinhar.Click += new System.EventHandler(this.btn_sublinhar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_esquerda
            // 
            this.btn_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_esquerda.Image = global::Editor_de_Texto.Properties.Resources.alinhar_a_esquerda;
            this.btn_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_esquerda.Name = "btn_esquerda";
            this.btn_esquerda.Size = new System.Drawing.Size(29, 24);
            this.btn_esquerda.Text = "Alinhar à esquerda";
            this.btn_esquerda.Click += new System.EventHandler(this.btn_esquerda_Click);
            // 
            // btn_centralizar
            // 
            this.btn_centralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_centralizar.Image = global::Editor_de_Texto.Properties.Resources.Centralizar;
            this.btn_centralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_centralizar.Name = "btn_centralizar";
            this.btn_centralizar.Size = new System.Drawing.Size(29, 24);
            this.btn_centralizar.Text = "Centralizar";
            this.btn_centralizar.Click += new System.EventHandler(this.btn_centralizar_Click);
            // 
            // btn_direita
            // 
            this.btn_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_direita.Image = global::Editor_de_Texto.Properties.Resources.alinhar_a_direita;
            this.btn_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_direita.Name = "btn_direita";
            this.btn_direita.Size = new System.Drawing.Size(29, 24);
            this.btn_direita.Text = "Alinhar à direita";
            this.btn_direita.Click += new System.EventHandler(this.btn_direita_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "(*.rtf)|*.rtf";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // F_editor_texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_editor_texto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.Load += new System.EventHandler(this.F_editor_texto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinharÀEsquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ainharÀDireitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_novo;
        private System.Windows.Forms.ToolStripButton btn_abir;
        private System.Windows.Forms.ToolStripButton btn_salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_copiar;
        private System.Windows.Forms.ToolStripButton btn_colar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_fonte;
        private System.Windows.Forms.ToolStripButton btn_negrito;
        private System.Windows.Forms.ToolStripButton btn_italico;
        private System.Windows.Forms.ToolStripButton btn_sublinhar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_esquerda;
        private System.Windows.Forms.ToolStripButton btn_centralizar;
        private System.Windows.Forms.ToolStripButton btn_direita;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_cortar;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_desfazer;
        private System.Windows.Forms.ToolStripButton btn_cor;
        private System.Windows.Forms.ToolStripTextBox tb_tamanho;
        private System.Windows.Forms.ToolStripDropDownButton btn_tamanho;
        private System.Windows.Forms.ToolStripMenuItem tam_6;
        private System.Windows.Forms.ToolStripMenuItem tam_8;
        private System.Windows.Forms.ToolStripMenuItem tam_10;
        private System.Windows.Forms.ToolStripMenuItem tam_12;
        private System.Windows.Forms.ToolStripMenuItem tam_16;
        private System.Windows.Forms.ToolStripMenuItem tam_20;
        private System.Windows.Forms.ToolStripMenuItem tam_24;
        private System.Windows.Forms.ToolStripMenuItem tam_32;
    }
}

