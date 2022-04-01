using FlashParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashParking.Providers
{
    public class ParkingProvider
    {
        public IEnumerable<ParkingSpot> GetParkingSpotDetails()
        {
            var parkingDetails = new ParkingModel();
            try
            {
                if (parkingDetails != null)
                {
                    var result = parkingDetails.ParkingSpotDetails.Where(x => x.IsAvailable);
                    if (result != null)
                    {
                        return result;
                    }
                    return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Unable to get parking spot details", ex);
            }
        }

        public ParkingSpot RemoveCarFromParkingSpot(string licenseNumber)
        {
            var parkingDetails = new ParkingModel();
            try
            {
                if(parkingDetails != null)
                {
                    //if there's a match by removing we make the parking spot available and make spotId null
                    var result = parkingDetails.ParkingSpotDetails.FirstOrDefault(x => x.SpotId == licenseNumber);
                    if (result != null)
                    {
                        result.IsAvailable = true;
                        result.SpotId = null;
                    }
                    return result;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException("Error occured while deleting the car", ex);
            }
        }
    }
}