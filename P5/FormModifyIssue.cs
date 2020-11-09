using P7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7
{
    public partial class FormModifyIssue : Form
    {
        FakeIssueRepository repository = new FakeIssueRepository();
        FakeAppUserRepository userRepo = new FakeAppUserRepository();
        Issue currentIssue;
        int projectId;
        public FormModifyIssue(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            Issue newIssue = new Issue();
            string error;
            newIssue.Id = currentIssue.Id;
            newIssue.ProjectId = currentIssue.ProjectId;
            newIssue.Title = titleTextBox.Text;
            newIssue.DiscoveryDate = dateTimePicker.Value;
            newIssue.Discoverer = discovererDropDown.SelectedItem.ToString();
            newIssue.InitialDescription = descriptionTextBox.Text;
            newIssue.Component = componentTextBox.Text;
            newIssue.IssueStatusId = statusDropDown.SelectedIndex;
 
            error = repository.Modify(newIssue);
            if(error == FakeIssueRepository.NO_ERROR) {
                Close();
            }
            else {
                MessageBox.Show(error, "Attention", MessageBoxButtons.OK);
            }
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(projectId);
            form.ShowDialog();
            CenterToScreen();
            if (form.DialogResult != DialogResult.OK)
            {
                Close();
            }
            else
            {
                currentIssue = repository.GetIssueById(form.selectedId);
                foreach (AppUser x in userRepo.GetAll())
                {
                    discovererDropDown.Items.Add(x.LastName + ", " + x.FirstName);
                }
                discovererDropDown.SelectedIndex = 0;
                idTextBox.Text = currentIssue.Id.ToString();
                titleTextBox.Text = currentIssue.Title;
                dateTimePicker.Value = currentIssue.DiscoveryDate;
                discovererDropDown.SelectedItem = currentIssue.Discoverer;
                componentTextBox.Text = currentIssue.Component;
                statusDropDown.SelectedIndex = currentIssue.IssueStatusId;
                descriptionTextBox.Text = currentIssue.InitialDescription;
            }
        }
    }
}
