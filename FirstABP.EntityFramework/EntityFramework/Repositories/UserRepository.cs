using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;

namespace FirstABP.EntityFramework.Repositories
{
    public class UserRepository : FirstABPRepositoryBase<Core.Entities.User>, Core.Repositories.IUserRepository
    {
        public UserRepository(IDbContextProvider<FirstABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public IQueryable<Core.Entities.User> GetUser(string UserName)
        {
            return Context.User.Where(m => m.UserName == UserName);
        }

        public async Task<List<Core.Entities.User>> GetAllUserAsync(string UserName)
        {
            return await Context.User.Where(m => m.UserName == UserName).ToListAsync();
        }
    }
}
