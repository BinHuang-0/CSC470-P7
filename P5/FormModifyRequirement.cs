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
    public partial class FormModifyRequirement : Form
    {
        FakeRequirementRepository repo = new FakeRequirementRepository();
        int projectId;
        public FormModifyRequirement(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            DialogResult = DialogResult.Cancel;
        }

        private void FormModifyRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FormSelectRequirement form = new FormSelectRequirement(projectId);
            form.ShowDialog();
            if(form.DialogResult != DialogResult.OK) {
                DialogResult = DialogResult.Cancel;
                Close();
            } 
            else {
                featureComboBox.Items.Add("<Make Selection");
                foreach(Feature x in FakeFeatureRepository.features) {
                    featureComboBox.Items.Add(x.Title);
                    if(x.Id == repo.GetRequirementById(form.selectedId).FeatureId) {
                        featureComboBox.SelectedItem = x.Title;
                    }
                }
                statementTextbox.Text = repo.GetRequirementById(form.selectedId).Statement;
            }
        }

        private void featureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(featureComboBox.SelectedIndex == 0) {
                statementTextbox.Enabled = false;
                modifyBtn.Enabled = false;
            }
            else {
                statementTextbox.Enabled = true;
                modifyBtn.Enabled = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            Requirement requirement = new Requirement();
            FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
            string error;
            requirement.Id = FakeRequirementRepository.currentId;
            requirement.ProjectId = this.projectId;
            requirement.Statement = statementTextbox.Text;
            requirement.FeatureId = fakeFeatureRepository.GetFeatureByTitle(featureComboBox.SelectedItem.ToString()).Id;
            error = repo.Modify(requirement);
            if(error != FakeRequirementRepository.NO_ERROR) {
                MessageBox.Show(error, "Attention", MessageBoxButtons.OK);
            }
            else {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
