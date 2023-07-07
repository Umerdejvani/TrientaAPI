using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class StatusModel
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

        List<AllStatusDetail> Detail;
        public List<AllStatusDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllStatusDetail
        {
            public string StatusName { get; set; }
        }
    }
}