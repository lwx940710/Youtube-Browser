namespace YoutubeBrowser
{
    partial class Browser
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.picBoxPlayIcon = new System.Windows.Forms.PictureBox();
            this.picBoxYoutube = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxSearchBtn = new System.Windows.Forms.PictureBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYoutube)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.picBoxPlayIcon);
            this.panel1.Controls.Add(this.picBoxYoutube);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 920);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(78, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 47);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(96, 820);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(78, 237);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 47);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(78, 327);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(122, 47);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // picBoxPlayIcon
            // 
            this.picBoxPlayIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPlayIcon.Image")));
            this.picBoxPlayIcon.Location = new System.Drawing.Point(38, 37);
            this.picBoxPlayIcon.Name = "picBoxPlayIcon";
            this.picBoxPlayIcon.Size = new System.Drawing.Size(80, 69);
            this.picBoxPlayIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPlayIcon.TabIndex = 1;
            this.picBoxPlayIcon.TabStop = false;
            // 
            // picBoxYoutube
            // 
            this.picBoxYoutube.Image = ((System.Drawing.Image)(resources.GetObject("picBoxYoutube.Image")));
            this.picBoxYoutube.Location = new System.Drawing.Point(124, 37);
            this.picBoxYoutube.Name = "picBoxYoutube";
            this.picBoxYoutube.Size = new System.Drawing.Size(127, 69);
            this.picBoxYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxYoutube.TabIndex = 0;
            this.picBoxYoutube.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.picBoxSearchBtn);
            this.panel2.Controls.Add(this.txtBoxSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(284, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1450, 134);
            this.panel2.TabIndex = 1;
            // 
            // picBoxSearchBtn
            // 
            this.picBoxSearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSearchBtn.Image")));
            this.picBoxSearchBtn.Location = new System.Drawing.Point(1090, 37);
            this.picBoxSearchBtn.Name = "picBoxSearchBtn";
            this.picBoxSearchBtn.Size = new System.Drawing.Size(100, 57);
            this.picBoxSearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSearchBtn.TabIndex = 1;
            this.picBoxSearchBtn.TabStop = false;
            this.picBoxSearchBtn.Click += new System.EventHandler(this.picBoxSearchBtn_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.AcceptsReturn = true;
            this.txtBoxSearch.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBoxSearch.Location = new System.Drawing.Point(85, 37);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(970, 60);
            this.txtBoxSearch.TabIndex = 0;
            this.txtBoxSearch.Text = " Search";
            this.txtBoxSearch.Click += new System.EventHandler(this.txtBoxSearch_Click);
            this.txtBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearch_KeyDown);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Location = new System.Drawing.Point(314, 153);
            this.panelContent.MinimumSize = new System.Drawing.Size(1408, 723);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1408, 723);
            this.panelContent.TabIndex = 2;
            // 
            // videoBindingSource
            // 
            this.videoBindingSource.DataSource = typeof(YoutubeBrowser.Video);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1734, 920);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1752, 967);
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Browser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYoutube)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxPlayIcon;
        private System.Windows.Forms.PictureBox picBoxYoutube;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.PictureBox picBoxSearchBtn;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.BindingSource videoBindingSource;
        private System.Windows.Forms.FlowLayoutPanel panelContent;
        private System.Windows.Forms.Button btnClear;
    }
}

