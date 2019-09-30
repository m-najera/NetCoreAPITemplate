using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.API.Contracts;
using Training.Data.Extensions;
using Training.DTO;

namespace Training.Data.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly StoreContext _StoreContext;

        public UsersRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }

        public async Task<List<Order>> GetUserOrders(Guid Id)
        {
            var user = await _StoreContext.Users.Include(u => u.Orders).SingleOrDefaultAsync(u => u.Id == Id);
            return user.Orders.Select( x => x.ToDTO()).ToList();
        }

        public async Task<List<DTO.User>> GetAll()
        {
            var users = await _StoreContext.Users.ToListAsync();
            var usersDTOList = users.Select(x => x.ToDTO()).ToList();
            return usersDTOList;
        }


    }
}
