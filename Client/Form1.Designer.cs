namespace Client
{
    partial class Form1
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
            this.iptext = new Sunny.UI.UIIPTextBox();
            this.passtext = new Sunny.UI.UITextBox();
            this.captchaText = new Sunny.UI.UITextBox();
            this.uiVerificationCode1 = new Sunny.UI.UIVerificationCode();
            this.ipLabel = new Sunny.UI.UISymbolLabel();
            this.passLabel = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.ConnectBtn = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iptext
            // 
            this.iptext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.iptext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.iptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iptext.Location = new System.Drawing.Point(233, 100);
            this.iptext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iptext.MinimumSize = new System.Drawing.Size(1, 1);
            this.iptext.Name = "iptext";
            this.iptext.Padding = new System.Windows.Forms.Padding(1);
            this.iptext.ShowText = false;
            this.iptext.Size = new System.Drawing.Size(224, 31);
            this.iptext.Style = Sunny.UI.UIStyle.Custom;
            this.iptext.TabIndex = 1;
            this.iptext.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passtext
            // 
            this.passtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passtext.Location = new System.Drawing.Point(233, 168);
            this.passtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passtext.MinimumSize = new System.Drawing.Size(1, 13);
            this.passtext.Name = "passtext";
            this.passtext.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passtext.PasswordChar = '*';
            this.passtext.ShowText = false;
            this.passtext.Size = new System.Drawing.Size(224, 28);
            this.passtext.TabIndex = 2;
            this.passtext.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passtext.Watermark = "";
            this.passtext.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // captchaText
            // 
            this.captchaText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.captchaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.captchaText.Location = new System.Drawing.Point(233, 242);
            this.captchaText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.captchaText.MinimumSize = new System.Drawing.Size(1, 13);
            this.captchaText.Name = "captchaText";
            this.captchaText.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.captchaText.ShowText = false;
            this.captchaText.Size = new System.Drawing.Size(119, 34);
            this.captchaText.TabIndex = 3;
            this.captchaText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.captchaText.Watermark = "";
            // 
            // uiVerificationCode1
            // 
            this.uiVerificationCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiVerificationCode1.Location = new System.Drawing.Point(358, 242);
            this.uiVerificationCode1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiVerificationCode1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiVerificationCode1.Name = "uiVerificationCode1";
            this.uiVerificationCode1.Size = new System.Drawing.Size(100, 34);
            this.uiVerificationCode1.TabIndex = 4;
            // 
            // ipLabel
            // 
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ipLabel.Location = new System.Drawing.Point(64, 97);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ipLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(117, 34);
            this.ipLabel.Symbol = 262137;
            this.ipLabel.SymbolSize = 30;
            this.ipLabel.TabIndex = 5;
            this.ipLabel.Text = "IP Đối Tác";
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passLabel.Location = new System.Drawing.Point(64, 168);
            this.passLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(117, 34);
            this.passLabel.Symbol = 61758;
            this.passLabel.SymbolSize = 30;
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Mật Khẩu";
            this.passLabel.Click += new System.EventHandler(this.uiSymbolLabel2_Click);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(64, 242);
            this.uiSymbolLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Size = new System.Drawing.Size(117, 34);
            this.uiSymbolLabel3.Symbol = 561302;
            this.uiSymbolLabel3.SymbolSize = 30;
            this.uiSymbolLabel3.TabIndex = 7;
            this.uiSymbolLabel3.Text = "Captcha";
            this.uiSymbolLabel3.Click += new System.EventHandler(this.uiSymbolLabel3_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uiLabel1.Location = new System.Drawing.Point(120, 9);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(354, 60);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "Ứng Dụng Điều Khiển Máy Tính Từ Xa";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.DropDownAutoWidth = true;
            this.uiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiComboBox1.Items.AddRange(new object[] {
            "Tiếng Việt",
            "English"});
            this.uiComboBox1.Location = new System.Drawing.Point(447, 371);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(47, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(98, 27);
            this.uiComboBox1.TabIndex = 11;
            this.uiComboBox1.Text = "Language";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiComboBox1.Watermark = "";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConnectBtn.Location = new System.Drawing.Point(169, 317);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConnectBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(206, 37);
            this.ConnectBtn.Style = Sunny.UI.UIStyle.Custom;
            this.ConnectBtn.Symbol = 561987;
            this.ConnectBtn.SymbolPressColor = System.Drawing.Color.Wheat;
            this.ConnectBtn.SymbolSize = 40;
            this.ConnectBtn.TabIndex = 8;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ConnectBtn.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.uiVerificationCode1);
            this.Controls.Add(this.captchaText);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.iptext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIIPTextBox iptext;
        private Sunny.UI.UITextBox passtext;
        private Sunny.UI.UITextBox captchaText;
        private Sunny.UI.UIVerificationCode uiVerificationCode1;
        private Sunny.UI.UISymbolLabel ipLabel;
        private Sunny.UI.UISymbolLabel passLabel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISymbolButton ConnectBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

