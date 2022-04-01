using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashParking.Models
{
    public class CarModel
    {
        public string LicenseNumber { get; set; }
        public bool IsCompact { get; set; }
        public string LocationName { get; set; }
    }
}