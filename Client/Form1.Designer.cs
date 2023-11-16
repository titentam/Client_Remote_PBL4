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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.ConnectBtn = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // iptext
            // 
            this.iptext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.iptext.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.iptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iptext.Location = new System.Drawing.Point(311, 123);
            this.iptext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iptext.MinimumSize = new System.Drawing.Size(1, 1);
            this.iptext.Name = "iptext";
            this.iptext.Padding = new System.Windows.Forms.Padding(1);
            this.iptext.ShowText = false;
            this.iptext.Size = new System.Drawing.Size(299, 38);
            this.iptext.Style = Sunny.UI.UIStyle.Custom;
            this.iptext.TabIndex = 1;
            this.iptext.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passtext
            // 
            this.passtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passtext.Location = new System.Drawing.Point(311, 207);
            this.passtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passtext.MinimumSize = new System.Drawing.Size(1, 16);
            this.passtext.Name = "passtext";
            this.passtext.Padding = new System.Windows.Forms.Padding(5);
            this.passtext.PasswordChar = '*';
            this.passtext.ShowText = false;
            this.passtext.Size = new System.Drawing.Size(299, 35);
            this.passtext.TabIndex = 2;
            this.passtext.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passtext.Watermark = "";
            this.passtext.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // captchaText
            // 
            this.captchaText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.captchaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.captchaText.Location = new System.Drawing.Point(311, 298);
            this.captchaText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.captchaText.MinimumSize = new System.Drawing.Size(1, 16);
            this.captchaText.Name = "captchaText";
            this.captchaText.Padding = new System.Windows.Forms.Padding(5);
            this.captchaText.ShowText = false;
            this.captchaText.Size = new System.Drawing.Size(159, 42);
            this.captchaText.TabIndex = 3;
            this.captchaText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.captchaText.Watermark = "";
            // 
            // uiVerificationCode1
            // 
            this.uiVerificationCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiVerificationCode1.Location = new System.Drawing.Point(477, 298);
            this.uiVerificationCode1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiVerificationCode1.Name = "uiVerificationCode1";
            this.uiVerificationCode1.Size = new System.Drawing.Size(133, 42);
            this.uiVerificationCode1.TabIndex = 4;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(122, 119);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(120, 42);
            this.uiSymbolLabel1.Symbol = 262137;
            this.uiSymbolLabel1.SymbolSize = 30;
            this.uiSymbolLabel1.TabIndex = 5;
            this.uiSymbolLabel1.Text = "IP Đối Tác";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(122, 207);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Size = new System.Drawing.Size(120, 42);
            this.uiSymbolLabel2.Symbol = 61758;
            this.uiSymbolLabel2.SymbolSize = 30;
            this.uiSymbolLabel2.TabIndex = 6;
            this.uiSymbolLabel2.Text = "Mật Khẩu";
            this.uiSymbolLabel2.Click += new System.EventHandler(this.uiSymbolLabel2_Click);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(122, 298);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Size = new System.Drawing.Size(120, 42);
            this.uiSymbolLabel3.Symbol = 561302;
            this.uiSymbolLabel3.SymbolSize = 30;
            this.uiSymbolLabel3.TabIndex = 7;
            this.uiSymbolLabel3.Text = "Captcha";
            this.uiSymbolLabel3.Click += new System.EventHandler(this.uiSymbolLabel3_Click);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiAvatar1.Location = new System.Drawing.Point(-29, -8);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(124, 78);
            this.uiAvatar1.TabIndex = 9;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uiLabel1.Location = new System.Drawing.Point(121, 18);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(489, 74);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "Remote Desktop Controller App";
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
            this.uiComboBox1.Location = new System.Drawing.Point(596, 457);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(130, 32);
            this.uiComboBox1.TabIndex = 11;
            this.uiComboBox1.Text = "Language";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiComboBox1.Watermark = "";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConnectBtn.Location = new System.Drawing.Point(225, 390);
            this.ConnectBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(275, 46);
            this.ConnectBtn.Style = Sunny.UI.UIStyle.Custom;
            this.ConnectBtn.Symbol = 561987;
            this.ConnectBtn.SymbolPressColor = System.Drawing.Color.Wheat;
            this.ConnectBtn.SymbolSize = 40;
            this.ConnectBtn.TabIndex = 8;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ConnectBtn.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 503);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiAvatar1);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiVerificationCode1);
            this.Controls.Add(this.captchaText);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.iptext);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIIPTextBox iptext;
        private Sunny.UI.UITextBox passtext;
        private Sunny.UI.UITextBox captchaText;
        private Sunny.UI.UIVerificationCode uiVerificationCode1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISymbolButton ConnectBtn;
    }
}

