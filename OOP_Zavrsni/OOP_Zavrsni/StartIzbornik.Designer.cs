namespace OOP_Zavrsni
{
    partial class StartIzbornik
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartTipka = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zatvoriIgru = new System.Windows.Forms.Button();
            this.pomocButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(166, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPACE TRAVEL";
            // 
            // StartTipka
            // 
            this.StartTipka.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartTipka.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTipka.Location = new System.Drawing.Point(395, 183);
            this.StartTipka.Name = "StartTipka";
            this.StartTipka.Size = new System.Drawing.Size(226, 116);
            this.StartTipka.TabIndex = 1;
            this.StartTipka.Text = "START";
            this.StartTipka.UseVisualStyleBackColor = true;
            this.StartTipka.Click += new System.EventHandler(this.StartGame);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OOP_Zavrsni.Properties.Resources.avion;
            this.pictureBox1.Location = new System.Drawing.Point(73, 700);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // zatvoriIgru
            // 
            this.zatvoriIgru.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zatvoriIgru.Location = new System.Drawing.Point(395, 546);
            this.zatvoriIgru.Name = "zatvoriIgru";
            this.zatvoriIgru.Size = new System.Drawing.Size(226, 116);
            this.zatvoriIgru.TabIndex = 4;
            this.zatvoriIgru.Text = "ZATVORI IGRU";
            this.zatvoriIgru.UseVisualStyleBackColor = true;
            this.zatvoriIgru.Click += new System.EventHandler(this.zatvoriTipka);
            // 
            // pomocButton
            // 
            this.pomocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomocButton.Location = new System.Drawing.Point(395, 363);
            this.pomocButton.Name = "pomocButton";
            this.pomocButton.Size = new System.Drawing.Size(226, 116);
            this.pomocButton.TabIndex = 6;
            this.pomocButton.Text = "POMOĆ";
            this.pomocButton.UseVisualStyleBackColor = true;
            this.pomocButton.Click += new System.EventHandler(this.pomocTipka);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::OOP_Zavrsni.Properties.Resources.avion;
            this.pictureBox2.Location = new System.Drawing.Point(750, 700);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // StartIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_Zavrsni.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pomocButton);
            this.Controls.Add(this.zatvoriIgru);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartTipka);
            this.Controls.Add(this.label1);
            this.Name = "StartIzbornik";
            this.Text = "StartIzbornik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.startIzbornikZatvoren);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartTipka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button zatvoriIgru;
        private System.Windows.Forms.Button pomocButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}