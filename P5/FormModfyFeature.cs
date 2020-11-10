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
    public partial class FormModfyFeature : Form
    {
        int projectId;
        int featureId;
        FakeFeatureRepository repo = new FakeFeatureRepository();
        public FormModfyFeature(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            DialogResult = DialogResult.Cancel;
        }

        private void FormModfyFeature_Load(object sender, EventArgs e)
        {
            FormSelectFeature form = new FormSelectFeature(this.projectId);
            form.ShowDialog();
            CenterToScreen();
            if (form.DialogResult != DialogResult.OK)
            {
                Close();
            }
            else
            {
                featureId = form.selectedId;
                titleTextbox.Text = repo.GetFeatureById(featureId).Title;
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string error;
            Feature feature = repo.GetFeatureById(featureId);
            feature.Title = titleTextbox.Text;
            error = repo.Modify(feature);
            if(error == FakeFeatureRepository.NO_ERROR) {
                DialogResult = DialogResult.OK;
                Close();
            }
            else {
                MessageBox.Show(error, "Attention", MessageBoxButtons.OK);
            }
        }
    }
}
