using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class DepartmentModel
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

        List<AllDepartmentDetail> Detail;
        public List<AllDepartmentDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllDepartmentDetail
        {
            public string DepartmentID { get; set; }
            public string DepartmentName { get; set; }
        }
    }
}