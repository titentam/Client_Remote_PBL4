namespace Client
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.chatBtn = new Sunny.UI.UISymbolButton();
            this.terminateBtn = new Sunny.UI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiSwitch1 = new Sunny.UI.UISwitch();
            this.uiSwitch2 = new Sunny.UI.UISwitch();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiSwitch2);
            this.uiPanel1.Controls.Add(this.uiSwitch1);
            this.uiPanel1.Controls.Add(this.chatBtn);
            this.uiPanel1.Controls.Add(this.terminateBtn);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 466);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(835, 46);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chatBtn
            // 
            this.chatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chatBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.chatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chatBtn.Location = new System.Drawing.Point(734, 0);
            this.chatBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.Size = new System.Drawing.Size(101, 46);
            this.chatBtn.Symbol = 57446;
            this.chatBtn.SymbolSize = 35;
            this.chatBtn.TabIndex = 5;
            this.chatBtn.Text = "Chat";
            this.chatBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chatBtn.Click += new System.EventHandler(this.chatBtn_Click);
            // 
            // terminateBtn
            // 
            this.terminateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terminateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terminateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.terminateBtn.Location = new System.Drawing.Point(354, 1);
            this.terminateBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.terminateBtn.Name = "terminateBtn";
            this.terminateBtn.Size = new System.Drawing.Size(128, 41);
            this.terminateBtn.Symbol = 61457;
            this.terminateBtn.SymbolSize = 30;
            this.terminateBtn.TabIndex = 4;
            this.terminateBtn.Text = "Terminate";
            this.terminateBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.terminateBtn.Click += new System.EventHandler(this.terminateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 466);
            this.panel1.TabIndex = 2;
            // 
            // uiSwitch1
            // 
            this.uiSwitch1.ActiveText = "Mic";
            this.uiSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSwitch1.InActiveText = "Mic";
            this.uiSwitch1.Location = new System.Drawing.Point(235, 5);
            this.uiSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch1.Name = "uiSwitch1";
            this.uiSwitch1.Size = new System.Drawing.Size(84, 36);
            this.uiSwitch1.TabIndex = 6;
            this.uiSwitch1.Text = "Mic";
            this.uiSwitch1.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitch1_ValueChanged);
            // 
            // uiSwitch2
            // 
            this.uiSwitch2.ActiveText = "Voice";
            this.uiSwitch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSwitch2.InActiveText = "Voice";
            this.uiSwitch2.Location = new System.Drawing.Point(510, 5);
            this.uiSwitch2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch2.Name = "uiSwitch2";
            this.uiSwitch2.Size = new System.Drawing.Size(84, 36);
            this.uiSwitch2.TabIndex = 7;
            this.uiSwitch2.Text = "Voice";
            this.uiSwitch2.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitch2_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton chatBtn;
        private Sunny.UI.UISymbolButton terminateBtn;
        private Sunny.UI.UISwitch uiSwitch2;
        private Sunny.UI.UISwitch uiSwitch1;
    }
}