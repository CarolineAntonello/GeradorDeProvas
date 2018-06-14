namespace GeradorDeProvas.WinApp.Features.MateriaModule
{
    partial class ControlMateria
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
            this.listMateria = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listMateria
            // 
            this.listMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMateria.FormattingEnabled = true;
            this.listMateria.Location = new System.Drawing.Point(0, 0);
            this.listMateria.Name = "listMateria";
            this.listMateria.Size = new System.Drawing.Size(413, 272);
            this.listMateria.TabIndex = 0;
            // 
            // ControlMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMateria);
            this.Name = "ControlMateria";
            this.Size = new System.Drawing.Size(413, 272);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMateria;
    }
}
