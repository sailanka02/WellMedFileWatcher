using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileWatcherLibrary.Models;
//change browse buttons and validate depending on whteher a file or a directory is chosen for each of the options
//implement a way to browse directories on the network  //most likely for destination
//implement a remove all button 

namespace WM_FileWatcherUI
{
    public partial class eventsForm : Form
    {
        public static eventsForm instance;
        List<EventModel> eventList = new List<EventModel>();
        //string tempSource = new List<string>();
        //List<string> destination = new List<string>();
        
        public eventsForm()
        {
            InitializeComponent();
            instance = this;
        }

        private bool validateSourcePath()
        {
            bool output = false;
            if (evnt_eventsDropdownComboBox.Text == "Create")
            {
                output = true;  
            }
            else if (evnt_eventsDropdownComboBox.Text == "Delete" && File.Exists(evnt_sourceDirectoryTextBox.Text))
            {
                output = true;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Move" && File.Exists(evnt_sourceDirectoryTextBox.Text))
            {
                output = true;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Archive" && File.Exists(evnt_sourceDirectoryTextBox.Text))
            {
                output = true;
            }
            return output;

        }
        private bool validateDestinationPath()
        {
            bool output = false;

            if (evnt_eventsDropdownComboBox.Text == "Delete")
            {
                output = true;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Create" && Directory.Exists(evnt_destinationDirectoryTextBox.Text))
            {
                output = true;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Move" && Directory.Exists(evnt_destinationDirectoryTextBox.Text))
            {
                output = true;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Archive" && Directory.Exists(evnt_destinationDirectoryTextBox.Text))
            {
                output = true;
            }
            return output;
        }

        private bool ValidateEventsForm()
        {
            bool output = true;

            if (evnt_eventsDropdownComboBox.SelectedIndex == -1)
            {
                output = false;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Create" && String.IsNullOrEmpty(evnt_destinationDirectoryTextBox.Text))
            {
                output = false;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Delete" && String.IsNullOrEmpty(evnt_sourceDirectoryTextBox.Text))
            {
                output = false;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Move" && (String.IsNullOrEmpty(evnt_sourceDirectoryTextBox.Text) || String.IsNullOrEmpty(evnt_destinationDirectoryTextBox.Text)))
            {
                output = false;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Archive" && (String.IsNullOrEmpty(evnt_sourceDirectoryTextBox.Text) || String.IsNullOrEmpty(evnt_destinationDirectoryTextBox.Text)))
            {
                output = false;
            }
            return output;
        }

        private void evnt_eventsDropdownComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (evnt_eventsDropdownComboBox.Text == "Create")
            {
                //evnt_sourceDirectoryTextBox.Visible = false;
                evnt_destinationDirectoryTextBox.ResetText();
                evnt_destinationDirectoryTextBox.ReadOnly = false;
                evnt_sourceDirectoryTextBox.Text = "N/A";
                evnt_sourceDirectoryTextBox.ReadOnly = true;
                evnt_browseSourceDirectoryButton.Enabled = false;
                evnt_browseDestinationDirectoryButton.Enabled = true;
            }
            else if (evnt_eventsDropdownComboBox.Text == "Delete")
            {
                evnt_sourceDirectoryTextBox.ResetText();
                evnt_sourceDirectoryTextBox.ReadOnly = false;
                evnt_destinationDirectoryTextBox.Text = "N/A";
                evnt_destinationDirectoryTextBox.ReadOnly = true;
                evnt_browseDestinationDirectoryButton.Enabled = false;
                evnt_browseSourceDirectoryButton.Enabled = true;
            }
            else
            {
                evnt_sourceDirectoryTextBox.ResetText();
                evnt_destinationDirectoryTextBox.ResetText();
                evnt_destinationDirectoryTextBox.ReadOnly = false;
                evnt_sourceDirectoryTextBox.ReadOnly = false;
                evnt_browseDestinationDirectoryButton.Enabled = true;
                evnt_browseSourceDirectoryButton.Enabled = true;
            }

        }

        private void evnt_browseSourceDirectoryButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                string strFilePath = openFileDialog1.FileName;
                evnt_sourceDirectoryTextBox.Text = strFilePath;
            }

        }

        private void evnt_browseDestinationDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                evnt_destinationDirectoryTextBox.Text = selectedFolderPath;
            }

        }

        private void evnt_forwardButton_Click(object sender, EventArgs e)
        {
            if (ValidateEventsForm() && validateSourcePath() && validateDestinationPath())
            {
                EventModel model1 = new EventModel();
                model1.SourceDirectory = evnt_sourceDirectoryTextBox.Text;
                model1.DestinationDirectory = evnt_destinationDirectoryTextBox.Text;
                evnt_destinationDirectoryTextBox.ResetText();
                evnt_sourceDirectoryTextBox.ResetText();
                evnt_eventsDropdownComboBox.ResetText();
                evnt_eventsDropdownComboBox.SelectedIndex = -1;
                evnt_destinationDirectoryTextBox.ReadOnly = true;
                evnt_sourceDirectoryTextBox.ReadOnly = true;
                evnt_browseDestinationDirectoryButton.Enabled = false;
                evnt_browseSourceDirectoryButton.Enabled = false;
                checkBox1.Checked = false;
                eventList.Add(model1);
                
            }
            else if (!ValidateEventsForm())
            {
                MessageBox.Show("This event has invalid/missing information.");
            }
            else if (!validateSourcePath())
            {
                MessageBox.Show("Source path does not exist.");
            }
            else if (!validateDestinationPath())
            {
                MessageBox.Show("Destination path does not exist.");
            }
        }

        private void evnt_backwardButton_Click(object sender, EventArgs e)
        {
            if (evnt_eventActionsListBox.SelectedIndex != -1)
            {
                int indx = evnt_eventActionsListBox.SelectedIndex;
                evnt_eventActionsListBox.Items.RemoveAt(indx);
            }
            else 
            {
                MessageBox.Show("Please select a valid event index to remove.");
            }
        }

        private void eventsForm_Load(object sender, EventArgs e)
        {
            evnt_eventsDropdownComboBox.Items.Add("Create");
            evnt_eventsDropdownComboBox.Items.Add("Delete");
            evnt_eventsDropdownComboBox.Items.Add("Move");
            evnt_eventsDropdownComboBox.Items.Add("Archive");

            evnt_eventsDropdownComboBox.SelectedIndex = -1;
            evnt_sourceDirectoryTextBox.ReadOnly = true;
            evnt_destinationDirectoryTextBox.ReadOnly = true;
            evnt_browseSourceDirectoryButton.Enabled = false;
            evnt_browseDestinationDirectoryButton.Enabled = false;
            evnt_eventsDropdownComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
