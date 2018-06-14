namespace GeradorDeProvas.WinApp.Features.SerieModule
{
    partial class ControlSerie
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSerie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listSerie
            // 
            this.listSerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSerie.FormattingEnabled = true;
            this.listSerie.Location = new System.Drawing.Point(0, 0);
            this.listSerie.Name = "listSerie";
            this.listSerie.Size = new System.Drawing.Size(272, 288);
            this.listSerie.TabIndex = 0;
            // 
            // ControlSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listSerie);
            this.Name = "ControlSerie";
            this.Size = new System.Drawing.Size(272, 288);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSerie;
    }
}
