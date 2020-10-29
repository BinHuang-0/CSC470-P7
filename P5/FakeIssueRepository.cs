using Castle.Core.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        public static List<Issue> Issues = new List<Issue>();
        public static int currentId = 1;
   
        public FakeIssueRepository() {
        }

        public string Add(Issue issue) {
            string error;
            error = ValidateIssue(issue);
            if (error != NO_ERROR) {
                return error;
            }
            if(isDuplicate(issue.Title)) {
                return "Duplicate Title";
            }
            Issues.Add(issue);
            return NO_ERROR;
        }
        public List<Issue> GetAll(int ProjectId) {
            return Issues.Where(x=>x.ProjectId == ProjectId).ToList();
        }
        public bool Remove(Issue issue) {
            Issues.RemoveAll(x => x.Id == issue.Id);
            return true;
        }
        public string Modify(Issue issue) {
//            int index;
            string error;
            Issue save = GetIssueById(issue.Id);
            error = ValidateIssue(issue);
            if (error != NO_ERROR) {
                return error;
            }
            Remove(issue);
            if(isDuplicate(issue.Title)) {
                Add(save);
                error = "Duplicate Title";
            }
            else {
                Add(issue);
            }
            Issues.Sort((x,y)=> x.Id.CompareTo(y.Id));
//               index = Issues.FindIndex(x => x.Id == issue.Id);
//               Issues[index] = issue;
            return error;
        }
        public int GetTotalNumberOfIssues(int ProjectId) {
            return Issues.Where(x=>x.ProjectId == ProjectId).Count();
        }
        public List<string> GetIssuesByMonth(int ProjectId) {
            int count = 0;
            int year;
            int month;
            List<string> retList = new List<string>();
            List<Issue> thisProjectIssues = Issues.Where(x => x.ProjectId == ProjectId).ToList();
            if(thisProjectIssues.IsNullOrEmpty()) {
                return retList;
            }
            thisProjectIssues.Sort((x, y) => x.DiscoveryDate.CompareTo(y.DiscoveryDate));
            year = thisProjectIssues.First().DiscoveryDate.Year;
            month = thisProjectIssues.First().DiscoveryDate.Month;
            foreach (Issue x in thisProjectIssues) {
                if (x.DiscoveryDate.Year != year || x.DiscoveryDate.Month != month) {
                    retList.Add(year + " - " + month + ": " + count);
                    year = x.DiscoveryDate.Year;
                    month = x.DiscoveryDate.Month;
                    count = 0;
                }
                count++;
            }
            retList.Add(year + " - " + month + ": " + count);
            return retList;
        }
        public List<string> GetIssuesByDiscoverer(int ProjectId) {
            int count = 0;
            string person;
            List<string> retList = new List<string>();
            List<Issue> thisProjectIssues = Issues.Where(x => x.ProjectId == ProjectId).ToList();
            if(thisProjectIssues.IsNullOrEmpty()) {
                return retList;
            }
            thisProjectIssues.Sort((x, y) => x.Discoverer.CompareTo(y.Discoverer));
            person = thisProjectIssues.First().Discoverer;
            foreach(Issue x in thisProjectIssues) {
                if(x.Discoverer != person) {
                    retList.Add(person + ": " + count);
                    person = x.Discoverer;
                    count = 0;
                }
                count++;
            }
            retList.Add(person + ": " + count);
            return retList;
        }
        public Issue GetIssueById(int Id) {
            return Issues.Find(x => x.Id == Id);
        }

        public string ValidateIssue(Issue issue) {
            if(issue.Title == null || issue.Title == "") {
                return EMPTY_TITLE_ERROR;
            }
            if(issue.DiscoveryDate == null) {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if(issue.DiscoveryDate.CompareTo(DateTime.Now) > 0) {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            if(issue.Discoverer == null || issue.Discoverer == "") {
                return EMPTY_DISCOVERER_ERROR;
            }
            return NO_ERROR;
        }
        public bool isDuplicate(string title) {
            if(Issues.Where(x => x.Title.CompareTo(title) == 0).Count() != 0) {
                return true;
            }
            return false;
        }
    }
}
