using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reinhardtStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<Models.GroupMemberClass> people = new List<Models.GroupMemberClass>();

            people.Add(new Models.GroupMemberClass { StudentNumber = "u24587878", FirstName = "Reinhardt", 
                LastName = "Coetzee", EmailAddress = "u24587878@gmail.com"});

            people.Add(new Models.GroupMemberClass
            {
                StudentNumber = "u22499475",
                FirstName = "Reece",
                LastName = "Wenhold",
                EmailAddress = "u22499475@gmail.com"
            });

            people.Add(new Models.GroupMemberClass
            {
                StudentNumber = "u24711919",
                FirstName = "Regardt",
                LastName = "van Heerden",
                EmailAddress = "u24711919@gmail.com"
            });

            people.Add(new Models.GroupMemberClass
            {
                StudentNumber = "u23658772",
                FirstName = "Xander",
                LastName = "Visagie",
                EmailAddress = "u23658772@gmail.com"
            });

            people.Add(new Models.GroupMemberClass
            {
                StudentNumber = "u24664929",
                FirstName = "Arno",
                LastName = "Smalberger",
                EmailAddress = "u24664929@gmail.com"
            });

            return View(people);
        }
    }
}