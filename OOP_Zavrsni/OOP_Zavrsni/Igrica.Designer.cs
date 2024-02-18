namespace OOP_Zavrsni
{
    partial class Igrica
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
            this.components = new System.ComponentModel.Container();
            this.Meteor1 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Meteor2 = new System.Windows.Forms.PictureBox();
            this.Meteor3 = new System.Windows.Forms.PictureBox();
            this.avion = new System.Windows.Forms.PictureBox();
            this.rezultatTXT = new System.Windows.Forms.Label();
            this.restartTipka = new System.Windows.Forms.Button();
            this.Meteor4 = new System.Windows.Forms.PictureBox();
            this.TipkaNazad = new System.Windows.Forms.PictureBox();
            this.gameOverBox = new System.Windows.Forms.Panel();
            this.highScoreTXT = new System.Windows.Forms.Label();
            this.rezultat2TXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipkaNazad)).BeginInit();
            this.gameOverBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Meteor1
            // 
            this.Meteor1.BackColor = System.Drawing.Color.Transparent;
            this.Meteor1.Image = global::OOP_Zavrsni.Properties.Resources.meteorit;
            this.Meteor1.Location = new System.Drawing.Point(26, 62);
            this.Meteor1.Name = "Meteor1";
            this.Meteor1.Size = new System.Drawing.Size(56, 56);
            this.Meteor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Meteor1.TabIndex = 1;
            this.Meteor1.TabStop = false;
            this.Meteor1.Tag = "prviMeteor";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.TimerIgreEvent);
            // 
            // Meteor2
            // 
            this.Meteor2.BackColor = System.Drawing.Color.Transparent;
            this.Meteor2.Image = global::OOP_Zavrsni.Properties.Resources.meteorit1;
            this.Meteor2.Location = new System.Drawing.Point(313, 62);
            this.Meteor2.Name = "Meteor2";
            this.Meteor2.Size = new System.Drawing.Size(56, 56);
            this.Meteor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Meteor2.TabIndex = 2;
            this.Meteor2.TabStop = false;
            this.Meteor2.Tag = "drugiMeteor";
            // 
            // Meteor3
            // 
            this.Meteor3.BackColor = System.Drawing.Color.Transparent;
            this.Meteor3.Image = global::OOP_Zavrsni.Properties.Resources.meteorit;
            this.Meteor3.Location = new System.Drawing.Point(586, 62);
            this.Meteor3.Name = "Meteor3";
            this.Meteor3.Size = new System.Drawing.Size(56, 56);
            this.Meteor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Meteor3.TabIndex = 3;
            this.Meteor3.TabStop = false;
            this.Meteor3.Tag = "treciMeteor";
            // 
            // avion
            // 
            this.avion.BackColor = System.Drawing.Color.Transparent;
            this.avion.Image = global::OOP_Zavrsni.Properties.Resources.avion;
            this.avion.Location = new System.Drawing.Point(406, 631);
            this.avion.Name = "avion";
            this.avion.Size = new System.Drawing.Size(58, 53);
            this.avion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.avion.TabIndex = 5;
            this.avion.TabStop = false;
            this.avion.Tag = "avion";
            // 
            // rezultatTXT
            // 
            this.rezultatTXT.BackColor = System.Drawing.Color.Transparent;
            this.rezultatTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultatTXT.ForeColor = System.Drawing.Color.White;
            this.rezultatTXT.Location = new System.Drawing.Point(18, 781);
            this.rezultatTXT.Name = "rezultatTXT";
            this.rezultatTXT.Size = new System.Drawing.Size(320, 81);
            this.rezultatTXT.TabIndex = 6;
            this.rezultatTXT.Text = "Rezultat: ";
            // 
            // restartTipka
            // 
            this.restartTipka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(82)))));
            this.restartTipka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartTipka.ForeColor = System.Drawing.Color.White;
            this.restartTipka.Location = new System.Drawing.Point(93, 348);
            this.restartTipka.Name = "restartTipka";
            this.restartTipka.Size = new System.Drawing.Size(223, 135);
            this.restartTipka.TabIndex = 7;
            this.restartTipka.Text = "PONOVI IGRU";
            this.restartTipka.UseVisualStyleBackColor = false;
            this.restartTipka.Click += new System.EventHandler(this.resetGame);
            // 
            // Meteor4
            // 
            this.Meteor4.BackColor = System.Drawing.Color.Transparent;
            this.Meteor4.Image = global::OOP_Zavrsni.Properties.Resources.meteorit;
            this.Meteor4.Location = new System.Drawing.Point(823, 62);
            this.Meteor4.Name = "Meteor4";
            this.Meteor4.Size = new System.Drawing.Size(56, 56);
            this.Meteor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Meteor4.TabIndex = 8;
            this.Meteor4.TabStop = false;
            this.Meteor4.Tag = "cetvrtiMeteor";
            // 
            // TipkaNazad
            // 
            this.TipkaNazad.BackColor = System.Drawing.Color.Transparent;
            this.TipkaNazad.Image = global::OOP_Zavrsni.Properties.Resources.nazad_tipka;
            this.TipkaNazad.Location = new System.Drawing.Point(10, 12);
            this.TipkaNazad.Name = "TipkaNazad";
            this.TipkaNazad.Size = new System.Drawing.Size(87, 78);
            this.TipkaNazad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TipkaNazad.TabIndex = 9;
            this.TipkaNazad.TabStop = false;
            this.TipkaNazad.Click += new System.EventHandler(this.tipkaNazad);
            // 
            // gameOverBox
            // 
            this.gameOverBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(194)))));
            this.gameOverBox.Controls.Add(this.highScoreTXT);
            this.gameOverBox.Controls.Add(this.rezultat2TXT);
            this.gameOverBox.Controls.Add(this.label1);
            this.gameOverBox.Controls.Add(this.TipkaNazad);
            this.gameOverBox.Controls.Add(this.restartTipka);
            this.gameOverBox.Location = new System.Drawing.Point(277, 164);
            this.gameOverBox.Name = "gameOverBox";
            this.gameOverBox.Size = new System.Drawing.Size(426, 520);
            this.gameOverBox.TabIndex = 11;
            // 
            // highScoreTXT
            // 
            this.highScoreTXT.AutoSize = true;
            this.highScoreTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreTXT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.highScoreTXT.Location = new System.Drawing.Point(38, 254);
            this.highScoreTXT.Name = "highScoreTXT";
            this.highScoreTXT.Size = new System.Drawing.Size(255, 36);
            this.highScoreTXT.TabIndex = 12;
            this.highScoreTXT.Text = "Najbolji rezultat: ";
            // 
            // rezultat2TXT
            // 
            this.rezultat2TXT.AutoSize = true;
            this.rezultat2TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultat2TXT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rezultat2TXT.Location = new System.Drawing.Point(38, 193);
            this.rezultat2TXT.Name = "rezultat2TXT";
            this.rezultat2TXT.Size = new System.Drawing.Size(208, 36);
            this.rezultat2TXT.TabIndex = 11;
            this.rezultat2TXT.Text = "Tvoj rezultat: ";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(86, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Game Over!";
            // 
            // Igrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_Zavrsni.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.gameOverBox);
            this.Controls.Add(this.Meteor4);
            this.Controls.Add(this.rezultatTXT);
            this.Controls.Add(this.avion);
            this.Controls.Add(this.Meteor3);
            this.Controls.Add(this.Meteor2);
            this.Controls.Add(this.Meteor1);
            this.Name = "Igrica";
            this.Text = "Svemirski avion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.igricaZatvorena);
            this.Load += new System.EventHandler(this.Igrica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TipkaPritisnuta);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TipkaPustena);
            ((System.ComponentModel.ISupportInitialize)(this.Meteor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipkaNazad)).EndInit();
            this.gameOverBox.ResumeLayout(false);
            this.gameOverBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Meteor1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Meteor2;
        private System.Windows.Forms.PictureBox Meteor3;
        private System.Windows.Forms.Label rezultatTXT;
        private System.Windows.Forms.Button restartTipka;
        private System.Windows.Forms.PictureBox Meteor4;
        private System.Windows.Forms.PictureBox TipkaNazad;
        private System.Windows.Forms.Panel gameOverBox;
        private System.Windows.Forms.Label rezultat2TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label highScoreTXT;
        public System.Windows.Forms.PictureBox avion;
    }
}

