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
    public partial class FormSelectIssue : Form
    {
        FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
        public int selectedId;
        public FormSelectIssue(int projectId)
        {
            InitializeComponent();
            CenterToScreen();
            selectedId = projectId;
            DialogResult = DialogResult.Cancel;
            foreach(Issue x in fakeIssueRepository.GetAll(selectedId)) {
                string status = "";
                switch(x.IssueStatusId) {
                    case 0:
                        status = "Open";
                        break;
                    case 1:
                        status = "Assigned";
                        break;
                    case 2:
                        status = "Fixed";
                        break;
                    case 3:
                        status = "Closed - Won't fix";
                        break;
                    case 4:
                        status = "Closed - Fixed";
                        break;
                    case 5:
                        status = "Closed - by design";
                        break;
                }
                dataGridView1.Rows.Add(x.Id, x.Title, x.DiscoveryDate.ToString(), x.Discoverer, x.InitialDescription, x.Component, status);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
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
