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
    public partial class FormSelectFeature : Form
    {
        public int selectedId;
        private FakeFeatureRepository featureRepository;
        public FormSelectFeature(int projectId)
        {
            InitializeComponent();
            CenterToScreen();
            selectedId = projectId;
            featureRepository = new FakeFeatureRepository();
            DialogResult = DialogResult.Cancel;
            foreach(Feature x in FakeFeatureRepository.features) {
                dataGridView1.Rows.Add(x.Id, x.Title);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            int rowIndex;
            rowIndex = dataGridView1.SelectedRows[0].Index;
            selectedId = (int)dataGridView1.Rows[rowIndex].Cells[0].Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
