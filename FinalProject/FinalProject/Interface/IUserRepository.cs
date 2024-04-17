using FinalProject.Models;

namespace FinalProject.Interface
{
    public interface IUserRepository
    {
        public IEnumerable<User> AllUsers {  get; }

        User? GetUserById(int userid);
    }
}
