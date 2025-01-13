namespace EsCalendario
{
    partial class UserControlGiorni
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            lb_giorni = new Label();
            SuspendLayout();
            // 
            // lb_giorni
            // 
            lb_giorni.AutoSize = true;
            lb_giorni.BackColor = Color.White;
            lb_giorni.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_giorni.ForeColor = Color.Black;
            lb_giorni.Location = new Point(17, 20);
            lb_giorni.Name = "lb_giorni";
            lb_giorni.Size = new Size(28, 21);
            lb_giorni.TabIndex = 0;
            lb_giorni.Text = "00";
            // 
            // UserControlGiorni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lb_giorni);
            ForeColor = SystemColors.ControlText;
            Name = "UserControlGiorni";
            Size = new Size(150, 108);
            Load += UserControlGiorni_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_giorni;
    }
}
