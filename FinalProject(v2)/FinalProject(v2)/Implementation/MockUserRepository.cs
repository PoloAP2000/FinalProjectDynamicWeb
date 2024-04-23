using FinalProject_v2_.Interface;
using FinalProject_v2_.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_v2_.Implementation
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers => new List<User>
        {
            new User { Id = 123456, Username="user123", Password = "P@ssw0rd1", Email= "user123@example.com"},
            new User { Id = 789012, Username="john_doe", Password = "securePass!23", Email= "john.doe@email.com"},
            new User { Id = 345678, Username = "cool_guy92", Password = "MyP@ssw0rd!", Email = "cool.guy92@gmail.com"},
            new User { Id = 901234, Username = "awesome_user", Password = "Awesome123@", Email = "awesome_user@domain.com"}
        };

        User? IUserRepository.GetUserById(int userid)
        {
            return AllUsers.FirstOrDefault(p => p.Id == userid);
        }
    }
}
