using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobAPI.Models
{
    public class QuestionBankModel
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

        List<AllQuestionBankDetail> Detail;
        public List<AllQuestionBankDetail> detail
        {
            get { return Detail; }
            set { Detail = value; }
        }

        public class AllQuestionBankDetail
        {
            public string PositionName { get; set; }
            public string JobType { get; set; }

            public string Question { get; set; }
            public string OptionA { get; set; }
            public string OptionB { get; set; }
            public string OptionC { get; set; }
            public string OptionD { get; set; }
            public string CorrectAnswer { get; set; }
        }
    }
}