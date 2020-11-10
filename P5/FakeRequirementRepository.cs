using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        public const string EMPTY_STATEMENT_ERROR = "Statement must have a value";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist";
        public const string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement";
        public const string MISSING_PROJECTID_ERROR = "Must select a project for this requirement";

        public static List<Requirement> requirements = new List<Requirement>();
        public static int currentId = 1;
        public FakeRequirementRepository() {

        }

        public string Add(Requirement requirement) {
            string error;
            if(requirement.Statement == "") {
                error = EMPTY_STATEMENT_ERROR;
            }
            else if(requirements.Where(x => x.Statement.CompareTo(requirement.Statement) == 0).Count() != 0) {
                error = DUPLICATE_STATEMENT_ERROR;
            }
            else if(requirement.FeatureId < 1) {
                error = MISSING_FEATUREID_ERROR;
            }
            else if(requirement.ProjectId < 1) {
                error = MISSING_PROJECTID_ERROR;
            }
            else {
                error = NO_ERROR;
                requirements.Add(requirement);
            }
            return error;
        }
        public List<Requirement> GetAll(int ProjectId) {
            return requirements.Where(x=>x.ProjectId == ProjectId).ToList();
        }
        public string Remove(Requirement requirement) {
            requirements.RemoveAll(x => x.Id == requirement.Id);
            return NO_ERROR;
        }
        public string Modify(Requirement requirement) {
            string error;
            if (requirement.Statement == "") {
                error = EMPTY_STATEMENT_ERROR;
            }
            else if(requirements.Where(x => x.Statement.CompareTo(requirement.Statement) == 0).Count() != 0){
                error = DUPLICATE_STATEMENT_ERROR;
            }
            else {
                error = NO_ERROR;
                requirements[requirements.FindIndex(x => x.Id == requirement.Id)].Statement = requirement.Statement;
            }
            return error;
        }
        public Requirement GetRequirementById(int requirementId) {
            return requirements.Find(x => x.Id == requirementId);
        }
        public int CountByFeatureId(int featureId) {
            return requirements.FindAll(x => x.FeatureId == featureId).Count();
        }
        public void RemoveByFeatureId(int featureId) {
            requirements.RemoveAll(x => x.FeatureId == featureId);
        }
    }
}
