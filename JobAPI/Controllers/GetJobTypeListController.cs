using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.JobTypeModel;

namespace JobAPI.Controllers
{
    public class GetJobTypeListController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public JobTypeModel GetJobTypeList()
        {
            JobTypeModel rply = new JobTypeModel();
            try
            {
                List<AllJobTypeDetail> lst = new List<AllJobTypeDetail>();

                var query = (from a in dx.tbl_jobtype select a).OrderBy(x => x.Name).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllJobTypeDetail
                        {
                            JobTypeID = x.ID.ToString(),
                            JobTypeName = x.Name
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
