namespace GeradorDeProvas.WinApp.Features.ProvaModule
{
    partial class FormProva
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSerie = new System.Windows.Forms.ComboBox();
            this.cbxDisciplina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericQuantidadeQuestoes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listQuestoes = new System.Windows.Forms.ListBox();
            this.statusStripProva = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidadeQuestoes)).BeginInit();
            this.statusStripProva.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(273, 347);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Cancelar";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(154, 347);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Matéria:";
            // 
            // cbxSerie
            // 
            this.cbxSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSerie.FormattingEnabled = true;
            this.cbxSerie.Location = new System.Drawing.Point(24, 27);
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.Size = new System.Drawing.Size(218, 23);
            this.cbxSerie.TabIndex = 14;
            this.cbxSerie.SelectedValueChanged += new System.EventHandler(this.cbxSerie_SelectedValueChanged);
            // 
            // cbxDisciplina
            // 
            this.cbxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisciplina.FormattingEnabled = true;
            this.cbxDisciplina.Location = new System.Drawing.Point(263, 27);
            this.cbxDisciplina.Name = "cbxDisciplina";
            this.cbxDisciplina.Size = new System.Drawing.Size(218, 23);
            this.cbxDisciplina.TabIndex = 13;
            this.cbxDisciplina.SelectedValueChanged += new System.EventHandler(this.cbxDisciplina_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Série:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Disciplina:";
            // 
            // cbxMateria
            // 
            this.cbxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(24, 84);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(218, 23);
            this.cbxMateria.TabIndex = 19;
            this.cbxMateria.SelectedValueChanged += new System.EventHandler(this.cbxMateria_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantidade de Questões:";
            // 
            // numericQuantidadeQuestoes
            // 
            this.numericQuantidadeQuestoes.Location = new System.Drawing.Point(412, 87);
            this.numericQuantidadeQuestoes.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericQuantidadeQuestoes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantidadeQuestoes.Name = "numericQuantidadeQuestoes";
            this.numericQuantidadeQuestoes.ReadOnly = true;
            this.numericQuantidadeQuestoes.Size = new System.Drawing.Size(69, 20);
            this.numericQuantidadeQuestoes.TabIndex = 21;
            this.numericQuantidadeQuestoes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantidadeQuestoes.ValueChanged += new System.EventHandler(this.numericQuantidadeQuestoes_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Questões:";
            // 
            // listQuestoes
            // 
            this.listQuestoes.FormattingEnabled = true;
            this.listQuestoes.Location = new System.Drawing.Point(24, 161);
            this.listQuestoes.Name = "listQuestoes";
            this.listQuestoes.Size = new System.Drawing.Size(457, 160);
            this.listQuestoes.TabIndex = 24;
            // 
            // statusStripProva
            // 
            this.statusStripProva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStripProva.Location = new System.Drawing.Point(0, 390);
            this.statusStripProva.Name = "statusStripProva";
            this.statusStripProva.Size = new System.Drawing.Size(503, 22);
            this.statusStripProva.SizingGrip = false;
            this.statusStripProva.TabIndex = 25;
            this.statusStripProva.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FormProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 412);
            this.Controls.Add(this.statusStripProva);
            this.Controls.Add(this.listQuestoes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericQuantidadeQuestoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSerie);
            this.Controls.Add(this.cbxDisciplina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(519, 451);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(519, 451);
            this.Name = "FormProva";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Prova";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidadeQuestoes)).EndInit();
            this.statusStripProva.ResumeLayout(false);
            this.statusStripProva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSerie;
        private System.Windows.Forms.ComboBox cbxDisciplina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericQuantidadeQuestoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listQuestoes;
        private System.Windows.Forms.StatusStrip statusStripProva;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
    }
}