namespace EsCalendario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            daycontainer = new FlowLayoutPanel();
            btn_prossimo = new Button();
            btn_precedente = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            LB_Date = new Label();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(12, 128);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1107, 693);
            daycontainer.TabIndex = 0;
            // 
            // btn_prossimo
            // 
            btn_prossimo.Location = new Point(1044, 827);
            btn_prossimo.Name = "btn_prossimo";
            btn_prossimo.Size = new Size(75, 32);
            btn_prossimo.TabIndex = 1;
            btn_prossimo.Text = ">";
            btn_prossimo.UseVisualStyleBackColor = true;
            btn_prossimo.Click += btn_prossimo_Click;
            // 
            // btn_precedente
            // 
            btn_precedente.Location = new Point(951, 827);
            btn_precedente.Name = "btn_precedente";
            btn_precedente.Size = new Size(87, 32);
            btn_precedente.TabIndex = 2;
            btn_precedente.Text = "<";
            btn_precedente.UseVisualStyleBackColor = true;
            btn_precedente.Click += btn_precedente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 92);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 3;
            label1.Text = "Lunedì";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(209, 92);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 4;
            label2.Text = "Martedì";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(526, 92);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 6;
            label3.Text = "Giovedì";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(368, 92);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 5;
            label4.Text = "Mercoledì";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(837, 92);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 8;
            label5.Text = "Sabato";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(674, 92);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 7;
            label6.Text = "Venerdì";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(983, 92);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 9;
            label7.Text = "Domenica";
            // 
            // LB_Date
            // 
            LB_Date.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_Date.ForeColor = Color.Red;
            LB_Date.Location = new Point(287, 19);
            LB_Date.Name = "LB_Date";
            LB_Date.Size = new Size(549, 34);
            LB_Date.TabIndex = 10;
            LB_Date.Text = "MESE ANNO ";
            LB_Date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1144, 871);
            Controls.Add(LB_Date);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_precedente);
            Controls.Add(btn_prossimo);
            Controls.Add(daycontainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Button btn_prossimo;
        private Button btn_precedente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label LB_Date;
    }
}
