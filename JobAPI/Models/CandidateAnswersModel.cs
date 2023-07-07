using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class CandidateAnswersModel
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

        List<AllCandidateAnswersModel> Detail;
        public List<AllCandidateAnswersModel> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllCandidateAnswersModel
        {
            public string Question { get; set; }
            public string CorrectAnswer { get; set; }
            public string YourAnswer { get; set; }
            

        }
    }
}