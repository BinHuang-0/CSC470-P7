using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7
{
    public interface IFeatureRepository
    {
        string Add(Feature feature);
        List<Feature> GetAll(int ProjectId);
        string Remove(Feature feature);
        string Modify(Feature feature);
        Feature GetFeatureById(int featureId);
        Feature GetFeatureByTitle(string title);

    }
}
