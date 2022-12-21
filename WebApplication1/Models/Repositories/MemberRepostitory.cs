using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.EFModels;
using WebApplication1.Models.Services;

namespace WebApplication1.Models.Repositories
{
    public class MemberRepostitory : IMemberRepository
    {
        private AppDbContext db = new AppDbContext();
        public void Create(MemberDTO memberDto)
        {
            Member member = new Member
            {
                Id = memberDto.Id,
                Name = memberDto.Name,
                Account = memberDto.Account,
                Password = memberDto.Password,
                CellPhone = memberDto.CellPhone,
            };
            db.Members.Add(member);
            db.SaveChanges();
        }
        //public List<Member> GetAll()
        //{
        //    return db.Members.ToList();
        //}
        //public Member FindByEmail(string email)
        //{
        //    return db.Members.FirstOrDefault(x => x.Email == email);
        //}
        //public Member FindById(int id)
        //{
        //    return db.Members.Find(id);
        //}
    }
}