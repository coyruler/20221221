using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models.EFModels;

namespace WebApplication1.Models.DTOs
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string CellPhone { get; set; }
    }
    public static class MemberExtentions
    {
        public static MemberDTO EntetyToDTO(this Member source)
        {
            return new MemberDTO
            {
                Id = source.Id,
                Name = source.Name,
                Account = source.Account,
                Password = source.Password,
                CellPhone = source.CellPhone,
            };
        }
    }
}