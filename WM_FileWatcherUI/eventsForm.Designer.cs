namespace WM_FileWatcherUI
{
    partial class eventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eventsForm));
            this.evnt_eventsLabel = new System.Windows.Forms.Label();
            this.evnt_eventsDropdownComboBox = new System.Windows.Forms.ComboBox();
            this.evnt_forwardButton = new System.Windows.Forms.Button();
            this.evnt_backwardButton = new System.Windows.Forms.Button();
            this.evnt_eventActionsListBox = new System.Windows.Forms.ListBox();
            this.evnt_sourceDirectoryLabel = new System.Windows.Forms.Label();
            this.evnt_destinationDirectoryLabel = new System.Windows.Forms.Label();
            this.evnt_sourceDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.evnt_destinationDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.evnt_browseDestinationDirectoryButton = new System.Windows.Forms.Button();
            this.evnt_browseSourceDirectoryButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // evnt_eventsLabel
            // 
            this.evnt_eventsLabel.AutoSize = true;
            this.evnt_eventsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_eventsLabel.Location = new System.Drawing.Point(24, 21);
            this.evnt_eventsLabel.Name = "evnt_eventsLabel";
            this.evnt_eventsLabel.Size = new System.Drawing.Size(68, 28);
            this.evnt_eventsLabel.TabIndex = 0;
            this.evnt_eventsLabel.Text = "Events";
            // 
            // evnt_eventsDropdownComboBox
            // 
            this.evnt_eventsDropdownComboBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.evnt_eventsDropdownComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_eventsDropdownComboBox.FormattingEnabled = true;
            this.evnt_eventsDropdownComboBox.Location = new System.Drawing.Point(29, 62);
            this.evnt_eventsDropdownComboBox.Name = "evnt_eventsDropdownComboBox";
            this.evnt_eventsDropdownComboBox.Size = new System.Drawing.Size(299, 36);
            this.evnt_eventsDropdownComboBox.TabIndex = 1;
            this.evnt_eventsDropdownComboBox.SelectedIndexChanged += new System.EventHandler(this.evnt_eventsDropdownComboBox_SelectedIndexChanged);
            // 
            // evnt_forwardButton
            // 
            this.evnt_forwardButton.BackColor = System.Drawing.Color.Gray;
            this.evnt_forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evnt_forwardButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_forwardButton.Location = new System.Drawing.Point(363, 63);
            this.evnt_forwardButton.Name = "evnt_forwardButton";
            this.evnt_forwardButton.Size = new System.Drawing.Size(84, 42);
            this.evnt_forwardButton.TabIndex = 2;
            this.evnt_forwardButton.Text = ">>";
            this.evnt_forwardButton.UseVisualStyleBackColor = false;
            this.evnt_forwardButton.Click += new System.EventHandler(this.evnt_forwardButton_Click);
            // 
            // evnt_backwardButton
            // 
            this.evnt_backwardButton.BackColor = System.Drawing.Color.Gray;
            this.evnt_backwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evnt_backwardButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_backwardButton.Location = new System.Drawing.Point(363, 111);
            this.evnt_backwardButton.Name = "evnt_backwardButton";
            this.evnt_backwardButton.Size = new System.Drawing.Size(84, 42);
            this.evnt_backwardButton.TabIndex = 3;
            this.evnt_backwardButton.Text = "<<";
            this.evnt_backwardButton.UseVisualStyleBackColor = false;
            this.evnt_backwardButton.Click += new System.EventHandler(this.evnt_backwardButton_Click);
            // 
            // evnt_eventActionsListBox
            // 
            this.evnt_eventActionsListBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.evnt_eventActionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.evnt_eventActionsListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_eventActionsListBox.ItemHeight = 28;
            this.evnt_eventActionsListBox.Location = new System.Drawing.Point(489, 62);
            this.evnt_eventActionsListBox.Name = "evnt_eventActionsListBox";
            this.evnt_eventActionsListBox.Size = new System.Drawing.Size(424, 170);
            this.evnt_eventActionsListBox.TabIndex = 10;
            // 
            // evnt_sourceDirectoryLabel
            // 
            this.evnt_sourceDirectoryLabel.AutoSize = true;
            this.evnt_sourceDirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_sourceDirectoryLabel.Location = new System.Drawing.Point(24, 271);
            this.evnt_sourceDirectoryLabel.Name = "evnt_sourceDirectoryLabel";
            this.evnt_sourceDirectoryLabel.Size = new System.Drawing.Size(162, 28);
            this.evnt_sourceDirectoryLabel.TabIndex = 11;
            this.evnt_sourceDirectoryLabel.Text = "Source Directory:";
            // 
            // evnt_destinationDirectoryLabel
            // 
            this.evnt_destinationDirectoryLabel.AutoSize = true;
            this.evnt_destinationDirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_destinationDirectoryLabel.Location = new System.Drawing.Point(24, 339);
            this.evnt_destinationDirectoryLabel.Name = "evnt_destinationDirectoryLabel";
            this.evnt_destinationDirectoryLabel.Size = new System.Drawing.Size(202, 28);
            this.evnt_destinationDirectoryLabel.TabIndex = 12;
            this.evnt_destinationDirectoryLabel.Text = "Destination Directory:";
            // 
            // evnt_sourceDirectoryTextBox
            // 
            this.evnt_sourceDirectoryTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.evnt_sourceDirectoryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_sourceDirectoryTextBox.Location = new System.Drawing.Point(247, 271);
            this.evnt_sourceDirectoryTextBox.Name = "evnt_sourceDirectoryTextBox";
            this.evnt_sourceDirectoryTextBox.Size = new System.Drawing.Size(631, 34);
            this.evnt_sourceDirectoryTextBox.TabIndex = 13;
            // 
            // evnt_destinationDirectoryTextBox
            // 
            this.evnt_destinationDirectoryTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.evnt_destinationDirectoryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_destinationDirectoryTextBox.Location = new System.Drawing.Point(247, 336);
            this.evnt_destinationDirectoryTextBox.Name = "evnt_destinationDirectoryTextBox";
            this.evnt_destinationDirectoryTextBox.Size = new System.Drawing.Size(631, 34);
            this.evnt_destinationDirectoryTextBox.TabIndex = 14;
            // 
            // evnt_browseDestinationDirectoryButton
            // 
            this.evnt_browseDestinationDirectoryButton.BackColor = System.Drawing.Color.Gray;
            this.evnt_browseDestinationDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evnt_browseDestinationDirectoryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_browseDestinationDirectoryButton.Location = new System.Drawing.Point(884, 338);
            this.evnt_browseDestinationDirectoryButton.Name = "evnt_browseDestinationDirectoryButton";
            this.evnt_browseDestinationDirectoryButton.Size = new System.Drawing.Size(29, 29);
            this.evnt_browseDestinationDirectoryButton.TabIndex = 15;
            this.evnt_browseDestinationDirectoryButton.Text = "...";
            this.evnt_browseDestinationDirectoryButton.UseVisualStyleBackColor = false;
            this.evnt_browseDestinationDirectoryButton.Click += new System.EventHandler(this.evnt_browseDestinationDirectoryButton_Click);
            // 
            // evnt_browseSourceDirectoryButton
            // 
            this.evnt_browseSourceDirectoryButton.BackColor = System.Drawing.Color.Gray;
            this.evnt_browseSourceDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evnt_browseSourceDirectoryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_browseSourceDirectoryButton.Location = new System.Drawing.Point(884, 271);
            this.evnt_browseSourceDirectoryButton.Name = "evnt_browseSourceDirectoryButton";
            this.evnt_browseSourceDirectoryButton.Size = new System.Drawing.Size(29, 28);
            this.evnt_browseSourceDirectoryButton.TabIndex = 16;
            this.evnt_browseSourceDirectoryButton.Text = "...";
            this.evnt_browseSourceDirectoryButton.UseVisualStyleBackColor = false;
            this.evnt_browseSourceDirectoryButton.Click += new System.EventHandler(this.evnt_browseSourceDirectoryButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox1.Location = new System.Drawing.Point(29, 396);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(289, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Check to add date time to archived file";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.Location = new System.Drawing.Point(621, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // eventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(0, 142, 126);
            this.ClientSize = new System.Drawing.Size(942, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.evnt_browseSourceDirectoryButton);
            this.Controls.Add(this.evnt_browseDestinationDirectoryButton);
            this.Controls.Add(this.evnt_destinationDirectoryTextBox);
            this.Controls.Add(this.evnt_sourceDirectoryTextBox);
            this.Controls.Add(this.evnt_destinationDirectoryLabel);
            this.Controls.Add(this.evnt_sourceDirectoryLabel);
            this.Controls.Add(this.evnt_eventActionsListBox);
            this.Controls.Add(this.evnt_backwardButton);
            this.Controls.Add(this.evnt_forwardButton);
            this.Controls.Add(this.evnt_eventsDropdownComboBox);
            this.Controls.Add(this.evnt_eventsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "eventsForm";
            this.Text = "WellMed File Watcher Events";
            this.Load += new System.EventHandler(this.eventsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label evnt_eventsLabel;
        private System.Windows.Forms.ComboBox evnt_eventsDropdownComboBox;
        private System.Windows.Forms.Button evnt_forwardButton;
        private System.Windows.Forms.ListBox evnt_eventActionsListBox;
        private System.Windows.Forms.Label evnt_sourceDirectoryLabel;
        private System.Windows.Forms.Label evnt_destinationDirectoryLabel;
        private System.Windows.Forms.TextBox evnt_sourceDirectoryTextBox;
        private System.Windows.Forms.TextBox evnt_destinationDirectoryTextBox;
        private System.Windows.Forms.Button evnt_browseDestinationDirectoryButton;
        private System.Windows.Forms.Button evnt_browseSourceDirectoryButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button evnt_backwardButton;
        private System.Windows.Forms.Button button1;
    }
}