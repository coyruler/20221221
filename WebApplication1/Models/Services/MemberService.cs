using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Services
{
    public class MemberService
    {
        public MemberService(IMemberRepository repo)
        {
            this.repository = repo;
        }
        public void Create(MemberCreateDTO dto)
        {
            repository.Create(dto);
        }
    }
}