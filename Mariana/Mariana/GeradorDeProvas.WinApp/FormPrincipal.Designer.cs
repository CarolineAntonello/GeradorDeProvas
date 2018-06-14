namespace GeradorDeProvas.WinApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSerie = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuestao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.provasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCadastrarProva = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnRemover = new System.Windows.Forms.ToolStripButton();
            this.lblTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.btnGerarProva = new System.Windows.Forms.ToolStripButton();
            this.panelControl = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExportarCSV = new System.Windows.Forms.ToolStripButton();
            this.btnExportarXML = new System.Windows.Forms.ToolStripButton();
            this.menuStripPrincipal.SuspendLayout();
            this.toolStripPrincipal.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.provasToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(629, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDisciplina,
            this.menuItemSerie,
            this.menuItemMateria,
            this.menuItemQuestao,
            this.menuItemSair});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuItemDisciplina
            // 
            this.menuItemDisciplina.Name = "menuItemDisciplina";
            this.menuItemDisciplina.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuItemDisciplina.Size = new System.Drawing.Size(170, 22);
            this.menuItemDisciplina.Text = "Disciplina";
            this.menuItemDisciplina.Click += new System.EventHandler(this.menuItemDisciplina_Click);
            // 
            // menuItemSerie
            // 
            this.menuItemSerie.Name = "menuItemSerie";
            this.menuItemSerie.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSerie.Size = new System.Drawing.Size(170, 22);
            this.menuItemSerie.Text = "Série";
            this.menuItemSerie.Click += new System.EventHandler(this.menuItemSerie_Click);
            // 
            // menuItemMateria
            // 
            this.menuItemMateria.Name = "menuItemMateria";
            this.menuItemMateria.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menuItemMateria.Size = new System.Drawing.Size(170, 22);
            this.menuItemMateria.Text = "Matéria";
            this.menuItemMateria.Click += new System.EventHandler(this.menuItemMateria_Click);
            // 
            // menuItemQuestao
            // 
            this.menuItemQuestao.Name = "menuItemQuestao";
            this.menuItemQuestao.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuItemQuestao.Size = new System.Drawing.Size(170, 22);
            this.menuItemQuestao.Text = "Questão";
            this.menuItemQuestao.Click += new System.EventHandler(this.menuItemQuestao_Click);
            // 
            // menuItemSair
            // 
            this.menuItemSair.Name = "menuItemSair";
            this.menuItemSair.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.menuItemSair.Size = new System.Drawing.Size(170, 22);
            this.menuItemSair.Text = "Sair";
            this.menuItemSair.Click += new System.EventHandler(this.menuItemSair_Click);
            // 
            // provasToolStripMenuItem
            // 
            this.provasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCadastrarProva});
            this.provasToolStripMenuItem.Name = "provasToolStripMenuItem";
            this.provasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.provasToolStripMenuItem.Text = "Provas";
            // 
            // menuItemCadastrarProva
            // 
            this.menuItemCadastrarProva.Name = "menuItemCadastrarProva";
            this.menuItemCadastrarProva.Size = new System.Drawing.Size(157, 22);
            this.menuItemCadastrarProva.Text = "Cadastrar Prova";
            this.menuItemCadastrarProva.Click += new System.EventHandler(this.menuItemCadastrarProva_Click);
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnEditar,
            this.btnRemover,
            this.lblTipoCadastro,
            this.btnGerarProva,
            this.btnExportarCSV,
            this.btnExportarXML});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 24);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripPrincipal.Size = new System.Drawing.Size(629, 39);
            this.toolStripPrincipal.TabIndex = 2;
            this.toolStripPrincipal.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(24, 28);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(24, 28);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemover.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(24, 28);
            this.btnRemover.Text = "Excluir";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblTipoCadastro
            // 
            this.lblTipoCadastro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblTipoCadastro.Enabled = false;
            this.lblTipoCadastro.Name = "lblTipoCadastro";
            this.lblTipoCadastro.Size = new System.Drawing.Size(106, 28);
            this.lblTipoCadastro.Text = "[Tipo Selecionado]";
            this.lblTipoCadastro.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // btnGerarProva
            // 
            this.btnGerarProva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGerarProva.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarProva.Image")));
            this.btnGerarProva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGerarProva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGerarProva.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnGerarProva.Name = "btnGerarProva";
            this.btnGerarProva.Size = new System.Drawing.Size(28, 28);
            this.btnGerarProva.Text = "Gerar Prova";
            this.btnGerarProva.Visible = false;
            this.btnGerarProva.Click += new System.EventHandler(this.buttonGerarProva_Click);
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Location = new System.Drawing.Point(12, 66);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(605, 318);
            this.panelControl.TabIndex = 3;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 397);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(629, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportarCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarCSV.Image")));
            this.btnExportarCSV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportarCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarCSV.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(28, 28);
            this.btnExportarCSV.Text = "Exportar em CSV";
            this.btnExportarCSV.Visible = false;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // btnExportarXML
            // 
            this.btnExportarXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportarXML.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarXML.Image")));
            this.btnExportarXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExportarXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarXML.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnExportarXML.Name = "btnExportarXML";
            this.btnExportarXML.Size = new System.Drawing.Size(28, 28);
            this.btnExportarXML.Text = "Exportar em XML";
            this.btnExportarXML.Visible = false;
            this.btnExportarXML.Click += new System.EventHandler(this.btnExportarXML_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 419);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.toolStripPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Provas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemDisciplina;
        private System.Windows.Forms.ToolStripMenuItem menuItemSair;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnRemover;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ToolStripLabel lblTipoCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuestao;
        private System.Windows.Forms.ToolStripMenuItem menuItemMateria;
        private System.Windows.Forms.ToolStripMenuItem provasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItemSerie;
        private System.Windows.Forms.ToolStripMenuItem menuItemCadastrarProva;
        private System.Windows.Forms.ToolStripButton btnGerarProva;
        private System.Windows.Forms.ToolStripButton btnExportarCSV;
        private System.Windows.Forms.ToolStripButton btnExportarXML;
    }
}

