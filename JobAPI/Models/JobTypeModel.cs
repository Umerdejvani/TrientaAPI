using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class JobTypeModel
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

        List<AllJobTypeDetail> Detail;
        public List<AllJobTypeDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllJobTypeDetail
        {
            public string JobTypeID { get; set; }
            public string JobTypeName { get; set; }
        }
    }
}