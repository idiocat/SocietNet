using SocietNet.BLL.Exceptions;
using SocietNet.BLL.Models;
using SocietNet.DAL.Entities;
using SocietNet.DAL.Repos;

namespace SocietNet.BLL.Services;

public class FiendService
{
    IFiendRepo fiendRepo;
    IUserRepo userRepo;
    public FiendService()
    {
        fiendRepo = new FiendRepo();
        userRepo = new UserRepo();
    }

    public void AddFiend(FiendApplication fiendApplication)
    {
        if (userRepo.FindById(fiendApplication.UserId) == null) { throw new UserNotFoundException("It seems you don't exist."); }
        UserEntity fiend = userRepo.FindBySoap(fiendApplication.FiendSoap);
        if (fiend == null) { throw new UserNotFoundException("Can't befiend nobody."); }
        FiendEntity fiendEntity = new FiendEntity()
        {
            user_id = fiendApplication.UserId,
            fiend_id = fiend.id
        };
        fiendRepo.Create(fiendEntity);
    }

    public void RemoveFiend(User user, User fiend)
    {
        fiendRepo.Delete((from f in fiendRepo.FindAllByUserId(user.Id) where f.fiend_id == fiend.Id select f).ToList()[0].id);
    }

    public List<Fiend>? GetFiendsList(User user) => fiendRepo.FindAllByUserId(user.Id).Select(f => new Fiend(f.id, f.user_id, f.fiend_id)).ToList();
}
