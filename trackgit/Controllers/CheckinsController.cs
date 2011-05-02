using System.Web.Mvc;
using trackgit.Helpers;
using trackgit.Models;
using trackgit.ViewModels;

namespace trackgit.Controllers
{
    public class CheckinsController : BaseController
    {
        //
        // POST Checkins
        //
        [HttpPost]
        public ActionResult Index(int projectId, int userId, CheckInInfo checkInInfo)
        {
            Checkin checkin = CheckInHelper.SaveCheckIn(projectId, userId, checkInInfo);
            
            EmailHelper.SendEmail(checkin);

            return Json(new CheckInResponse("Checkin recorded, email sent"));
        }

        [HttpPost]
        public ActionResult Index(string payload)
        {
            Checkin checkin = CheckInHelper.SaveCheckIn(payload);

            EmailHelper.SendEmail(checkin);

            return Json(new CheckInResponse("Checkin recorded, email sent"));
        }
    }
}
