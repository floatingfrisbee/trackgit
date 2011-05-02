using System.Linq;
using trackgit.Models;
using trackgit.ViewModels;

namespace trackgit.Helpers
{
    public class CheckInHelper
    {
        internal static Checkin SaveCheckIn(int projectId, int userId, CheckInInfo checkInInfo)
        {
            var context = new trackgitentitycontext();

            var checkIn = new Checkin
                              {
                                  Project = context.Projects.First(p => p.Id == projectId),
                                  User = context.Users.First(u => u.Id == userId),
                                  Comment = checkInInfo.Comment
                              };

            context.AddToCheckins(checkIn);

            context.SaveChanges();

            return checkIn;
        }

        internal static Checkin SaveCheckIn(string payload)
        {
            throw new System.NotImplementedException();
        }
    }
}