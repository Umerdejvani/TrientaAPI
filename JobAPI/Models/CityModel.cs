using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class CityModel
    {
        String response;
        public String Response
        {
            get { return response; }
            set { response = value; }
        }

        String errorDescription;
        public String ErrorDescription
        {
            get { return errorDescription; }
            set { errorDescription = value; }
        }

        List<AllCityDetail> Detail;
        public List<AllCityDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllCityDetail
        {
            public string CityID { get; set; }
            public string CityName { get; set; }
        }
    }
}