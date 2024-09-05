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
    public partial class FilewatcherLogForm : Form
    {
        public FilewatcherLogForm()
        {
            InitializeComponent();
            this.fileWatcherLoggingTableAdapter.Fill(this.iS_FileWatcherDataSet.FileWatcherLogging);
        }

        private void FilewatcherLogForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS_FileWatcherDataSet.FileWatcherLogging' table. You can move, or remove it, as needed.
            this.fileWatcherLoggingTableAdapter.Fill(this.iS_FileWatcherDataSet.FileWatcherLogging);

        }
    }
}
