using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Modules
{
    public class CityDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointOfInterests
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

        public ICollection<PoinstOfInterestDto> PointsOfInterest { get; set; }
        = new List<PoinstOfInterestDto>(); // C#6 feature

    }
}
