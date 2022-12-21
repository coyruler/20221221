using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.EFModels;
using WebApplication1.Models.Services;

namespace WebApplication1.Services
{
    public class RegisterService
    {
        private IRegisterRepository repository;
        public RegisterService(IRegisterRepository repo)
        {
            repository = repo;
        }
        public void Create(Register register) {
            var dataIndb = repository.FindByEmail(register.Email);
            if (dataIndb != null)
            {
                throw new Exception("這個Email已經報名過了");
            }
            register.CreateTime = DateTime.Now;

            repository.Create(register);
        }
        public Register Find(int id)
        {
            Register register = repository.FindById(id);
            if(register != null)
            {
                throw new Exception("找不到指定紀錄");
            }
            return register;
        }
    }
}