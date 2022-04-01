using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using FlashParking.Models;
using FlashParking.Providers;

namespace FlashParking.Controllers
{
    public class CarController : ApiController
    {
        private readonly CarProvider _carProvider;
        public CarController()
        {
            _carProvider = new CarProvider();
        }
        ///<summary>
        ///Add Car To Parking
        ///</summary>
        ///<param name="newCar"></param>
        ///<returns></returns>
        [HttpPost]
        public IHttpActionResult Post([FromBody]CarModel newCar)
        {
            var result = _carProvider.AddCarToLocation(newCar);
            if(result != null)
            {                
                return Json(new { success = result });
            }
            return null;

        }
    }
}