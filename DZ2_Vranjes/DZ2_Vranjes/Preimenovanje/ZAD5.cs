using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Vranjes
{
    internal class ZAD5
    {
        public class DataLocation
        {
            public DateTime CreatedAt { get; private set; }
            public double Latitude { get; private set; }
            public double Longitude { get; private set; }

            public DataLocation(double latitude, double longitude)
            {
                CreatedAt = DateTime.Now;
                Latitude = latitude;
                Longitude = longitude;
            }
        }

        public class PathManaging
        {
            private List<DataLocation> locations;

            public PathManaging()
            {
                locations = new List<DataLocation>();
            }

            public void AddNewLocation(DataLocation location)
            {
                locations.Add(location);
            }

            public void RemoveLocation(DataLocation location)
            {
                locations.Remove(location);
            }
        }
    }
}
