using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class IssueStatus
    {
        public int Id;
        public string Value;

        public IssueStatus(int Id, string value) {
            this.Id = Id;
            this.Value = value;
        }
    }
}
