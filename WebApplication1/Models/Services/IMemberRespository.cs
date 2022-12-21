using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.EFModels;

namespace WebApplication1.Models.Services
{
    public class IMemberRepository
    {
        void Create(MemberDTO memberDto);        
        //Member FindByEmail(string email);
        //Member FindById(int id);
        //List<Member> GetAll();

    }
}