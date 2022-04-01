using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using FlashParking.Models;
using static FlashParking.Models.ParkingModel;

namespace FlashParking.Providers
{
    public class LocationProvider
    {
        //Returns the parking spot availability based on location name
        public ParkingAvailability GetLocationAvailability(string locationName)
        {
            var locationDetails = new ParkingModel();
            try
            {
                if (locationDetails != null)
                {
                    var result = locationDetails.ParkingSpotDetails.Where(x => x.IsAvailable && x.LocationName == locationName);
                    if (result != null && result.Count() > 0)
                    {
                        int compact = result.Where(x => x.IsCompact).Count();
                        int regular = result.Where(x => x.IsRegular).Count();

                        var parkingSpots = new ParkingAvailability() { CompactSpots = compact, RegularSpots = regular, TotalSpots = compact+regular };

                        return parkingSpots;
                    }
                    return null;

                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException($"Unable to get parking details for location {locationName}", ex);
            }
        }

    }
}