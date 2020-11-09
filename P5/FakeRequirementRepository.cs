﻿using System;
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

        public static List<Requirement> requirements;

        FakeRequirementRepository() {

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
