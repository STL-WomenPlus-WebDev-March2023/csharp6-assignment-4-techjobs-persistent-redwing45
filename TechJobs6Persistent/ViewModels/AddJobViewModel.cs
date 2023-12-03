using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        //need a constructor?
        public AddJobViewModel(List<Employer> employers)
        {
            AllEmployers = new List<SelectListItem>();
        }

        [Required]
        public string Name { get; set; }
        public List<SelectListItem> AllEmployers { get; set; } = new List<SelectListItem>();

        public int EmployersId { get; set; }


        public AddJobViewModel()
        {
        }

    }



  
}
