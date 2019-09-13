using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.API.Operations
{
    public class GetUsers
    {
        private readonly IUsersRepository _UsersRepository;

        public GetUsers(IUsersRepository usersRepository)
        {
            _UsersRepository = usersRepository;
        }

        public async Task<List<DTO.User>> Execute()
        {
            return await _UsersRepository.GetAll();
        }

    }
}
