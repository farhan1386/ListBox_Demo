using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ListBox_Demo.Models
{
    public class Language
    {
        public List<SelectListItem> ProgrammingSkill { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "HTML" },
            new SelectListItem { Value = "2", Text = "CSS" },
            new SelectListItem { Value = "3", Text = "Bootstrap"  },
            new SelectListItem { Value = "4", Text = "JavaScript"  },
            new SelectListItem { Value = "5", Text = "JQuery"  },
            new SelectListItem { Value = "6", Text = "Angular"  },
            new SelectListItem { Value = "7", Text = "C#" },
            new SelectListItem { Value = "8", Text = "ASP.Net MVC" },
            new SelectListItem { Value = "9", Text = "ASP.Net Core"  },
            new SelectListItem { Value = "10", Text = "Entity Framework"  },
            new SelectListItem { Value = "11", Text = "Identity"  },
            new SelectListItem { Value = "12", Text = "LINQ"  },
            new SelectListItem { Value = "13", Text = "SQL Server"  },
        };
    }
}
