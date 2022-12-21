using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models.EFModels;

namespace WebApplication1.Models.DTOs
{
    public class MemberCreateDTO
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string CellPhone { get; set; }
    }
}