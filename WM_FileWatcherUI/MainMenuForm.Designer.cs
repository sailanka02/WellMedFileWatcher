
namespace WM_FileWatcherUI
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLog = new FontAwesome.Sharp.IconButton();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogoBtnSpacing = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitltBar = new System.Windows.Forms.Panel();
            this.lblTitleOfChild = new System.Windows.Forms.Label();
            this.iconShowChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogoBtnSpacing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitltBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconShowChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.btnLog);
            this.panelMenu.Controls.Add(this.btnCreate);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogoBtnSpacing);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 589);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLog.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnLog.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLog.IconSize = 32;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(0, 262);
            this.btnLog.Margin = new System.Windows.Forms.Padding(0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLog.Size = new System.Drawing.Size(200, 60);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "  Filewatcher Log";
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCreate.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreate.IconSize = 32;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 202);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCreate.Size = new System.Drawing.Size(200, 60);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "  Create Filewatcher";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 142);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogoBtnSpacing
            // 
            this.panelLogoBtnSpacing.Controls.Add(this.btnHome);
            this.panelLogoBtnSpacing.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoBtnSpacing.Location = new System.Drawing.Point(0, 0);
            this.panelLogoBtnSpacing.Name = "panelLogoBtnSpacing";
            this.panelLogoBtnSpacing.Size = new System.Drawing.Size(200, 142);
            this.panelLogoBtnSpacing.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::WM_FileWatcherUI.Properties.Resources.wellmed_logo;
            this.btnHome.Location = new System.Drawing.Point(31, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(135, 123);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 2;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitltBar
            // 
            this.panelTitltBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelTitltBar.Controls.Add(this.lblTitleOfChild);
            this.panelTitltBar.Controls.Add(this.iconShowChildForm);
            this.panelTitltBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitltBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTitltBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitltBar.Name = "panelTitltBar";
            this.panelTitltBar.Size = new System.Drawing.Size(764, 75);
            this.panelTitltBar.TabIndex = 1;
            // 
            // lblTitleOfChild
            // 
            this.lblTitleOfChild.AutoSize = true;
            this.lblTitleOfChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOfChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleOfChild.Location = new System.Drawing.Point(43, 25);
            this.lblTitleOfChild.Name = "lblTitleOfChild";
            this.lblTitleOfChild.Size = new System.Drawing.Size(80, 25);
            this.lblTitleOfChild.TabIndex = 1;
            this.lblTitleOfChild.Text = "  Home";
            // 
            // iconShowChildForm
            // 
            this.iconShowChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.iconShowChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconShowChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconShowChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconShowChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconShowChildForm.Location = new System.Drawing.Point(8, 21);
            this.iconShowChildForm.Name = "iconShowChildForm";
            this.iconShowChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconShowChildForm.TabIndex = 0;
            this.iconShowChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(764, 514);
            this.panelDesktop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(80, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "INTEGRATION SERVICES, where stuff gets done!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WM_FileWatcherUI.Properties.Resources.IS_logo;
            this.pictureBox1.InitialImage = global::WM_FileWatcherUI.Properties.Resources.IS_logo;
            this.pictureBox1.Location = new System.Drawing.Point(276, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 589);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitltBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(604, 495);
            this.Name = "MainMenuForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogoBtnSpacing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitltBar.ResumeLayout(false);
            this.panelTitltBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconShowChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogoBtnSpacing;
        private FontAwesome.Sharp.IconButton btnCreate;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitltBar;
        private System.Windows.Forms.Label lblTitleOfChild;
        private FontAwesome.Sharp.IconPictureBox iconShowChildForm;
        private FontAwesome.Sharp.IconButton btnLog;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}