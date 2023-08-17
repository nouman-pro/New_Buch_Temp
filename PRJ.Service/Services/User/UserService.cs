using PRJ.Service.Services.User.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRJ.DataAccess.Entities;

namespace PRJ.Service.Services.User
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _repo;

        public UserService(UnitOfWork repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public Task<OutputDTO<bool>> Delete(long id, long loginId)
        {
            throw new NotImplementedException();
        }

        public async Task<OutputDTO<object>> Get(long id)
        {
            var getUser = await _repo.UserRepo.Get(id);

            throw new NotImplementedException();
        }

        public async Task<OutputDTO<object>> GetAll()
        {
            var getUser = await _repo.UserRepo.GetAll();
            throw new NotImplementedException(); 
        }

        public async Task<OutputDTO<object>> Save(UserInputDTO dto, long loginId)
        {
            try
            {
                if (dto.Id == 0)
                {
                    var Prefix = "BUH" + Convert.ToString(1).PadLeft(6, '0');

                    //User
                    var mapper = _mapper.Map<PRJ.DataAccess.Entities.User>(dto);
                    mapper.CreatedDate = DateTime.UtcNow;
                    mapper.Pin = Prefix;
                    await _repo.UserRepo.Add(mapper);
                    await _repo.Save();

                }
                else if (dto.Id > 0)
                {
                    var updateUser= await _repo.UserRepo.Get(x => x.Id == dto.Id);
                    var mapper = _mapper.Map<UserInputDTO, PRJ.DataAccess.Entities.User>(dto, updateUser);
                    mapper.CreatedDate = DateTime.UtcNow;
                    await _repo.UserRepo.Update(mapper);
                    await _repo.Save();

                }

                throw new NotImplementedException();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
