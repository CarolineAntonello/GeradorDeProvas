namespace GeradorDeProvas.WinApp.Features.QuestaoModule
{
    partial class FormQuestao
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.cbxBimestre = new System.Windows.Forms.ComboBox();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.lblBimestre = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.RichTextBox();
            this.listBoxAlternativas = new System.Windows.Forms.ListBox();
            this.lblAlternaativa = new System.Windows.Forms.Label();
            this.txtAlternativa = new System.Windows.Forms.TextBox();
            this.btnRemoverAlternativa = new System.Windows.Forms.Button();
            this.btnAddAlternativa = new System.Windows.Forms.Button();
            this.cmbAlternativaCorreta = new System.Windows.Forms.ComboBox();
            this.lblCorreta = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(274, 483);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Cancelar";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(155, 483);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(31, 161);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(60, 15);
            this.lblPergunta.TabIndex = 17;
            this.lblPergunta.Text = "Pergunta:";
            // 
            // cbxBimestre
            // 
            this.cbxBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBimestre.FormattingEnabled = true;
            this.cbxBimestre.Location = new System.Drawing.Point(34, 116);
            this.cbxBimestre.Name = "cbxBimestre";
            this.cbxBimestre.Size = new System.Drawing.Size(206, 23);
            this.cbxBimestre.TabIndex = 16;
            // 
            // cbxMateria
            // 
            this.cbxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(34, 52);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(439, 23);
            this.cbxMateria.TabIndex = 15;
            // 
            // lblBimestre
            // 
            this.lblBimestre.AutoSize = true;
            this.lblBimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBimestre.Location = new System.Drawing.Point(32, 98);
            this.lblBimestre.Name = "lblBimestre";
            this.lblBimestre.Size = new System.Drawing.Size(59, 15);
            this.lblBimestre.TabIndex = 14;
            this.lblBimestre.Text = "Bimestre:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(32, 34);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(52, 15);
            this.lblMateria.TabIndex = 13;
            this.lblMateria.Text = "Matéria:";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(34, 184);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(439, 96);
            this.txtPergunta.TabIndex = 19;
            this.txtPergunta.Text = "";
            this.txtPergunta.TextChanged += new System.EventHandler(this.LimparErroAoDigitar);
            // 
            // listBoxAlternativas
            // 
            this.listBoxAlternativas.FormattingEnabled = true;
            this.listBoxAlternativas.Location = new System.Drawing.Point(34, 343);
            this.listBoxAlternativas.Name = "listBoxAlternativas";
            this.listBoxAlternativas.Size = new System.Drawing.Size(439, 95);
            this.listBoxAlternativas.TabIndex = 20;
            // 
            // lblAlternaativa
            // 
            this.lblAlternaativa.AutoSize = true;
            this.lblAlternaativa.Location = new System.Drawing.Point(31, 311);
            this.lblAlternaativa.Name = "lblAlternaativa";
            this.lblAlternaativa.Size = new System.Drawing.Size(60, 13);
            this.lblAlternaativa.TabIndex = 21;
            this.lblAlternaativa.Text = "Alternativa:";
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.Location = new System.Drawing.Point(97, 308);
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(316, 20);
            this.txtAlternativa.TabIndex = 22;
            this.txtAlternativa.TextChanged += new System.EventHandler(this.LimparErroAoDigitar);
            // 
            // btnRemoverAlternativa
            // 
            this.btnRemoverAlternativa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverAlternativa.Image = global::GeradorDeProvas.WinApp.Properties.Resources.if_Remove_27874;
            this.btnRemoverAlternativa.Location = new System.Drawing.Point(449, 304);
            this.btnRemoverAlternativa.Name = "btnRemoverAlternativa";
            this.btnRemoverAlternativa.Size = new System.Drawing.Size(24, 26);
            this.btnRemoverAlternativa.TabIndex = 24;
            this.btnRemoverAlternativa.UseVisualStyleBackColor = true;
            this.btnRemoverAlternativa.Click += new System.EventHandler(this.btnRemoverAlternativa_Click);
            // 
            // btnAddAlternativa
            // 
            this.btnAddAlternativa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAlternativa.Image = global::GeradorDeProvas.WinApp.Properties.Resources.btnAdicionar;
            this.btnAddAlternativa.Location = new System.Drawing.Point(419, 304);
            this.btnAddAlternativa.Name = "btnAddAlternativa";
            this.btnAddAlternativa.Size = new System.Drawing.Size(24, 26);
            this.btnAddAlternativa.TabIndex = 23;
            this.btnAddAlternativa.UseVisualStyleBackColor = true;
            this.btnAddAlternativa.Click += new System.EventHandler(this.btnAddAlternativa_Click);
            // 
            // cmbAlternativaCorreta
            // 
            this.cmbAlternativaCorreta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlternativaCorreta.FormattingEnabled = true;
            this.cmbAlternativaCorreta.Location = new System.Drawing.Point(133, 444);
            this.cmbAlternativaCorreta.Name = "cmbAlternativaCorreta";
            this.cmbAlternativaCorreta.Size = new System.Drawing.Size(340, 21);
            this.cmbAlternativaCorreta.TabIndex = 25;
            // 
            // lblCorreta
            // 
            this.lblCorreta.AutoSize = true;
            this.lblCorreta.Location = new System.Drawing.Point(31, 447);
            this.lblCorreta.Name = "lblCorreta";
            this.lblCorreta.Size = new System.Drawing.Size(96, 13);
            this.lblCorreta.TabIndex = 26;
            this.lblCorreta.Text = "Alternativa correta:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FormQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 541);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblCorreta);
            this.Controls.Add(this.cmbAlternativaCorreta);
            this.Controls.Add(this.btnRemoverAlternativa);
            this.Controls.Add(this.btnAddAlternativa);
            this.Controls.Add(this.txtAlternativa);
            this.Controls.Add(this.lblAlternaativa);
            this.Controls.Add(this.listBoxAlternativas);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.cbxBimestre);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.lblBimestre);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 580);
            this.Name = "FormQuestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questao";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.ComboBox cbxBimestre;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.Label lblBimestre;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.RichTextBox txtPergunta;
        private System.Windows.Forms.ListBox listBoxAlternativas;
        private System.Windows.Forms.Label lblAlternaativa;
        private System.Windows.Forms.TextBox txtAlternativa;
        private System.Windows.Forms.Button btnAddAlternativa;
        private System.Windows.Forms.Button btnRemoverAlternativa;
        private System.Windows.Forms.ComboBox cmbAlternativaCorreta;
        private System.Windows.Forms.Label lblCorreta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
    }
}