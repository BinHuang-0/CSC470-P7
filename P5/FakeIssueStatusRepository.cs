using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        public static List<IssueStatus> IssueStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository() {

        }

        public void Add(int Id, string value) {
            IssueStatuses.Add(new IssueStatus(Id, value));
        }
        public List<IssueStatus> GetAll() {
            return IssueStatuses;
        } 
        public int GetIdByStatus(string value) {
            return IssueStatuses.Find(x => x.Value == value).Id;
        }
        public string GetValueById(int Id) {
            return IssueStatuses.Find(x => x.Id == Id).Value;
        }
    }
}
