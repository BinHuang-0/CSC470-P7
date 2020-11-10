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
        public static int currentId = 1;

        public static List<Feature> features = new List<Feature>();

        public FakeFeatureRepository() {

        }
        public string Add(Feature feature) {
            string error;
            if(feature.Title == "") {
                error = EMPTY_TITLE_ERROR;
            }
            else if(features.Where(x => x.Title.CompareTo(feature.Title) == 0).Count() != 0) {
                error = DUPLICATE_TITLE_ERROR;
            }
            else {
                features.Add(feature);
                currentId++;
                error = NO_ERROR;
            }
            return error;
        }
        public List<Feature> GetAll(int ProjectId) {
            return features.Where(x=>x.ProjectId == ProjectId).ToList();
        }
        public string Remove(Feature feature) {
            features.RemoveAll(x => x.Id == feature.Id);
            return NO_ERROR;
        }
        public string Modify(Feature feature) {
            string error;
            if (feature.Title == "") {
                error = EMPTY_TITLE_ERROR;
            }
            else if(features.Where(x => x.Title.CompareTo(feature.Title) == 0).Count() != 0){
                error = DUPLICATE_TITLE_ERROR;
            }
            else {
                error = NO_ERROR;
                features[features.FindIndex(x => x.Id == feature.Id)].Title = feature.Title;
            }
            return error;
        }
        public Feature GetFeatureById(int featureId) {
            return features.Find(x => x.Id == featureId);
        }
        public Feature GetFeatureByTitle(string title) {
            return features.Find(x => x.Title == title);
        }
    }
}
