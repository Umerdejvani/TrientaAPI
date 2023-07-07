using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.StatusModel;

namespace JobAPI.Controllers
{
    public class GetStatusListController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public StatusModel GetStatusList()
        {
            StatusModel rply = new StatusModel();
            try
            {
                List<AllStatusDetail> lst = new List<AllStatusDetail>();


                lst.Add(new AllStatusDetail
                {
                    StatusName = "Not Attempt",
                });

                lst.Add(new AllStatusDetail
                {
                    StatusName = "Pass",
                });

                lst.Add(new AllStatusDetail
                {
                    StatusName = "Fail",
                });


                rply.Response = "success";
                rply.ErrorDescription = "";
                rply.detail = lst;


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
