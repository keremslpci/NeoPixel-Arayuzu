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
            this.Fire = new System.Windows.Forms.Button();
            this.Colorr = new System.Windows.Forms.Button();
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
            this.btn_SequentialColor = new System.Windows.Forms.Button();
            this.btnPoliceLights = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Colorful = new System.Windows.Forms.Button();
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
            // Fire
            // 
            this.Fire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Fire.Location = new System.Drawing.Point(16, 107);
            this.Fire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(121, 57);
            this.Fire.TabIndex = 1;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = false;
            this.Fire.Click += new System.EventHandler(this.btnfire_Click);
            // 
            // Colorr
            // 
            this.Colorr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Colorr.Location = new System.Drawing.Point(16, 189);
            this.Colorr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Colorr.Name = "Colorr";
            this.Colorr.Size = new System.Drawing.Size(121, 57);
            this.Colorr.TabIndex = 2;
            this.Colorr.Text = "Choose Color";
            this.Colorr.UseVisualStyleBackColor = false;
            this.Colorr.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Sparkle
            // 
            this.Sparkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.RunningLights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.Cylon.BackColor = System.Drawing.Color.DarkTurquoise;
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
            this.Strobe.BackColor = System.Drawing.Color.Violet;
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
            this.FADEOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.MeteorRain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.Kapat.BackColor = System.Drawing.Color.SlateBlue;
            this.Kapat.Location = new System.Drawing.Point(648, 189);
            this.Kapat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(121, 57);
            this.Kapat.TabIndex = 11;
            this.Kapat.Text = "Stop";
            this.Kapat.UseVisualStyleBackColor = false;
            this.Kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(590, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "NeoPixel Controller v1.2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPorts.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(16, 342);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPorts.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConnect.Location = new System.Drawing.Point(144, 342);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 23);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefreshPorts.Location = new System.Drawing.Point(263, 343);
            this.btnRefreshPorts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(69, 23);
            this.btnRefreshPorts.TabIndex = 16;
            this.btnRefreshPorts.Text = "Refresh";
            this.btnRefreshPorts.UseVisualStyleBackColor = false;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // btn_SequentialColor
            // 
            this.btn_SequentialColor.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_SequentialColor.Location = new System.Drawing.Point(231, 272);
            this.btn_SequentialColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SequentialColor.Name = "btn_SequentialColor";
            this.btn_SequentialColor.Size = new System.Drawing.Size(121, 57);
            this.btn_SequentialColor.TabIndex = 19;
            this.btn_SequentialColor.Text = "Sequential Color";
            this.btn_SequentialColor.UseVisualStyleBackColor = false;
            this.btn_SequentialColor.Click += new System.EventHandler(this.btn_SequentialColor_Click);
            // 
            // btnPoliceLights
            // 
            this.btnPoliceLights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPoliceLights.Location = new System.Drawing.Point(16, 272);
            this.btnPoliceLights.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPoliceLights.Name = "btnPoliceLights";
            this.btnPoliceLights.Size = new System.Drawing.Size(121, 57);
            this.btnPoliceLights.TabIndex = 17;
            this.btnPoliceLights.Text = "Police Lights";
            this.btnPoliceLights.UseVisualStyleBackColor = false;
            this.btnPoliceLights.Click += new System.EventHandler(this.btnPoliceLights_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(14, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Default Baudrate: 115200";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Violet;
            this.label3.Location = new System.Drawing.Point(618, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Codded By KeremSlpci";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Colorful
            // 
            this.Colorful.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Colorful.Location = new System.Drawing.Point(440, 272);
            this.Colorful.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Colorful.Name = "Colorful";
            this.Colorful.Size = new System.Drawing.Size(121, 57);
            this.Colorful.TabIndex = 22;
            this.Colorful.Text = "Colorful";
            this.Colorful.UseVisualStyleBackColor = false;
            this.Colorful.Click += new System.EventHandler(this.btn_Colorful_Click);
            // 
            // NeoPixelController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(797, 377);
            this.Controls.Add(this.Colorful);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SequentialColor);
            this.Controls.Add(this.btnPoliceLights);
            this.Controls.Add(this.btnRefreshPorts);
            this.Controls.Add(this.btnConnect);
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
            this.Controls.Add(this.Colorr);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Rainbow);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NeoPixelController";
            this.Text = "NeoPixelController";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rainbow;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button Colorr;
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
        private System.Windows.Forms.Button btn_SequentialColor;
        private System.Windows.Forms.Button btnPoliceLights;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Colorful;
    }
}

