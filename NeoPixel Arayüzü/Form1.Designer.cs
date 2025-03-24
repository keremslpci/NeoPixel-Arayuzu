namespace NeoPixelController
{
    partial class NeoPixelController
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rainbow = new System.Windows.Forms.Button();
            this.Blink = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.Sparkle = new System.Windows.Forms.Button();
            this.RunningLights = new System.Windows.Forms.Button();
            this.RandomTwinkle = new System.Windows.Forms.Button();
            this.Cylon = new System.Windows.Forms.Button();
            this.Strobe = new System.Windows.Forms.Button();
            this.theaterChase = new System.Windows.Forms.Button();
            this.FADEOUT = new System.Windows.Forms.Button();
            this.MeteorRain = new System.Windows.Forms.Button();
            this.Kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rainbow
            // 
            this.Rainbow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Rainbow.Location = new System.Drawing.Point(16, 25);
            this.Rainbow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Rainbow.Name = "Rainbow";
            this.Rainbow.Size = new System.Drawing.Size(121, 57);
            this.Rainbow.TabIndex = 0;
            this.Rainbow.Text = "Rainbow";
            this.Rainbow.UseVisualStyleBackColor = false;
            this.Rainbow.Click += new System.EventHandler(this.btnRainbow_Click);
            // 
            // Blink
            // 
            this.Blink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Blink.Location = new System.Drawing.Point(16, 107);
            this.Blink.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Blink.Name = "Blink";
            this.Blink.Size = new System.Drawing.Size(121, 57);
            this.Blink.TabIndex = 1;
            this.Blink.Text = "Blink";
            this.Blink.UseVisualStyleBackColor = false;
            this.Blink.Click += new System.EventHandler(this.btnBlink_Click);
            // 
            // Color
            // 
            this.Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Color.Location = new System.Drawing.Point(16, 189);
            this.Color.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(121, 57);
            this.Color.TabIndex = 2;
            this.Color.Text = "Renk Seç";
            this.Color.UseVisualStyleBackColor = false;
            this.Color.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Sparkle
            // 
            this.Sparkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Sparkle.Location = new System.Drawing.Point(440, 189);
            this.Sparkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sparkle.Name = "Sparkle";
            this.Sparkle.Size = new System.Drawing.Size(121, 57);
            this.Sparkle.TabIndex = 3;
            this.Sparkle.Text = "Sparkle";
            this.Sparkle.UseVisualStyleBackColor = false;
            this.Sparkle.Click += new System.EventHandler(this.btnSparkle_Click);
            // 
            // RunningLights
            // 
            this.RunningLights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RunningLights.Location = new System.Drawing.Point(648, 25);
            this.RunningLights.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RunningLights.Name = "RunningLights";
            this.RunningLights.Size = new System.Drawing.Size(121, 57);
            this.RunningLights.TabIndex = 4;
            this.RunningLights.Text = "Running Lights";
            this.RunningLights.UseVisualStyleBackColor = false;
            this.RunningLights.Click += new System.EventHandler(this.btnRunningLights_Click);
            // 
            // RandomTwinkle
            // 
            this.RandomTwinkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RandomTwinkle.Location = new System.Drawing.Point(440, 107);
            this.RandomTwinkle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RandomTwinkle.Name = "RandomTwinkle";
            this.RandomTwinkle.Size = new System.Drawing.Size(121, 57);
            this.RandomTwinkle.TabIndex = 5;
            this.RandomTwinkle.Text = "Random Twinkle";
            this.RandomTwinkle.UseVisualStyleBackColor = false;
            this.RandomTwinkle.Click += new System.EventHandler(this.btnRandomTwinkle_Click);
            // 
            // Cylon
            // 
            this.Cylon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cylon.Location = new System.Drawing.Point(440, 25);
            this.Cylon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cylon.Name = "Cylon";
            this.Cylon.Size = new System.Drawing.Size(121, 57);
            this.Cylon.TabIndex = 6;
            this.Cylon.Text = "Cylon";
            this.Cylon.UseVisualStyleBackColor = false;
            this.Cylon.Click += new System.EventHandler(this.btnCylon_Click);
            // 
            // Strobe
            // 
            this.Strobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Strobe.Location = new System.Drawing.Point(231, 189);
            this.Strobe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Strobe.Name = "Strobe";
            this.Strobe.Size = new System.Drawing.Size(121, 57);
            this.Strobe.TabIndex = 7;
            this.Strobe.Text = "Strobe";
            this.Strobe.UseVisualStyleBackColor = false;
            this.Strobe.Click += new System.EventHandler(this.btnStrobe_Click);
            // 
            // theaterChase
            // 
            this.theaterChase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.theaterChase.Location = new System.Drawing.Point(231, 107);
            this.theaterChase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.theaterChase.Name = "theaterChase";
            this.theaterChase.Size = new System.Drawing.Size(121, 57);
            this.theaterChase.TabIndex = 8;
            this.theaterChase.Text = "Theater Chase";
            this.theaterChase.UseVisualStyleBackColor = false;
            this.theaterChase.Click += new System.EventHandler(this.btnTheaterChase_Click);
            // 
            // FADEOUT
            // 
            this.FADEOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FADEOUT.Location = new System.Drawing.Point(231, 25);
            this.FADEOUT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FADEOUT.Name = "FADEOUT";
            this.FADEOUT.Size = new System.Drawing.Size(121, 57);
            this.FADEOUT.TabIndex = 9;
            this.FADEOUT.Text = "Fade Out";
            this.FADEOUT.UseVisualStyleBackColor = false;
            this.FADEOUT.Click += new System.EventHandler(this.btnFadeOut_Click);
            // 
            // MeteorRain
            // 
            this.MeteorRain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MeteorRain.Location = new System.Drawing.Point(648, 107);
            this.MeteorRain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MeteorRain.Name = "MeteorRain";
            this.MeteorRain.Size = new System.Drawing.Size(121, 57);
            this.MeteorRain.TabIndex = 10;
            this.MeteorRain.Text = "Meteor Rain";
            this.MeteorRain.UseVisualStyleBackColor = false;
            this.MeteorRain.Click += new System.EventHandler(this.btnMeteorRain_Click);
            // 
            // Kapat
            // 
            this.Kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kapat.Location = new System.Drawing.Point(648, 189);
            this.Kapat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(121, 57);
            this.Kapat.TabIndex = 11;
            this.Kapat.Text = "Kapat";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(526, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kerem SALEPCİ ©";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 299);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPorts.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConnect.Location = new System.Drawing.Point(140, 299);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(68, 23);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefreshPorts.Location = new System.Drawing.Point(216, 298);
            this.btnRefreshPorts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(69, 23);
            this.btnRefreshPorts.TabIndex = 16;
            this.btnRefreshPorts.Text = "Refresh";
            this.btnRefreshPorts.UseVisualStyleBackColor = false;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(797, 335);
            this.Controls.Add(this.btnRefreshPorts);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kapat);
            this.Controls.Add(this.MeteorRain);
            this.Controls.Add(this.FADEOUT);
            this.Controls.Add(this.theaterChase);
            this.Controls.Add(this.Strobe);
            this.Controls.Add(this.Cylon);
            this.Controls.Add(this.RandomTwinkle);
            this.Controls.Add(this.RunningLights);
            this.Controls.Add(this.Sparkle);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Blink);
            this.Controls.Add(this.Rainbow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NeoPixelController";
            this.Text = "NeoPixelController";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.NeoPixelController_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rainbow;
        private System.Windows.Forms.Button Blink;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button Sparkle;
        private System.Windows.Forms.Button RunningLights;
        private System.Windows.Forms.Button RandomTwinkle;
        private System.Windows.Forms.Button Cylon;
        private System.Windows.Forms.Button Strobe;
        private System.Windows.Forms.Button theaterChase;
        private System.Windows.Forms.Button FADEOUT;
        private System.Windows.Forms.Button MeteorRain;
        private System.Windows.Forms.Button Kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefreshPorts;
    }
}

