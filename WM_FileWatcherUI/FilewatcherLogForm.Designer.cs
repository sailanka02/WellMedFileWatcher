
namespace WM_FileWatcherUI
{
    partial class FilewatcherLogForm
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
            this.components = new System.ComponentModel.Container();
            this.iS_FileWatcherDataSet = new WM_FileWatcherUI.IS_FileWatcherDataSet();
            this.fileWatcherLoggingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileWatcherLoggingTableAdapter = new WM_FileWatcherUI.IS_FileWatcherDataSetTableAdapters.FileWatcherLoggingTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileWatcherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileWatcherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDirectoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDirectoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iS_FileWatcherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcherLoggingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iS_FileWatcherDataSet
            // 
            this.iS_FileWatcherDataSet.DataSetName = "IS_FileWatcherDataSet";
            this.iS_FileWatcherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileWatcherLoggingBindingSource
            // 
            this.fileWatcherLoggingBindingSource.DataMember = "FileWatcherLogging";
            this.fileWatcherLoggingBindingSource.DataSource = this.iS_FileWatcherDataSet;
            // 
            // fileWatcherLoggingTableAdapter
            // 
            this.fileWatcherLoggingTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fileWatcherIDDataGridViewTextBoxColumn,
            this.fileWatcherNameDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn,
            this.sourceDirectoryDataGridViewTextBoxColumn,
            this.destinationDirectoryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.statusDateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fileWatcherLoggingBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 484);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // fileWatcherIDDataGridViewTextBoxColumn
            // 
            this.fileWatcherIDDataGridViewTextBoxColumn.DataPropertyName = "FileWatcherID";
            this.fileWatcherIDDataGridViewTextBoxColumn.HeaderText = "FileWatcherID";
            this.fileWatcherIDDataGridViewTextBoxColumn.Name = "fileWatcherIDDataGridViewTextBoxColumn";
            this.fileWatcherIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileWatcherNameDataGridViewTextBoxColumn
            // 
            this.fileWatcherNameDataGridViewTextBoxColumn.DataPropertyName = "FileWatcherName";
            this.fileWatcherNameDataGridViewTextBoxColumn.HeaderText = "FileWatcherName";
            this.fileWatcherNameDataGridViewTextBoxColumn.Name = "fileWatcherNameDataGridViewTextBoxColumn";
            this.fileWatcherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "Filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            this.filenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDirectoryDataGridViewTextBoxColumn
            // 
            this.sourceDirectoryDataGridViewTextBoxColumn.DataPropertyName = "SourceDirectory";
            this.sourceDirectoryDataGridViewTextBoxColumn.HeaderText = "SourceDirectory";
            this.sourceDirectoryDataGridViewTextBoxColumn.Name = "sourceDirectoryDataGridViewTextBoxColumn";
            this.sourceDirectoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceDirectoryDataGridViewTextBoxColumn.Width = 250;
            // 
            // destinationDirectoryDataGridViewTextBoxColumn
            // 
            this.destinationDirectoryDataGridViewTextBoxColumn.DataPropertyName = "DestinationDirectory";
            this.destinationDirectoryDataGridViewTextBoxColumn.HeaderText = "DestinationDirectory";
            this.destinationDirectoryDataGridViewTextBoxColumn.Name = "destinationDirectoryDataGridViewTextBoxColumn";
            this.destinationDirectoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationDirectoryDataGridViewTextBoxColumn.Width = 250;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDateTimeDataGridViewTextBoxColumn
            // 
            this.statusDateTimeDataGridViewTextBoxColumn.DataPropertyName = "StatusDateTime";
            this.statusDateTimeDataGridViewTextBoxColumn.HeaderText = "StatusDateTime";
            this.statusDateTimeDataGridViewTextBoxColumn.Name = "statusDateTimeDataGridViewTextBoxColumn";
            this.statusDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1207, 504);
            this.panel2.TabIndex = 1;
            // 
            // FilewatcherLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 504);
            this.Controls.Add(this.panel2);
            this.Name = "FilewatcherLogForm";
            this.Text = "LogForm";
            ((System.ComponentModel.ISupportInitialize)(this.iS_FileWatcherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcherLoggingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private IS_FileWatcherDataSet iS_FileWatcherDataSet;
        private System.Windows.Forms.BindingSource fileWatcherLoggingBindingSource;
        private IS_FileWatcherDataSetTableAdapters.FileWatcherLoggingTableAdapter fileWatcherLoggingTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileWatcherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileWatcherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDirectoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDirectoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDateTimeDataGridViewTextBoxColumn;
    }
}