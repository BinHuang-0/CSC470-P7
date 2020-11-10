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
    public partial class FormRemoveRequirement : Form
    {
        int projectId;
        FakeRequirementRepository repo;
        public FormRemoveRequirement(int projectId)
        {
            InitializeComponent();
            this.projectId = projectId;
            repo = new FakeRequirementRepository();
            DialogResult = DialogResult.Cancel;
        }

        private void FormRemoveRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FormSelectRequirement form = new FormSelectRequirement(projectId);
            form.ShowDialog();
            Requirement requirement;
            if (form.DialogResult == DialogResult.OK)
            {
                requirement = repo.GetRequirementById(form.selectedId);
                DialogResult result = MessageBox.Show("Are you sure you want to remove : " + requirement.Statement, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    repo.Remove(requirement);
                }
            }
            Close();
        }
    }
}
