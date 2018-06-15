namespace GeradorDeProvas.WinApp.Features.QuestaoModule
{
    partial class ControlQuestao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listQuestao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listQuestao
            // 
            this.listQuestao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listQuestao.FormattingEnabled = true;
            this.listQuestao.Location = new System.Drawing.Point(0, 0);
            this.listQuestao.Name = "listQuestao";
            this.listQuestao.Size = new System.Drawing.Size(150, 150);
            this.listQuestao.TabIndex = 0;
            // 
            // ControlQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listQuestao);
            this.Name = "ControlQuestao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listQuestao;
    }
}
