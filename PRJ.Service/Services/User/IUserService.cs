using PRJ.Service.Services.User.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ.Service.Services.User
{
    public interface IUserService
    {
        public Task<OutputDTO<object>> GetAll();
        public Task<OutputDTO<bool>> Delete(long id, long loginId);
        public Task<OutputDTO<object>> Save(UserInputDTO dto, long loginId);
        public Task<OutputDTO<object>> Get(long id);
    }
}
