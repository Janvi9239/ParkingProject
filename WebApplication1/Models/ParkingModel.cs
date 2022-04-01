using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashParking.Models
{
    public class ParkingModel
    {
        public List<ParkingSpot> ParkingSpotDetails;
        public ParkingModel()
        {
            ParkingSpotDetails = new List<ParkingSpot>()
            {
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level1"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level1"},
                new ParkingSpot(){SpotId = "AUS1234", IsAvailable = false, IsCompact = false, IsRegular = true, LocationName = "level1"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level1"},
                new ParkingSpot(){IsAvailable = true, IsCompact = true, IsRegular = false, LocationName = "level1"},
                new ParkingSpot(){IsAvailable = true, IsCompact = true, IsRegular = false, LocationName = "level2"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level2"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level2"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level2"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level2"},
                new ParkingSpot(){IsAvailable = true, IsCompact = true, IsRegular = false, LocationName = "level3"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level3"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level3"},
                new ParkingSpot(){IsAvailable = true, IsCompact = false, IsRegular = true, LocationName = "level3"},
                new ParkingSpot(){IsAvailable = true, IsCompact = true, IsRegular = false, LocationName = "level3"}
            };
        }
    }
    public class ParkingSpot
    {
        public string SpotId { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsCompact { get; set; }
        public bool IsRegular { get; set; }
        public string LocationName { get; set; }
    }
    public class ParkingAvailability
    {
        public int CompactSpots { get; set; }
        public int RegularSpots { get; set; }
        public int TotalSpots { get; set; }
    }
    
}