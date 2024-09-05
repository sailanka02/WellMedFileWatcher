using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FileWatcherLibrary.Models;
using FileWatcherLibrary;
using System.IO;

namespace WM_FileWatcherUI
{
    public partial class newDashboard : Form
    {
        public static newDashboard instance;
        public List<FileWatcherModel> fileWatchers;
        public DataGridView dashboardGrid;
        public int rInd;
        public newDashboard()
        {
            InitializeComponent();
            instance = this;
            dashboardGrid = dataGridView1;
            fileWatchers = MainMenuForm.instance.fileWatchers;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "FileWatcherName";
            dataGridView1.Columns[2].Name = "CreatorID";
            dataGridView1.Columns[3].Name = "ActiveFileWatcher";
            dataGridView1.Columns[4].Name = "FileWatcherFault";
            dataGridView1.Columns[5].Name = "LastEdited";
            dataGridView1.Columns[6].Name = "LastEditedBy";
            foreach (FileWatcherModel f in MainMenuForm.instance.fileWatchers)
            {
                dataGridView1.Rows.Add(f.ID, f.FileWatcherName, f.CreatorID, f.ActiveFileWatcher, f.FileWatcherFault, f.LastEdited, f.LastEditedBy);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (fileWatchers[rInd].ActiveFileWatcher)
            {
                fileWatchers[rInd].ActiveFileWatcher = false;
                GlobalConfig.Connection.UpdateActiveFileWatcher(fileWatchers[rInd].ID, false);
                dataGridView1.Rows[rInd].Cells[3].Value = false;
            }
            else
            {
                fileWatchers[rInd].ActiveFileWatcher = true;
                GlobalConfig.Connection.UpdateActiveFileWatcher(fileWatchers[rInd].ID, true);
                dataGridView1.Rows[rInd].Cells[3].Value = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rInd = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = fileWatchers[rInd].LastEditSummary;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            rInd = dataGridView1.CurrentCell.RowIndex;
            FileWatcherModel model = MainMenuForm.instance.fileWatchers[rInd];
            fileWatchers.RemoveAt(rInd);
            foreach (EventModel em in model.FileWatcherEvents)
            {
                GlobalConfig.Connection.DeleteFileWatcherEvent(model.ID, em.ID);
            }
            GlobalConfig.Connection.DeleteFileWatcher(model.ID);
            dataGridView1.Rows.Clear();
            foreach (FileWatcherModel f in fileWatchers)
            {
                dataGridView1.Rows.Add(f.ID, f.FileWatcherName, f.CreatorID, f.ActiveFileWatcher, f.FileWatcherFault, f.LastEdited, f.LastEditedBy);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            editCreateForm2 form1 = new editCreateForm2(fileWatchers[rInd]);

            form1.Show();
            editCreateForm2.instance.isNewFileWatcher = false;
        }

        private void button1_Click(object sender, EventArgs e1)
        {
           foreach(FileWatcherModel f in fileWatchers)
            {
                if(f.CreatorID == Environment.UserDomainName + "\\" + Environment.UserName)
                {
                    foreach (EventModel e in f.FileWatcherEvents)
                    {
                        int countMoved = 0;
                        int countRecords = 0;
                        string Source = e.SourceDirectory;
                        string Destination = e.DestinationDirectory;
                        string fileWatcherName = f.FileWatcherName;
                        int fileWatcherID = f.ID;

                        foreach (string name in e.FileNameFilter)
                        {
                            string[] files = Directory.GetFiles(e.SourceDirectory, name);

                            foreach (string file in files)
                            {
                                if (!String.IsNullOrEmpty(file))
                                {
                                    countRecords++;

                                    if (!File.Exists(Destination + Path.GetFileName(file)))
                                    {
                                        File.Move(file, Destination + Path.GetFileName(file));
                                        File.Delete(file);
                                        GlobalConfig.Connection.InsertLogRecord(fileWatcherID, fileWatcherName, Path.GetFileName(file), Source, Destination, "MOVED", DateTime.Now);
                                        countMoved++;
                                    }
                                    else
                                    {
                                        GlobalConfig.Connection.InsertLogRecord(fileWatcherID, fileWatcherName, Path.GetFileName(file), Source, Destination, "NOT MOVED - FILE EXISTS IN TARGET LOCATION", DateTime.Now);
                                    }
                                }
                            }
                        }

                    }
                }
            }
        }
    }
}
