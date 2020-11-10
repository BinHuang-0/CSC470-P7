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
    public partial class FormCreateFeature : Form
    {
        private int projectId;
        public FormCreateFeature(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            DialogResult = DialogResult.Cancel;
            CenterToScreen();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            Feature feature = new Feature();
            string error;
            feature.Title = titleTextbox.Text;
            feature.ProjectId = this.projectId;
            feature.Id = FakeFeatureRepository.currentId;
            error = featureRepository.Add(feature);
            if (error != FakeFeatureRepository.NO_ERROR) {
                MessageBox.Show(error, "", MessageBoxButtons.OK);
            }
            else {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
