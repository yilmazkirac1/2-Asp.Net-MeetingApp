using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            int saat=DateTime.Now.Hour;     
            ViewData["Selamlama"]=saat > 12 ? "Iyi Gunler":"Gunadin";    
            int UserCount=Repository.Users.Where(i=>i.WillAttend==true).Count();

            //ViewData["UserName"]="Yilmaz";
            var meetingInfo = new MeetingInfo(){
                Id=1,
                Location="Istanbul",
                Date=new DateTime(2024,01,20,20,0,0),
                NumberOfPeople=UserCount
            };
            return View(meetingInfo);
        }        
    }
}