using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using FlashParking.Models;
using FlashParking.Providers;

namespace FlashParking.Controllers
{
    public class LocationController : ApiController
    {
        private readonly LocationProvider _locationProvider;
        public LocationController()
        {
            _locationProvider = new LocationProvider();
        }

        ///<summary>
        ///Get cars based on location
        ///</summary>
        ///<param name="location"></param>
        ///<returns></returns>
        [Route("api/Location/GetAvailabilityAtLocation")]
        public IHttpActionResult GetAvailabilityAtLocation([FromUri]string location)
        {
            return Ok(_locationProvider.GetLocationAvailability(location));
        }
    }
}