using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;
using Training.DTO;

namespace Training.API.Operations
{
    public class GetUserOrders
    {
        private readonly IUsersRepository _UsersRepository;

        public GetUserOrders(IUsersRepository usersRepository)
        {
            _UsersRepository = usersRepository;
        }

        public async Task<List<Order>> Execute(Guid id)
        {
            return await _UsersRepository.GetUserOrders(id);
        }
    }
}
