namespace Interface1
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.headPanel = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelOfOption1 = new System.Windows.Forms.Label();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Label();
            this.option1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.minimize);
            this.headPanel.Controls.Add(this.close);
            this.headPanel.Controls.Add(this.pictureBox4);
            this.headPanel.Controls.Add(this.labelOfOption1);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(190, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(660, 89);
            this.headPanel.TabIndex = 1;
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(603, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 7;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(630, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 6;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // labelOfOption1
            // 
            this.labelOfOption1.AutoSize = true;
            this.labelOfOption1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfOption1.Location = new System.Drawing.Point(69, 21);
            this.labelOfOption1.Name = "labelOfOption1";
            this.labelOfOption1.Size = new System.Drawing.Size(245, 43);
            this.labelOfOption1.TabIndex = 4;
            this.labelOfOption1.Text = " Diagnose Problem";
            this.labelOfOption1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconPanel
            // 
            this.iconPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.iconPanel.Controls.Add(this.pictureBox1);
            this.iconPanel.Controls.Add(this.logo);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(190, 89);
            this.iconPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 37);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(28, 31);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(159, 30);
            this.logo.TabIndex = 0;
            this.logo.Text = "Computer Sick";
            // 
            // option1
            // 
            this.option1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.option1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.option1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.option1.BorderRadius = 0;
            this.option1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.option1.ButtonText = "Load Facts and Rules";
            this.option1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option1.DisabledColor = System.Drawing.Color.Gray;
            this.option1.Dock = System.Windows.Forms.DockStyle.Top;
            this.option1.Iconcolor = System.Drawing.Color.Transparent;
            this.option1.Iconimage = null;
            this.option1.Iconimage_right = null;
            this.option1.Iconimage_right_Selected = null;
            this.option1.Iconimage_Selected = null;
            this.option1.IconMarginLeft = 0;
            this.option1.IconMarginRight = 0;
            this.option1.IconRightVisible = true;
            this.option1.IconRightZoom = 0D;
            this.option1.IconVisible = true;
            this.option1.IconZoom = 90D;
            this.option1.IsTab = false;
            this.option1.Location = new System.Drawing.Point(0, 89);
            this.option1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.option1.Name = "option1";
            this.option1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.option1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.option1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.option1.selected = false;
            this.option1.Size = new System.Drawing.Size(190, 44);
            this.option1.TabIndex = 2;
            this.option1.Text = "Load Facts and Rules";
            this.option1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.option1.Textcolor = System.Drawing.Color.White;
            this.option1.TextFont = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // optionPanel
            // 
            this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.optionPanel.Controls.Add(this.option1);
            this.optionPanel.Controls.Add(this.iconPanel);
            this.optionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionPanel.Location = new System.Drawing.Point(0, 0);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(190, 584);
            this.optionPanel.TabIndex = 0;
            this.optionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.startButton.Enabled = false;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.startButton.Location = new System.Drawing.Point(392, 283);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(245, 51);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "DIAGNOSTIC";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(850, 584);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.optionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.home_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.iconPanel.ResumeLayout(false);
            this.iconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.optionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Label labelOfOption1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logo;
        private Bunifu.Framework.UI.BunifuFlatButton option1;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Button startButton;
    }
}

