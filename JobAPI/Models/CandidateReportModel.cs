using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class CandidateReportModel
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

        List<AllCandidateReporDetail> Detail;
        public List<AllCandidateReporDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllCandidateReporDetail
        {
            public string Name { get; set; }
            public string DepartmentName { get; set; }
            public string JobType { get; set; }
            public string PositionName { get; set; }
            public string Contact { get; set; }
            public string CNIC { get; set; }
            public string Email { get; set; }
            public string City { get; set; }
            public string Experience { get; set; }
            public string RoundNo { get; set; }

        }
    }
}