using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.QuestionBankModel;

namespace JobAPI.Controllers
{
    public class GetReportQuestionBankController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public QuestionBankModel GetReportQuestionBank(string PositionID, string JobTypeID)
        {
            QuestionBankModel rply = new QuestionBankModel();
            try
            {
                long? _ISnull = null;

                long? _PositionID = PositionID == "null" ? _ISnull : long.Parse(PositionID);
                long? _JobTypeID = JobTypeID == "null" ? _ISnull : long.Parse(JobTypeID);



                List<AllQuestionBankDetail> lst = new List<AllQuestionBankDetail>();

                var query = dx.sp_ReportQuestionBank(_PositionID, _JobTypeID).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllQuestionBankDetail
                        {
                            PositionName = x.PositionName,
                            JobType = x.JobType,
                            Question = x.Question,
                            OptionA = x.OptionA,
                            OptionB = x.OptionB,
                            OptionC = x.OptionC,
                            OptionD = x.OptionD,
                            CorrectAnswer = x.CorrectAnswer
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
