using System.Collections.Generic;
using System.Web.Mvc;

namespace Schoolmvc.Models
{
    public class CreateViewModel
    {
        public Request NewRequest { get; set; }
        public List<SelectListItem> StateId { get; set; }
    }
}