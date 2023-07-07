using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.PositionModel;

namespace JobAPI.Controllers
{
    public class GetPositionListController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public PositionModel GetPositionList()
        {
            PositionModel rply = new PositionModel();
            try
            {
                List<AllPositionDetail> lst = new List<AllPositionDetail>();

                var query = (from a in dx.tbl_positions select a).OrderBy(x => x.Name).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllPositionDetail
                        {
                            PositionID = x.ID.ToString(),
                            PositionName = x.Name
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
