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
    public partial class FormIssueDashboard : Form
    {
        public FakeIssueRepository FakeIssueRepository;
        public int currentProjectId;
        public FormIssueDashboard(int ProjectId)
        {
            InitializeComponent();
            CenterToScreen();
            FakeIssueRepository = new FakeIssueRepository();
            currentProjectId = ProjectId;
            numberOfIssuesLabel.Text = "Total Number of Issues: " + FakeIssueRepository.GetTotalNumberOfIssues(currentProjectId);
            List<string> issueMonths = FakeIssueRepository.GetIssuesByMonth(currentProjectId);
            List<string> issueDicoverers = FakeIssueRepository.GetIssuesByDiscoverer(currentProjectId);
            foreach(string s in issueMonths) {
                issuesMonthListBox.Items.Add(s);
            }
            foreach(string s in issueDicoverers) {
                issuesDiscovererListBox.Items.Add(s);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
