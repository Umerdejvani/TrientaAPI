using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.CandidateAnswersModel;

namespace JobAPI.Controllers
{
    public class GetReportCandidateAnswersController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public CandidateAnswersModel GetReportCandidateAnswers(string CandidateID)
        {
            CandidateAnswersModel rply = new CandidateAnswersModel();
            try
            {
                long? _ISnull = null;

                long? _CandidateID = CandidateID == "null" ? _ISnull : long.Parse(CandidateID);
               

                List<AllCandidateAnswersModel> lst = new List<AllCandidateAnswersModel>();

                var query = dx.sp_ViewQuestionBank(_CandidateID).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllCandidateAnswersModel
                        {
                            Question = x.Question,
                            CorrectAnswer = x.CorrectAnswer,
                            YourAnswer = x.YourAnswer,
                        });

                    }

                    rply.Response = "success";
                    rply.ErrorDescription = "";
                    rply.detail = lst;
                }
                else
                {
                    rply.Response = "failure";
                    rply.ErrorDescription = "No Record Found";
                }

                return rply;

            }
            catch (Exception ex)
            {
                rply.Response = "failure";
                rply.ErrorDescription = ex.Message;
                return rply;

            }

        }
    }
}
