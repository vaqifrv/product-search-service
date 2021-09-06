using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSearchService.Services
{
    public static class Helper
    {
        public static double CalculateDistanceByLatLong(double lat1, double long1, double lat2, double long2)
        {
            var R = 6371; // Radius of the earth in km
            var dLat = Deg2rad(lat2 - lat1);  // deg2rad below
            var dLon = Deg2rad(long2 - long1);
            var a =
              Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
              Math.Cos(Deg2rad(lat1)) * Math.Cos(Deg2rad(lat2)) *
              Math.Sin(dLon / 2) * Math.Sin(dLon / 2)
              ;
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c; // Distance in km
            return d;
        }

        private static double Deg2rad(double deg)
        {
            return deg * (Math.PI / 180);
        }
    }
}
