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
    public partial class FormCreateRequirement : Form
    {
        private int projectId;
        FakeRequirementRepository repo = new FakeRequirementRepository();
        public FormCreateRequirement(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            DialogResult = DialogResult.Cancel;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Requirement requirement = new Requirement();
            FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
            string error;
            requirement.Id = FakeRequirementRepository.currentId;
            requirement.ProjectId = this.projectId;
            requirement.Statement = statementTextbox.Text;
            requirement.FeatureId = fakeFeatureRepository.GetFeatureByTitle(featureComboBox.SelectedItem.ToString()).Id;
            error = repo.Add(requirement);
            if(error != FakeRequirementRepository.NO_ERROR) {
                MessageBox.Show(error, "Attention", MessageBoxButtons.OK);
            }
            else {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void FormCreateRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            featureComboBox.Items.Add("<Make Selecttion>");
            foreach(Feature x in FakeFeatureRepository.features) {
                featureComboBox.Items.Add(x.Title);
            }
            featureComboBox.SelectedIndex = 0;
        }

        private void featureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(featureComboBox.SelectedIndex == 0) {
                createBtn.Enabled = false;
                statementTextbox.Enabled = false;
            }
            else {
                createBtn.Enabled = true;
                statementTextbox.Enabled = true;
            }
        }
    }
}
