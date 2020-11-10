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
    public partial class FormSelectRequirement : Form
    {
        FakeRequirementRepository repo = new FakeRequirementRepository();
        int projectId;
        public int selectedId;
        public FormSelectRequirement(int projectId)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            this.projectId = projectId;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            selectedId = (int)requirementDataGridView.SelectedRows[0].Cells[0].Value;
            Close();
        }

        private void FormSelectRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            featureComboBox.Items.Add("<Make Selection>");
            foreach(Feature x in FakeFeatureRepository.features) {
                featureComboBox.Items.Add(x.Title);
            }
            featureComboBox.SelectedIndex = 0;
        }

        private void featureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
            foreach(DataGridViewRow x in requirementDataGridView.Rows) {
                requirementDataGridView.Rows.Remove(x);
            }

            if(featureComboBox.SelectedIndex != 0) {
                int featureId = fakeFeatureRepository.GetFeatureByTitle(featureComboBox.SelectedItem.ToString()).Id;   
                foreach(Requirement x in FakeRequirementRepository.requirements.FindAll(x => x.FeatureId == featureId)) {
                    requirementDataGridView.Rows.Add(x.Id, x.Statement);
                }
                selectBtn.Enabled = true;
            }
            else {
                selectBtn.Enabled = false;
            }
        }
    }
}
