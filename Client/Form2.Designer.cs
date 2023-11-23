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
            this.loaBtn = new Sunny.UI.UISymbolButton();
            this.micBtn = new Sunny.UI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 333);
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
            this.uiPanel1.Controls.Add(this.chatBtn);
            this.uiPanel1.Controls.Add(this.terminateBtn);
            this.uiPanel1.Controls.Add(this.loaBtn);
            this.uiPanel1.Controls.Add(this.micBtn);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 333);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(600, 33);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chatBtn
            // 
            this.chatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chatBtn.Location = new System.Drawing.Point(699, 1);
            this.chatBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.Size = new System.Drawing.Size(101, 40);
            this.chatBtn.Symbol = 57446;
            this.chatBtn.SymbolSize = 35;
            this.chatBtn.TabIndex = 5;
            this.chatBtn.Text = "Chat";
            this.chatBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chatBtn.Click += new System.EventHandler(this.chatBtn_Click);
            // 
            // terminateBtn
            // 
            this.terminateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terminateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.terminateBtn.Location = new System.Drawing.Point(376, 0);
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
            // loaBtn
            // 
            this.loaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loaBtn.Location = new System.Drawing.Point(315, 1);
            this.loaBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.loaBtn.Name = "loaBtn";
            this.loaBtn.Size = new System.Drawing.Size(32, 41);
            this.loaBtn.Symbol = 57449;
            this.loaBtn.TabIndex = 3;
            this.loaBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.loaBtn.Click += new System.EventHandler(this.loaBtn_Click);
            // 
            // micBtn
            // 
            this.micBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.micBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.micBtn.Location = new System.Drawing.Point(250, 1);
            this.micBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.micBtn.Name = "micBtn";
            this.micBtn.Size = new System.Drawing.Size(37, 40);
            this.micBtn.Symbol = 362409;
            this.micBtn.TabIndex = 2;
            this.micBtn.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.micBtn.Click += new System.EventHandler(this.micBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 333);
            this.panel1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private Sunny.UI.UISymbolButton loaBtn;
        private Sunny.UI.UISymbolButton micBtn;
    }
}