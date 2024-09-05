using FileWatcherLibrary;
using FileWatcherLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;


namespace WM_FileWatcherUI
{
    public partial class editCreateForm2 : Form
    {
        public static editCreateForm2 instance;
        private FileWatcherModel model = new FileWatcherModel();
        public bool isNewFileWatcher = true;

        public editCreateForm2()
        {
            InitializeComponent();
            instance = this;
            edit_creatorTextBox.Text = Environment.UserDomainName + "\\" + Environment.UserName;
            edit_creatorTextBox.ReadOnly = true;
            btnUpdateEvent.Visible = false;
        }
        public editCreateForm2(FileWatcherModel f)
        {
            InitializeComponent();
            instance = this;
            model = MainMenuForm.instance.fileWatchers[MainMenuForm.instance.fileWatchers.IndexOf(f)];
            edit_fileWatcherNameTextBox.Text = model.FileWatcherName;
            edit_creatorTextBox.Text = model.CreatorID;
            btnUpdateEvent.Visible = true;
            foreach (EventModel em in model.FileWatcherEvents)
            {
                evnt_eventActionsListBox.Items.Add("Move "+ em.SourceDirectory+ " to "+ em.DestinationDirectory);
                foreach (string nf in em.FileNameFilter)
                {
                    edit_fileNameFilterListBox.Items.Add(nf);
                }
            }
        }

        private void editCreateForm2_Load(object sender, EventArgs e)
        {
            ex_executionTimeTextBox.Text = "hh:mm:ss";

            ex_executionTimeTextBox.GotFocus += (RemoveText);
            ex_executionTimeTextBox.LostFocus += (AddText);

            if (isNewFileWatcher)
            {
                edit_creatorTextBox.Text = Environment.UserDomainName + "\\" + Environment.UserName;
                label3.Visible = false;
                changeSummaryTextBox.Visible = false;
                edit_createEditFileWatcherButton.Text = "Create File Watcher";
            }
            edit_creatorTextBox.ReadOnly = true;
        }

        private void edit_fileNameFilterAddButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(edit_fileNameFilterTextBox.Text))
            {
                edit_fileNameFilterListBox.Items.Add(edit_fileNameFilterTextBox.Text);
                edit_fileNameFilterTextBox.ResetText();
            }
            else
            {
                MessageBox.Show("Name Filter Text Box is Empty");
            }
        }

        private void edit_fileNameFilterRemoveButton_Click(object sender, EventArgs e)
        {
            if (evnt_eventActionsListBox.SelectedIndex != -1)
            {
                model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].FileNameFilter.RemoveAt(edit_fileNameFilterListBox.SelectedIndex);
                edit_fileNameFilterListBox.Items.RemoveAt(edit_fileNameFilterListBox.SelectedIndex); 
            }
            else
            {
                edit_fileNameFilterListBox.Items.RemoveAt(edit_fileNameFilterListBox.SelectedIndex);
            }
        }

        private void evnt_browseSourceDirectoryButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                evnt_sourceDirectoryTextBox.Text = dialog.FileName;
            }
        }

        private void evnt_browseDestinationDirectoryButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                evnt_destinationDirectoryTextBox.Text = dialog.FileName;
            }
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if (validateSourceDirectory() && validateDestinationDirectory() && validateDirectories() && validateTime(ex_executionTimeTextBox.Text))
            {
                string sourcePath = evnt_sourceDirectoryTextBox.Text;
                string sourceFolderName = new DirectoryInfo(sourcePath).Name;
                string destinationPath = evnt_destinationDirectoryTextBox.Text;
                string destinationFolderName = new DirectoryInfo(destinationPath).Name;
                evnt_eventActionsListBox.Items.Add("Move " + sourceFolderName + " to " + destinationFolderName);
                //evList.Add("Move " + sourceFolderName + " to " + destinationFolderName);

                EventModel em = new EventModel();
                em.SourceDirectory = evnt_sourceDirectoryTextBox.Text;
                em.DestinationDirectory = evnt_destinationDirectoryTextBox.Text;
                em.EventPeriodicity = TimeSpan.Parse(ex_executionTimeTextBox.Text); //parses hh:mm:ss time input
                foreach(string f in edit_fileNameFilterListBox.Items)
                {
                    em.FileNameFilter.Add(f);
                }
                model.FileWatcherEvents.Add(em);
                ex_executionTimeTextBox.ResetText();
                evnt_destinationDirectoryTextBox.ResetText();
                evnt_sourceDirectoryTextBox.ResetText();
            }
            else if (!validateTime(ex_executionTimeTextBox.Text))
            {
                MessageBox.Show("Invalid time format.");
            }
            else if (!validateDirectories())
            {
                MessageBox.Show("Source/Destination directory is null/empty.");
            }
            else if (!validateSourceDirectory())
            {
                MessageBox.Show("Source directory does not exist.");
            }
            else if (!validateDestinationDirectory())
            {
                MessageBox.Show("Destination directory does not exist.");
            }

        }

        private void removeEventButton_Click(object sender, EventArgs e)
        {
            if (evnt_eventActionsListBox.SelectedIndex != -1)
            {
                model.FileWatcherEvents.RemoveAt(evnt_eventActionsListBox.SelectedIndex);
                evnt_eventActionsListBox.Items.RemoveAt(evnt_eventActionsListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Event not selected in Events Listbox to be deleted");
            }
        }

        private void edit_createEditFileWatcherButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() && isNewFileWatcher)
            {
                model.FileWatcherName = edit_fileWatcherNameTextBox.Text;
                model.CreatorID = edit_creatorTextBox.Text;
                model.LastEdited = DateTime.Now;
                model.LastEditedBy = model.CreatorID;
                model.ActiveFileWatcher = true;
                MainMenuForm.instance.fileWatchers.Add(GlobalConfig.Connection.CreateFileWatcher(model));
                edit_fileWatcherNameTextBox.ResetText();
                edit_creatorTextBox.ResetText();
                ex_executionTimeTextBox.ResetText();
                edit_fileNameFilterTextBox.ResetText();
                evnt_destinationDirectoryTextBox.ResetText();
                evnt_sourceDirectoryTextBox.ResetText();
                edit_fileNameFilterListBox.Items.Clear();
                evnt_eventActionsListBox.Items.Clear();
                Close();
            }
            else if (ValidateForm() && !isNewFileWatcher)
            {
                // TODO - This is the update information section.
                model.LastEditedBy = Environment.UserDomainName + "\\" + Environment.UserName;
                model.LastEdited = DateTime.Now;
                model.LastEditSummary = changeSummaryTextBox.Text;
                MainMenuForm.instance.fileWatchers[MainMenuForm.instance.fileWatchers.IndexOf(model)] = model;
                GlobalConfig.Connection.UpdateFileWatcher(model.ID, model.LastEdited, model.LastEditedBy, model.LastEditSummary);
                foreach (EventModel item in model.FileWatcherEvents)
                {
                    GlobalConfig.Connection.DeleteFileWatcherEvent(model.ID, item.ID);
                }
                MainMenuForm.instance.fileWatchers[MainMenuForm.instance.fileWatchers.IndexOf(model)] = GlobalConfig.Connection.UpdateFileWatcherEvents(model);
                Close();
            }
            else
            {
                MessageBox.Show("Form has missing information.");
            }
        }

        private bool validateSourceDirectory()
        {
            bool output = false;
            if  (Directory.Exists(evnt_sourceDirectoryTextBox.Text))
            {
                output = true;
            }
            return output;

        }
        private bool validateDestinationDirectory()
        {
            bool output = false;
            if  (Directory.Exists(evnt_destinationDirectoryTextBox.Text))
            {
                output = true;
            }
            return output;
        }
        private bool validateDirectories()
        {
            bool output = true;

            if (String.IsNullOrEmpty(evnt_destinationDirectoryTextBox.Text))
            {
                output = false;
            }
            else if (String.IsNullOrEmpty(evnt_sourceDirectoryTextBox.Text))
            {
                output = false;
            }
            return output;
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (String.IsNullOrEmpty(edit_fileWatcherNameTextBox.Text))
            {
                output = false;
            }
            else if (evnt_eventActionsListBox.Items.Count == 0)
            {
                output = false;
            }
            return output;
        }

        private bool validateTime(string input)
        {
            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);

        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (ex_executionTimeTextBox.Text == "hh:mm:ss")
            {
                ex_executionTimeTextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ex_executionTimeTextBox.Text))
                ex_executionTimeTextBox.Text = "hh:mm:ss";
        }

        private void evnt_eventActionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (evnt_eventActionsListBox.SelectedIndex != -1)
            {
                foreach (string item in model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].FileNameFilter)
                {
                    edit_fileNameFilterListBox.Items.Add(item);
                }
                ex_executionTimeTextBox.Text = model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].EventPeriodicity.ToString();
                evnt_sourceDirectoryTextBox.Text = model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].SourceDirectory;
                evnt_destinationDirectoryTextBox.Text = model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].DestinationDirectory; 
            }
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (evnt_eventActionsListBox.SelectedIndex != -1)
            {
                model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].EventPeriodicity = TimeSpan.Parse(ex_executionTimeTextBox.Text);
                model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].SourceDirectory = evnt_sourceDirectoryTextBox.Text;
                model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].DestinationDirectory = evnt_destinationDirectoryTextBox.Text;
                List<string> tempList = new List<string>();
                foreach (string item in edit_fileNameFilterListBox.Items)
                {
                    tempList.Add(item);
                }
                model.FileWatcherEvents[evnt_eventActionsListBox.SelectedIndex].FileNameFilter = tempList;

                evnt_eventActionsListBox.ClearSelected();
                ex_executionTimeTextBox.Clear();
                evnt_sourceDirectoryTextBox.Clear();
                evnt_destinationDirectoryTextBox.Clear();
                edit_fileNameFilterListBox.Items.Clear();
            }
        }
    }
}
