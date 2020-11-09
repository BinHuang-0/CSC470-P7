using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title must be unique.";
        public const string EMPTY_TITLE_ERROR = "Title must have a value.";
        public const string NOT_FOUND_ERROR = "Feature not found.";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature.";

        public static List<Feature> features;

        FakeFeatureRepository() {

        }
        public string Add(Feature feature) {

        }
        public List<Feature> GetAll(int ProjectId) {

        }
        public string Remove(Feature feature) {

        }
        public string Modify(Feature feature) {

        }
        public Feature GetFeatureById(int featureId) {

        }
        public Feature GetFeatureByTitle(string title) {

        }
    }
}
