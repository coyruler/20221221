using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Models.Services
{
    public class MemberService
    {
        private IMemberRepository repository;
        public MemberService(IMemberRepository repo)
        {
            this.repository = repo;
        }

        public void Create(MemberCreateDTO dto)
        {
            // todo 驗證account是否唯一

            // 建立記錄
            repository.Create(dto);
        }
    }
}