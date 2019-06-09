namespace gra_Wisielec
{
    partial class Szubienica
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
            this.BtnGraj = new System.Windows.Forms.Button();
            this.BtnWyjscie = new System.Windows.Forms.Button();
            this.LblNapis = new System.Windows.Forms.Label();
            this.BtnTrudny = new System.Windows.Forms.Button();
            this.BtnSredni = new System.Windows.Forms.Button();
            this.BtnLatwy = new System.Windows.Forms.Button();
            this.PictureSzubienica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSzubienica)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGraj
            // 
            this.BtnGraj.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnGraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGraj.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnGraj.Location = new System.Drawing.Point(230, 261);
            this.BtnGraj.Name = "BtnGraj";
            this.BtnGraj.Size = new System.Drawing.Size(127, 40);
            this.BtnGraj.TabIndex = 20;
            this.BtnGraj.Text = "GRAJ";
            this.BtnGraj.UseVisualStyleBackColor = false;
            this.BtnGraj.Click += new System.EventHandler(this.BtnGraj_Click);
            // 
            // BtnWyjscie
            // 
            this.BtnWyjscie.BackColor = System.Drawing.Color.Red;
            this.BtnWyjscie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWyjscie.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnWyjscie.Location = new System.Drawing.Point(17, 261);
            this.BtnWyjscie.Name = "BtnWyjscie";
            this.BtnWyjscie.Size = new System.Drawing.Size(127, 40);
            this.BtnWyjscie.TabIndex = 19;
            this.BtnWyjscie.Text = "Wyjscie";
            this.BtnWyjscie.UseVisualStyleBackColor = false;
            this.BtnWyjscie.Click += new System.EventHandler(this.BtnWyjscie_Click);
            // 
            // LblNapis
            // 
            this.LblNapis.AutoSize = true;
            this.LblNapis.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblNapis.Location = new System.Drawing.Point(388, 30);
            this.LblNapis.Name = "LblNapis";
            this.LblNapis.Size = new System.Drawing.Size(139, 44);
            this.LblNapis.TabIndex = 18;
            this.LblNapis.Text = "Wybierz poziom \r\ntrudności gry!!";
            this.LblNapis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTrudny
            // 
            this.BtnTrudny.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnTrudny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTrudny.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnTrudny.Location = new System.Drawing.Point(406, 235);
            this.BtnTrudny.Name = "BtnTrudny";
            this.BtnTrudny.Size = new System.Drawing.Size(121, 67);
            this.BtnTrudny.TabIndex = 17;
            this.BtnTrudny.Text = "Poziom\r\nTrudny";
            this.BtnTrudny.UseVisualStyleBackColor = true;
            this.BtnTrudny.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTrudny_MouseDown);
            // 
            // BtnSredni
            // 
            this.BtnSredni.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSredni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSredni.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSredni.Location = new System.Drawing.Point(406, 162);
            this.BtnSredni.Name = "BtnSredni";
            this.BtnSredni.Size = new System.Drawing.Size(121, 67);
            this.BtnSredni.TabIndex = 16;
            this.BtnSredni.Text = "Poziom\r\nŚredni";
            this.BtnSredni.UseVisualStyleBackColor = true;
            this.BtnSredni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSredni_MouseDown);
            // 
            // BtnLatwy
            // 
            this.BtnLatwy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnLatwy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLatwy.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnLatwy.Location = new System.Drawing.Point(406, 89);
            this.BtnLatwy.Name = "BtnLatwy";
            this.BtnLatwy.Size = new System.Drawing.Size(121, 67);
            this.BtnLatwy.TabIndex = 15;
            this.BtnLatwy.Text = "Poziom\r\nŁatwy";
            this.BtnLatwy.UseVisualStyleBackColor = true;
            this.BtnLatwy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLatwy_MouseDown);
            // 
            // PictureSzubienica
            // 
            this.PictureSzubienica.Image = global::gra_Wisielec.Properties.Resources.s9;
            this.PictureSzubienica.Location = new System.Drawing.Point(12, 12);
            this.PictureSzubienica.Name = "PictureSzubienica";
            this.PictureSzubienica.Size = new System.Drawing.Size(353, 204);
            this.PictureSzubienica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSzubienica.TabIndex = 14;
            this.PictureSzubienica.TabStop = false;
            // 
            // Szubienica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 402);
            this.Controls.Add(this.BtnGraj);
            this.Controls.Add(this.BtnWyjscie);
            this.Controls.Add(this.LblNapis);
            this.Controls.Add(this.BtnTrudny);
            this.Controls.Add(this.BtnSredni);
            this.Controls.Add(this.BtnLatwy);
            this.Controls.Add(this.PictureSzubienica);
            this.Name = "Szubienica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szubienica";
            ((System.ComponentModel.ISupportInitialize)(this.PictureSzubienica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGraj;
        private System.Windows.Forms.Button BtnWyjscie;
        private System.Windows.Forms.Label LblNapis;
        private System.Windows.Forms.Button BtnTrudny;
        private System.Windows.Forms.Button BtnSredni;
        private System.Windows.Forms.Button BtnLatwy;
        private System.Windows.Forms.PictureBox PictureSzubienica;
    }
}

