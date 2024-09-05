using System;

namespace WM_FileWatcherUI
{
    partial class editCreateForm2
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.changeSummaryTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.edit_createEditFileWatcherButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.addEventButton = new System.Windows.Forms.Button();
            this.removeEventButton = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.evnt_browseSourceDirectoryButton = new System.Windows.Forms.Button();
            this.evnt_eventActionsListBox = new System.Windows.Forms.ListBox();
            this.evnt_sourceDirectoryLabel = new System.Windows.Forms.Label();
            this.evnt_sourceDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.evnt_browseDestinationDirectoryButton = new System.Windows.Forms.Button();
            this.evnt_destinationDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.evnt_destinationDirectoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.edit_fileNameFilterListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_fileNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.ex_executionTimeTextBox = new System.Windows.Forms.TextBox();
            this.edit_fileNameFilterlabel = new System.Windows.Forms.Label();
            this.edit_fileNameFilterRemoveButton = new System.Windows.Forms.Button();
            this.edit_fileNameFilterAddButton = new System.Windows.Forms.Button();
            this.ex_executionTimeLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.edit_creatorTextBox = new System.Windows.Forms.TextBox();
            this.edit_creatorLabel = new System.Windows.Forms.Label();
            this.edit_fileWatcherNameLabel = new System.Windows.Forms.Label();
            this.edit_fileWatcherNameTextBox = new System.Windows.Forms.TextBox();
            this.formPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.tableLayoutPanel5);
            this.formPanel.Controls.Add(this.tableLayoutPanel4);
            this.formPanel.Controls.Add(this.tableLayoutPanel3);
            this.formPanel.Controls.Add(this.tableLayoutPanel2);
            this.formPanel.Controls.Add(this.tableLayoutPanel1);
            this.formPanel.Controls.Add(this.topPanel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1153, 910);
            this.formPanel.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.changeSummaryTextBox, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 675);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.6875F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.3125F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1153, 135);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Change Summary:";
            // 
            // changeSummaryTextBox
            // 
            this.changeSummaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.changeSummaryTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.changeSummaryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSummaryTextBox.Location = new System.Drawing.Point(4, 83);
            this.changeSummaryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeSummaryTextBox.Multiline = true;
            this.changeSummaryTextBox.Name = "changeSummaryTextBox";
            this.changeSummaryTextBox.Size = new System.Drawing.Size(428, 48);
            this.changeSummaryTextBox.TabIndex = 31;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.edit_createEditFileWatcherButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 860);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1153, 50);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // edit_createEditFileWatcherButton
            // 
            this.edit_createEditFileWatcherButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_createEditFileWatcherButton.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel4.SetColumnSpan(this.edit_createEditFileWatcherButton, 2);
            this.edit_createEditFileWatcherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_createEditFileWatcherButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_createEditFileWatcherButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.edit_createEditFileWatcherButton.Location = new System.Drawing.Point(447, 4);
            this.edit_createEditFileWatcherButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit_createEditFileWatcherButton.Name = "edit_createEditFileWatcherButton";
            this.edit_createEditFileWatcherButton.Size = new System.Drawing.Size(259, 42);
            this.edit_createEditFileWatcherButton.TabIndex = 21;
            this.edit_createEditFileWatcherButton.Text = "Edit File Watcher";
            this.edit_createEditFileWatcherButton.UseVisualStyleBackColor = false;
            this.edit_createEditFileWatcherButton.Click += new System.EventHandler(this.edit_createEditFileWatcherButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.75426F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.93064F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.4104F));
            this.tableLayoutPanel3.Controls.Add(this.addEventButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.removeEventButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdateEvent, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 617);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1153, 58);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // addEventButton
            // 
            this.addEventButton.BackColor = System.Drawing.Color.Gray;
            this.addEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventButton.Location = new System.Drawing.Point(4, 4);
            this.addEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(231, 42);
            this.addEventButton.TabIndex = 36;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = false;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.Color.Gray;
            this.btnUpdateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.Location = new System.Drawing.Point(491, 5);
            this.btnUpdateEvent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(233, 42);
            this.btnUpdateEvent.TabIndex = 38;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // removeEventButton
            // 
            this.removeEventButton.BackColor = System.Drawing.Color.Gray;
            this.removeEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEventButton.Location = new System.Drawing.Point(246, 5);
            this.removeEventButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.removeEventButton.Name = "removeEventButton";
            this.removeEventButton.Size = new System.Drawing.Size(233, 42);
            this.removeEventButton.TabIndex = 37;
            this.removeEventButton.Text = "Remove Event";
            this.removeEventButton.UseVisualStyleBackColor = false;
            this.removeEventButton.Click += new System.EventHandler(this.removeEventButton_Click);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.Color.Gray;
            this.btnUpdateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.Location = new System.Drawing.Point(541, 4);
            this.btnUpdateEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(175, 38);
            this.btnUpdateEvent.TabIndex = 38;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.04429F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.95571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 587F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.evnt_browseSourceDirectoryButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.evnt_eventActionsListBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.evnt_sourceDirectoryLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.evnt_sourceDirectoryTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.evnt_browseDestinationDirectoryButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.evnt_destinationDirectoryTextBox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.evnt_destinationDirectoryLabel, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 399);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.57971F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.42029F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1153, 218);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(570, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Events List:";
            // 
            // evnt_browseSourceDirectoryButton
            // 
            this.evnt_browseSourceDirectoryButton.BackColor = System.Drawing.Color.Gray;
            this.evnt_browseSourceDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evnt_browseSourceDirectoryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_browseSourceDirectoryButton.Location = new System.Drawing.Point(506, 37);
            this.evnt_browseSourceDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evnt_browseSourceDirectoryButton.Name = "evnt_browseSourceDirectoryButton";
            this.evnt_browseSourceDirectoryButton.Size = new System.Drawing.Size(51, 42);
            this.evnt_browseSourceDirectoryButton.TabIndex = 31;
            this.evnt_browseSourceDirectoryButton.Text = "...";
            this.evnt_browseSourceDirectoryButton.UseVisualStyleBackColor = false;
            this.evnt_browseSourceDirectoryButton.Click += new System.EventHandler(this.evnt_browseSourceDirectoryButton_Click);
            // 
            // evnt_eventActionsListBox
            // 
            this.evnt_eventActionsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evnt_eventActionsListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.evnt_eventActionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.evnt_eventActionsListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_eventActionsListBox.ItemHeight = 28;
            this.evnt_eventActionsListBox.Location = new System.Drawing.Point(569, 39);
            this.evnt_eventActionsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.evnt_eventActionsListBox.Name = "evnt_eventActionsListBox";
            this.tableLayoutPanel2.SetRowSpan(this.evnt_eventActionsListBox, 4);
            this.evnt_eventActionsListBox.Size = new System.Drawing.Size(580, 142);
            this.evnt_eventActionsListBox.TabIndex = 25;
            this.evnt_eventActionsListBox.SelectedIndexChanged += new System.EventHandler(this.evnt_eventActionsListBox_SelectedIndexChanged);
            // 
            // evnt_sourceDirectoryLabel
            // 
            this.evnt_sourceDirectoryLabel.AutoSize = true;
            this.evnt_sourceDirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_sourceDirectoryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.evnt_sourceDirectoryLabel.Location = new System.Drawing.Point(3, 0);
            this.evnt_sourceDirectoryLabel.Name = "evnt_sourceDirectoryLabel";
            this.evnt_sourceDirectoryLabel.Size = new System.Drawing.Size(162, 28);
            this.evnt_sourceDirectoryLabel.TabIndex = 26;
            this.evnt_sourceDirectoryLabel.Text = "Source Directory:";
            // 
            // evnt_sourceDirectoryTextBox
            // 
            this.evnt_sourceDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evnt_sourceDirectoryTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.evnt_sourceDirectoryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_sourceDirectoryTextBox.Location = new System.Drawing.Point(3, 37);
            this.evnt_sourceDirectoryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evnt_sourceDirectoryTextBox.Name = "evnt_sourceDirectoryTextBox";
            this.evnt_sourceDirectoryTextBox.Size = new System.Drawing.Size(497, 34);
            this.evnt_sourceDirectoryTextBox.TabIndex = 28;
            // 
            // evnt_browseDestinationDirectoryButton
            // 
            this.evnt_browseDestinationDirectoryButton.BackColor = System.Drawing.Color.Gray;
            this.evnt_browseDestinationDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evnt_browseDestinationDirectoryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_browseDestinationDirectoryButton.Location = new System.Drawing.Point(506, 155);
            this.evnt_browseDestinationDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evnt_browseDestinationDirectoryButton.Name = "evnt_browseDestinationDirectoryButton";
            this.evnt_browseDestinationDirectoryButton.Size = new System.Drawing.Size(51, 42);
            this.evnt_browseDestinationDirectoryButton.TabIndex = 32;
            this.evnt_browseDestinationDirectoryButton.Text = "...";
            this.evnt_browseDestinationDirectoryButton.UseVisualStyleBackColor = false;
            this.evnt_browseDestinationDirectoryButton.Click += new System.EventHandler(this.evnt_browseDestinationDirectoryButton_Click);
            // 
            // evnt_destinationDirectoryTextBox
            // 
            this.evnt_destinationDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evnt_destinationDirectoryTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.evnt_destinationDirectoryTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_destinationDirectoryTextBox.Location = new System.Drawing.Point(4, 157);
            this.evnt_destinationDirectoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.evnt_destinationDirectoryTextBox.Name = "evnt_destinationDirectoryTextBox";
            this.evnt_destinationDirectoryTextBox.Size = new System.Drawing.Size(495, 34);
            this.evnt_destinationDirectoryTextBox.TabIndex = 30;
            // 
            // evnt_destinationDirectoryLabel
            // 
            this.evnt_destinationDirectoryLabel.AutoSize = true;
            this.evnt_destinationDirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evnt_destinationDirectoryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.evnt_destinationDirectoryLabel.Location = new System.Drawing.Point(4, 119);
            this.evnt_destinationDirectoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.evnt_destinationDirectoryLabel.Name = "evnt_destinationDirectoryLabel";
            this.evnt_destinationDirectoryLabel.Size = new System.Drawing.Size(202, 28);
            this.evnt_destinationDirectoryLabel.TabIndex = 29;
            this.evnt_destinationDirectoryLabel.Text = "Destination Directory:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.76923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.tableLayoutPanel1.Controls.Add(this.edit_fileNameFilterListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.edit_fileNameFilterTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ex_executionTimeTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.edit_fileNameFilterlabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.edit_fileNameFilterRemoveButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.edit_fileNameFilterAddButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ex_executionTimeLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 123);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1153, 276);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // edit_fileNameFilterListBox
            // 
            this.edit_fileNameFilterListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_fileNameFilterListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.edit_fileNameFilterListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit_fileNameFilterListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_fileNameFilterListBox.FormattingEnabled = true;
            this.edit_fileNameFilterListBox.ItemHeight = 28;
            this.edit_fileNameFilterListBox.Location = new System.Drawing.Point(566, 45);
            this.edit_fileNameFilterListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.edit_fileNameFilterListBox.Name = "edit_fileNameFilterListBox";
            this.tableLayoutPanel1.SetRowSpan(this.edit_fileNameFilterListBox, 3);
            this.edit_fileNameFilterListBox.Size = new System.Drawing.Size(582, 196);
            this.edit_fileNameFilterListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(566, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filename Filter List:";
            // 
            // edit_fileNameFilterTextBox
            // 
            this.edit_fileNameFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_fileNameFilterTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.edit_fileNameFilterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edit_fileNameFilterTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_fileNameFilterTextBox.Location = new System.Drawing.Point(253, 45);
            this.edit_fileNameFilterTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.edit_fileNameFilterTextBox.Name = "edit_fileNameFilterTextBox";
            this.edit_fileNameFilterTextBox.Size = new System.Drawing.Size(303, 34);
            this.edit_fileNameFilterTextBox.TabIndex = 34;
            // 
            // ex_executionTimeTextBox
            // 
            this.ex_executionTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ex_executionTimeTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ex_executionTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ex_executionTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_executionTimeTextBox.Location = new System.Drawing.Point(4, 44);
            this.ex_executionTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ex_executionTimeTextBox.Name = "ex_executionTimeTextBox";
            this.ex_executionTimeTextBox.Size = new System.Drawing.Size(240, 34);       
            this.ex_executionTimeTextBox.TabIndex = 33;
            // 
            // edit_fileNameFilterlabel
            // 
            this.edit_fileNameFilterlabel.AutoSize = true;
            this.edit_fileNameFilterlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_fileNameFilterlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.edit_fileNameFilterlabel.Location = new System.Drawing.Point(253, 0);
            this.edit_fileNameFilterlabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.edit_fileNameFilterlabel.Name = "edit_fileNameFilterlabel";
            this.edit_fileNameFilterlabel.Size = new System.Drawing.Size(143, 28);
            this.edit_fileNameFilterlabel.TabIndex = 3;
            this.edit_fileNameFilterlabel.Text = "Filename Filter:";
            // 
            // edit_fileNameFilterRemoveButton
            // 
            this.edit_fileNameFilterRemoveButton.BackColor = System.Drawing.Color.Gray;
            this.edit_fileNameFilterRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_fileNameFilterRemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_fileNameFilterRemoveButton.Location = new System.Drawing.Point(253, 155);
            this.edit_fileNameFilterRemoveButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.edit_fileNameFilterRemoveButton.Name = "edit_fileNameFilterRemoveButton";
            this.edit_fileNameFilterRemoveButton.Size = new System.Drawing.Size(200, 46);
            this.edit_fileNameFilterRemoveButton.TabIndex = 8;
            this.edit_fileNameFilterRemoveButton.Text = "Remove Filter";
            this.edit_fileNameFilterRemoveButton.UseVisualStyleBackColor = false;
            this.edit_fileNameFilterRemoveButton.Click += new System.EventHandler(this.edit_fileNameFilterRemoveButton_Click);
            // 
            // edit_fileNameFilterAddButton
            // 
            this.edit_fileNameFilterAddButton.BackColor = System.Drawing.Color.Gray;
            this.edit_fileNameFilterAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_fileNameFilterAddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_fileNameFilterAddButton.Location = new System.Drawing.Point(253, 97);
            this.edit_fileNameFilterAddButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.edit_fileNameFilterAddButton.Name = "edit_fileNameFilterAddButton";
            this.edit_fileNameFilterAddButton.Size = new System.Drawing.Size(200, 46);
            this.edit_fileNameFilterAddButton.TabIndex = 7;
            this.edit_fileNameFilterAddButton.Text = "Add Filter";
            this.edit_fileNameFilterAddButton.UseVisualStyleBackColor = false;
            this.edit_fileNameFilterAddButton.Click += new System.EventHandler(this.edit_fileNameFilterAddButton_Click);
            // 
            // ex_executionTimeLabel
            // 
            this.ex_executionTimeLabel.AutoSize = true;
            this.ex_executionTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_executionTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ex_executionTimeLabel.Location = new System.Drawing.Point(3, 0);
            this.ex_executionTimeLabel.Name = "ex_executionTimeLabel";
            this.ex_executionTimeLabel.Size = new System.Drawing.Size(125, 28);
            this.ex_executionTimeLabel.TabIndex = 32;
            this.ex_executionTimeLabel.Text = "Event Period:";
            // 
            // topPanel
            // 
            this.topPanel.ColumnCount = 2;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topPanel.Controls.Add(this.edit_creatorTextBox, 1, 1);
            this.topPanel.Controls.Add(this.edit_creatorLabel, 1, 0);
            this.topPanel.Controls.Add(this.edit_fileWatcherNameLabel, 0, 0);
            this.topPanel.Controls.Add(this.edit_fileWatcherNameTextBox, 0, 1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 2;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.topPanel.Size = new System.Drawing.Size(1153, 123);
            this.topPanel.TabIndex = 0;
            // 
            // edit_creatorTextBox
            // 
            this.edit_creatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_creatorTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.edit_creatorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edit_creatorTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_creatorTextBox.Location = new System.Drawing.Point(580, 37);
            this.edit_creatorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit_creatorTextBox.Name = "edit_creatorTextBox";
            this.edit_creatorTextBox.Size = new System.Drawing.Size(569, 34);
            this.edit_creatorTextBox.TabIndex = 5;
            // 
            // edit_creatorLabel
            // 
            this.edit_creatorLabel.AutoSize = true;
            this.edit_creatorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_creatorLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.edit_creatorLabel.Location = new System.Drawing.Point(579, 0);
            this.edit_creatorLabel.Name = "edit_creatorLabel";
            this.edit_creatorLabel.Size = new System.Drawing.Size(105, 28);
            this.edit_creatorLabel.TabIndex = 5;
            this.edit_creatorLabel.Text = "Creator ID:";
            // 
            // edit_fileWatcherNameLabel
            // 
            this.edit_fileWatcherNameLabel.AutoSize = true;
            this.edit_fileWatcherNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_fileWatcherNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.edit_fileWatcherNameLabel.Location = new System.Drawing.Point(3, 0);
            this.edit_fileWatcherNameLabel.Name = "edit_fileWatcherNameLabel";
            this.edit_fileWatcherNameLabel.Size = new System.Drawing.Size(180, 28);
            this.edit_fileWatcherNameLabel.TabIndex = 1;
            this.edit_fileWatcherNameLabel.Text = "File Watcher Name:";
            // 
            // edit_fileWatcherNameTextBox
            // 
            this.edit_fileWatcherNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_fileWatcherNameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.edit_fileWatcherNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edit_fileWatcherNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_fileWatcherNameTextBox.Location = new System.Drawing.Point(4, 37);
            this.edit_fileWatcherNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edit_fileWatcherNameTextBox.Name = "edit_fileWatcherNameTextBox";
            this.edit_fileWatcherNameTextBox.Size = new System.Drawing.Size(568, 34);
            this.edit_fileWatcherNameTextBox.TabIndex = 4;
            // 
            // editCreateForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1153, 912);
            this.Controls.Add(this.formPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editCreateForm2";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Text = "editCreateForm2";
            this.Load += new System.EventHandler(this.editCreateForm2_Load);
            this.formPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void edit_fileNameFilterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.Label edit_fileWatcherNameLabel;
        private System.Windows.Forms.TextBox edit_fileWatcherNameTextBox;
        private System.Windows.Forms.Label edit_creatorLabel;
        private System.Windows.Forms.TextBox edit_creatorTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button edit_fileNameFilterAddButton;
        private System.Windows.Forms.Button edit_fileNameFilterRemoveButton;
        private System.Windows.Forms.Label ex_executionTimeLabel;
        private System.Windows.Forms.Label edit_fileNameFilterlabel;
        private System.Windows.Forms.TextBox ex_executionTimeTextBox;
        private System.Windows.Forms.TextBox edit_fileNameFilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox evnt_eventActionsListBox;
        private System.Windows.Forms.Label evnt_sourceDirectoryLabel;
        private System.Windows.Forms.TextBox evnt_sourceDirectoryTextBox;
        private System.Windows.Forms.Label evnt_destinationDirectoryLabel;
        private System.Windows.Forms.TextBox evnt_destinationDirectoryTextBox;
        private System.Windows.Forms.Button evnt_browseSourceDirectoryButton;
        private System.Windows.Forms.Button evnt_browseDestinationDirectoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button removeEventButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button edit_createEditFileWatcherButton;
        private System.Windows.Forms.ListBox edit_fileNameFilterListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changeSummaryTextBox;
        private System.Windows.Forms.Button btnUpdateEvent;
    }
}