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
    public partial class FormRemoveFeature : Form
    {
        int projectId;
        FakeFeatureRepository repo;
        public FormRemoveFeature(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            repo = new FakeFeatureRepository();
            DialogResult = DialogResult.Cancel;
        }

        private void FormRemoveFeature_Load(object sender, EventArgs e)
        {
            FakeRequirementRepository reqRep = new FakeRequirementRepository();
            FormSelectFeature form = new FormSelectFeature(projectId);
            form.ShowDialog();
            CenterToScreen();
            Feature feature;
            if (form.DialogResult == DialogResult.OK)
            {
                feature = repo.GetFeatureById(form.selectedId);
                DialogResult result = MessageBox.Show("Are you sure you want to remove : " + feature.Title, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    if(reqRep.CountByFeatureId(feature.Id) != 0) {
                        result = MessageBox.Show("There are one or more requirements associated with this feature. These requirements will be destroyed if you remove this  feature. Are you sure you want to remove: " + feature.Title, "Confirmation", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes) {
                            reqRep.RemoveByFeatureId(feature.Id);
                            repo.Remove(feature);
                        }
                    }
                    else {
                        repo.Remove(feature);
                    }
                }
            }
            Close();
        }
    }
}
