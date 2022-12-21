using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.EFModels;

namespace WebApplication1.Models.Services
{
    public class RegisterRepository : IRegisterRepository
    {
        private AppDbContext db = new AppDbContext();
        public void Create(RegisterDTO registerDto)
        {
            Register register = new Register
            {
                Id = registerDto.Id,
                Name= registerDto.Name,
                Email=registerDto.Email,
                CreateTime= DateTime.Now,
            };
            db.Registers.Add(register);
            db.SaveChanges();
        }
        public List<Register> GetAll()
        {
            return db.Registers.ToList();
        }
        public Register FindByEmail(string email)
        {
            return db.Registers.FirstOrDefault(x => x.Email == email);
        }
        public Register FindById(int id)
        {
            return db.Registers.Find(id);
        }

    }
}