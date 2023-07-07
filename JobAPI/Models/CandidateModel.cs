using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class CandidateModel
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

        List<AllCandidateDetail> Detail;
        public List<AllCandidateDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllCandidateDetail
        {
            public string CandidateID { get; set; }
            public string CandidateName { get; set; }
        }
    }
}