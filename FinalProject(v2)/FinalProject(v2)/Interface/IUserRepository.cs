using FinalProject_v2_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_v2_.Interface
{
    public interface IUserRepository
    {
        public IEnumerable<User> AllUsers {  get; }
        User? GetUserById(int userid);
    }
}
