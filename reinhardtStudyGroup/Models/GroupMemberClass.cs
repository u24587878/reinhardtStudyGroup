using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace reinhardtStudyGroup.Models
{
    public class GroupMemberClass
    {
        [Display(Name = "STUDENT NUMBER")]
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string FirstName { get; set; }

        [Display(Name = "SURNAME")]
        public string LastName { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string EmailAddress { get; set; }

    }
}