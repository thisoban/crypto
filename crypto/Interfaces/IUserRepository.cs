using crypto.Entities;

namespace crypto.Interfaces
{
    public interface IUserRepository
    {
        //update
        void UpdateUser(User user);
        //create
        void CreateUser(User user);
        //get
        User  GetUser(User user);
        //getall

    }
}
