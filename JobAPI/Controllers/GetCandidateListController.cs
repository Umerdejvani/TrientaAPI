using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.CandidateModel;

namespace JobAPI.Controllers
{
    public class GetCandidateListController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public CandidateModel GetCandidateList()
        {
            CandidateModel rply = new CandidateModel();
            try
            {
                List<AllCandidateDetail> lst = new List<AllCandidateDetail>();

                var query = (from a in dx.tbl_Candidate select a).OrderBy(x => x.Name).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllCandidateDetail
                        {
                            CandidateID = x.ID.ToString(),
                            CandidateName = x.Name
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
