using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static FlashParking.Models.ParkingModel;

namespace FlashParking.Models
{
    public class LocationModel
    {
        public List<LocationDetail> Locations { get; set; }
        
        //public LocationModel()
        //{
        //    var parkingSpots = new ParkingAvailability() { CompactSpots = 10, RegularSpots = 20 };
        //    var parkingSpots2 = new ParkingAvailability() { CompactSpots = 1, RegularSpots = 20 };
        //    var parkingSpots3 = new ParkingAvailability() { CompactSpots = 10, RegularSpots = 1 };
        //    Locations = new List<LocationDetail>
        //    {
        //        new LocationDetail(){LocationName = "level1", SpotsAvailable = parkingSpots},
        //        new LocationDetail(){LocationName = "level2", SpotsAvailable = parkingSpots2},
        //        new LocationDetail(){LocationName = "level3", SpotsAvailable = parkingSpots3}
        //    };
        //}
    }
    
    
    public class LocationDetail
    {
        public string LocationName { get; set; }
        public List<ParkingSpot> ParkingSpots { get; set; }
        public ParkingAvailability SpotsAvailable { get; set; }
    }
}