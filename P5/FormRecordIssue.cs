﻿using System;
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
    public partial class FormRecordIssue : Form
    {
        FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
        FakeAppUserRepository fakeAppUserRepository = new FakeAppUserRepository();
        int ProjectId;
        public FormRecordIssue(int ProjectId)
        {
            InitializeComponent();
            CenterToScreen();
            this.ProjectId = ProjectId;
            idTextBox.Text = FakeIssueRepository.currentId.ToString();
            foreach(AppUser x in fakeAppUserRepository.GetAll()) {
                discovererDropDown.Items.Add(x.LastName + ", " + x.FirstName);
            }
            discovererDropDown.SelectedIndex = 0;
            statusDropDown.SelectedIndex = 0;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Issue newIssue = new Issue();
            string error;
            newIssue.Id = FakeIssueRepository.currentId++;
            newIssue.ProjectId = this.ProjectId;
            newIssue.Title = titleTextBox.Text;
            newIssue.DiscoveryDate = dateTimePicker.Value;
            newIssue.Discoverer = discovererDropDown.SelectedItem.ToString();
            newIssue.InitialDescription = descriptionTextBox.Text;
            newIssue.Component = componentTextBox.Text;
            newIssue.IssueStatusId = statusDropDown.SelectedIndex;
            error = fakeIssueRepository.Add(newIssue);
            if (error == FakeIssueRepository.NO_ERROR)
            {
                Close();
            }
            else {
                MessageBox.Show(error, "Attention", MessageBoxButtons.OK);
            }
        }
    }
}
