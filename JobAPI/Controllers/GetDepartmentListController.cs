using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.DepartmentModel;

namespace JobAPI.Controllers
{
    public class GetDepartmentListController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public DepartmentModel GetDepartmentList()
        {
            DepartmentModel rply = new DepartmentModel();
            try
            {
                List<AllDepartmentDetail> lst = new List<AllDepartmentDetail>();

                var query = (from a in dx.tbl_department select a).OrderBy(x => x.Name).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllDepartmentDetail
                        {
                            DepartmentID = x.ID.ToString(),
                            DepartmentName = x.Name
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
