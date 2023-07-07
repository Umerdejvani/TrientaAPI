using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class RoundWiseModel
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

        List<AllRoundWiseDetail> Detail;
        public List<AllRoundWiseDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllRoundWiseDetail
        {
            public string RoundNo { get; set; }
            public string DepartmentName { get; set; }
            public string Position { get; set; }
            public string CandidateName { get; set; }
            public string RoundStatus { get; set; }

        }
    }
}