using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class PositionModel
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

        List<AllPositionDetail> Detail;
        public List<AllPositionDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllPositionDetail
        {
            public string PositionID { get; set; }
            public string PositionName { get; set; }
        }
    }
}