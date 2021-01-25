using sb_admin_2.Web.Models.DTO;
using sb_admin_2.Web.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sb_admin_2.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MissionandVission()
        {
            return View();
        }

        public ActionResult CoreValues()
        {
            return View();
        }

        public ActionResult UniversityCalendar()
        {
            return View();
        }

        public ActionResult UniversityHymn()
        {
            return View();
        }

        public ActionResult SanBartolome()
        {
            return View();
        }

        public ActionResult Batasan()
        {
            return View();
        }

        public ActionResult SanFrancisco()
        {
            return View();
        }

        public ActionResult TranscriptOfRecord()
        {
            return View();
        }

        public ActionResult DownloadableForms()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }


        public JsonResult GetEvents()
        {
            using (RegistrationEntities dc = new RegistrationEntities())
            {
                var events = dc.Calendars.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        [HttpPost]
        public JsonResult SaveEvent(Calendar e)
        {
            var status = false;
            using (RegistrationEntities dc = new RegistrationEntities())
            {
                if (e.EventID > 0)
                {
                    //Update the event
                    var v = dc.Calendars.Where(a => a.EventID == e.EventID).FirstOrDefault();
                    if (v != null)
                    {
                        v.Subject = e.Subject;
                        v.Start = e.Start;
                        v.End = e.End;
                        v.Description = e.Description;
                        v.IsFullDay = e.IsFullDay;
                        v.ThemeColor = e.ThemeColor;
                    }
                }
                else
                {
                    dc.Calendars.Add(e);
                }

                dc.SaveChanges();
                status = true;

            }
            return new JsonResult { Data = new { status = status } };
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;
            using (RegistrationEntities dc = new RegistrationEntities())
            {
                var v = dc.Calendars.Where(a => a.EventID == eventID).FirstOrDefault();
                if (v != null)
                {
                    dc.Calendars.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }

        [HttpPost]
        public JsonResult AjaxMethod()
        {
            RegistrationEntities entities = new RegistrationEntities();
            List<Member> members = (from account in entities.Members
                                      select account).ToList();
            return Json(members);
        }

        DataTableRepository dataTBrepository = new DataTableRepository();
        public ActionResult getRecords(string category, string keyword)
        {
            List<RecordDTO> records = dataTBrepository.records(category, keyword);
            return Json(new { data = records });
        }







    }
}