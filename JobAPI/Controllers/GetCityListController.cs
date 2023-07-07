using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.CityModel;

namespace JobAPI.Controllers
{
    public class GetCityListController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public CityModel GetCityList()
        {
            CityModel rply = new CityModel();
            try
            {
                List<AllCityDetail> lst = new List<AllCityDetail>();

                var query = (from a in dx.tbl_City
                             select a).OrderBy(x => x.City).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllCityDetail
                        {
                            CityID = x.ID.ToString(),
                            CityName = x.City
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
