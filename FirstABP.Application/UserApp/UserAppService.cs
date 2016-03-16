using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.UserApp
{
    public class UserAppService : IUserAppService
    {
        private readonly Core.Repositories.IUserRepository _userRepository;

        public UserAppService(Core.Repositories.IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IQueryable<Dto.UserOutput> GetUser(string UserName)
        {
            return _userRepository.GetUser(UserName).Select(m => new Dto.UserOutput() { UserName = m.UserName, IsEnabled = m.IsEnabled });
        }
    }
}
