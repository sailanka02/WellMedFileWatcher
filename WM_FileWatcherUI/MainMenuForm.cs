using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FileWatcherLibrary;
using FileWatcherLibrary.Models;
using FontAwesome.Sharp;
//using FileWatcherLibrary;


namespace WM_FileWatcherUI
{
    public partial class MainMenuForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form currentChildForm;
        public static MainMenuForm instance;
        public List<FileWatcherModel> fileWatchers;

        public MainMenuForm()
        {
            InitializeComponent();
            instance = this;
            fileWatchers = GlobalConfig.Connection.GetFileWatchers_All();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object senderBtn)
        {
            DisableBtn();
            //Button
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = Color.FromArgb(45, 45, 48);
            currentBtn.ForeColor = Color.FromArgb(0, 142, 126);
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = Color.FromArgb(0, 142, 126);
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            //Left button border
            leftBorderBtn.BackColor = Color.FromArgb(0, 142, 126);
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            //Child Icon
            iconShowChildForm.IconChar = currentBtn.IconChar;
            iconShowChildForm.IconColor = Color.FromArgb(0, 142, 126);
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 37, 38);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleOfChild.Text = currentBtn.Text;
            lblTitleOfChild.ForeColor = Color.FromArgb(0, 142, 126);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new newDashboard());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new editCreateForm2());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            iconShowChildForm.IconChar = IconChar.HomeLg;
            iconShowChildForm.IconColor = Color.Gainsboro;
            lblTitleOfChild.Text = "Home";
            lblTitleOfChild.ForeColor = Color.Gainsboro;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FilewatcherLogForm());
        }
    }
}
