using FlashParking.Models;
using FlashParking.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace FlashParking.Controllers
{
    public class ParkingController : ApiController
    {
        private readonly ParkingProvider _parkingProvider;
        public ParkingController()
        {
            _parkingProvider = new ParkingProvider();
        }
        ///<summary>
        ///Gets deatils of a parking spot
        ///</summary>
        ///<returns></returns>
        //[Route("api/Parking/GetParkingSpotDetails")]
        //public IHttpActionResult GetParkingSpotDetails()
        //{
        //    return Ok(_parkingProvider.GetParkingSpotDetails());
        //}

        ///<summary>
        ///Removes car from a parking spot
        ///</summary>
        ///<param name="licenseNumber"></param>
        ///<returns></returns>
        //[Route("api/Parking/RemoveCar")]
        [HttpDelete]
        public ParkingSpot Delete(ParkingSpot parking)
        {
            var result = _parkingProvider.RemoveCarFromParkingSpot(parking.SpotId);
            return result;
        }
    }
}