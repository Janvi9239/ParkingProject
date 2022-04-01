using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlashParking.Models;

namespace FlashParking.Providers
{
    public class CarProvider
    {
        private readonly LocationProvider _locationProvider;
        public CarProvider()
        {
            _locationProvider = new LocationProvider();
        }

        //Adding car to a location based on size and updating parking spot id with license number
        public ParkingSpot AddCarToLocation(CarModel car)
        {
            var locationDetails = _locationProvider.GetLocationAvailability(car.LocationName);
            var spotDetails = new ParkingModel();
            //checking there is no car already parked with same number
            var isSpotFilled = spotDetails.ParkingSpotDetails.Where(x => x.SpotId == car.LicenseNumber).Count() > 0;
            if (locationDetails != null && locationDetails.TotalSpots > 0 && !isSpotFilled)
            {
                if (car.IsCompact && locationDetails.CompactSpots > 0)
                {
                    var spot = spotDetails.ParkingSpotDetails.FirstOrDefault(x => x.IsCompact && x.LocationName == car.LocationName);
                    spot.IsAvailable = false;
                    spot.SpotId = car.LicenseNumber;
                    return spot;
                }
                else if (car.IsCompact && locationDetails.RegularSpots > 0)
                {
                    var spot = spotDetails.ParkingSpotDetails.FirstOrDefault(x => x.IsRegular && x.LocationName == car.LocationName);
                    spot.IsAvailable = false;
                    spot.SpotId = car.LicenseNumber;
                    return spot;
                }
                else if (!car.IsCompact && locationDetails.RegularSpots > 0)
                {
                    var spot = spotDetails.ParkingSpotDetails.FirstOrDefault(x => x.IsRegular && x.LocationName == car.LocationName);
                    spot.IsAvailable = false;
                    spot.SpotId = car.LicenseNumber;
                    return spot;
                }
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}