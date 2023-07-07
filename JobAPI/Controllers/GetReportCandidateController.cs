using JobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static JobAPI.Models.CandidateReportModel;

namespace JobAPI.Controllers
{
    public class GetReportCandidateController : ApiController
    {
        FYP_TEST_DBEntities dx = new FYP_TEST_DBEntities();

        public CandidateReportModel GetReportCandidate(string _Name, string _Contact, string _CNIC, string _Email, string _Experience, string _CityID, string _PositionID, string _JobTypeID, string _DeptID)
        {
            CandidateReportModel rply = new CandidateReportModel();
            try
            {
                long? _ISnull = null;


                string Name = _Name == "null" ? null : _Name;
                string Contact = _Contact == "null" ? null : _Contact;
                string CNIC = _CNIC == "null" ? null : _CNIC;
                string Email = _Email == "null" ? null : _Email;

                long? Experience = _Experience == "null" ? _ISnull : long.Parse(_Experience);
                long? CityID = _CityID == "null" ? _ISnull : long.Parse(_CityID);
                long? PositionID = _PositionID == "null" ? _ISnull : long.Parse(_PositionID);
                long? JobTypeID = _JobTypeID == "null" ? _ISnull : long.Parse(_JobTypeID);
                long? DeptID = _DeptID == "null" ? _ISnull : long.Parse(_DeptID);


                List<AllCandidateReporDetail> lst = new List<AllCandidateReporDetail>();

                var query = (dx.sp_CandidateDetail(Name, Contact, CNIC, Email, Experience, CityID, PositionID, JobTypeID, DeptID)).ToList();
                if (query.ToList().Count > 0)
                {
                    foreach (var x in query)
                    {
                        lst.Add(new AllCandidateReporDetail
                        {
                            City = x.City,
                            CNIC = x.CNIC,
                            Contact = x.Contact,
                            DepartmentName = x.DepartmentName,
                            Email = x.Email,
                            Experience = x.Experience.Value.ToString(),
                            JobType = x.JobType,
                            Name = x.Name,
                            PositionName = x.PositionName,
                            RoundNo = x.RoundNo.Value.ToString()
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
