using FileWatcherLibrary;
using FileWatcherLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WM_FileWatcherUI
{
    public partial class dashboardForm : Form
    {
        public static dashboardForm instance;
        public List<FileWatcherModel> fileWatchers;
        public ListBox dashboardListBox;
        public dashboardForm()
        {
            InitializeComponent();
            instance = this;
            fileWatchers = new List<FileWatcherModel>();
            dashboardListBox = db_fileWatcherListBox;
            // TODO - Uncomment when full filewatcher can load from DB.
            fileWatchers = GlobalConfig.Connection.GetFileWatchers_All();
            foreach (FileWatcherModel f in fileWatchers)
            {
                db_fileWatcherListBox.Items.Add(f.FileWatcherName);
            }
        }
    }
}
