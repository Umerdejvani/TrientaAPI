using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.RoundWiseModel;

namespace JobAPI.Controllers
{
    public class GetReportRoundWiseController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public RoundWiseModel GetReportRoundWise(string CandidateID, string Status, string Round)
        {
            RoundWiseModel rply = new RoundWiseModel();
            try
            {
                long? _ISnull = null;

                long? _CandidateID = CandidateID == "null" ? _ISnull : long.Parse(CandidateID);
                long? _Round = Round == "null" ? _ISnull : long.Parse(Round);
                string _Status = Status == "null" ? null : Status;

                List<AllRoundWiseDetail> lst = new List<AllRoundWiseDetail>();

                var query = dx.sp_ReportRoundWise(_CandidateID, _Status, _Round, null, null).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllRoundWiseDetail
                        {
                            CandidateName = x.CandidateName,
                            DepartmentName = x.DepartmentName,
                            Position = x.Position,
                            RoundNo = "RoundNo "+ x.RoundNo.ToString(),
                            RoundStatus = x.RoundStatus
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
