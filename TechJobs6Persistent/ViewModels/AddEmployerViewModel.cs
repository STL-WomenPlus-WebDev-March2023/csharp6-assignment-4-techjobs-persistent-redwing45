using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location{ get; set; }
    }
}
