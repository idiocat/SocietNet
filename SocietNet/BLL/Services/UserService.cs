using System.ComponentModel.DataAnnotations;
using SocietNet.BLL.Models;
using SocietNet.DAL.Repos;
using SocietNet.DAL.Entities;
using SocietNet.BLL.Exceptions;

namespace SocietNet.BLL.Services;

public class UserService
{
    IUserRepo userRepo;
    public UserService() { userRepo = new UserRepo(); }

    public void Register(UserRegistrationData userRegistrationData)
    {
        if (string.IsNullOrEmpty(userRegistrationData.Frontname)) { throw new ArgumentNullException("You forgot to enter frontname."); }
        if (string.IsNullOrEmpty(userRegistrationData.Lastname)) { throw new ArgumentNullException("You forgot to enter lastname."); }
        if (userRegistrationData.Cussword.Length < 12) { throw new ArgumentNullException("Your cussword should be at least 12 symbols."); }
        if (!new EmailAddressAttribute().IsValid(userRegistrationData.Soap)) { throw new ArgumentNullException("Your soap is dry."); }
        if (userRepo.FindBySoap(userRegistrationData.Soap) != null) { throw new ArgumentNullException("Your soap is used."); }

        UserEntity userEntity = new UserEntity()
        {
            frontname = userRegistrationData.Frontname,
            lastname = userRegistrationData.Lastname,
            cussword = userRegistrationData.Cussword,
            soap = userRegistrationData.Soap
        };
        if (userRepo.Create(userEntity) == 0) { throw new MemberAccessException("Account wasn't created."); }
    }

    public User Authenticate(UserAuthenticationData userAuthenticationData)
    {
        UserEntity findUserEntity = userRepo.FindBySoap(userAuthenticationData.Soap);
        if (findUserEntity is null) { throw new UserNotFoundException(); }
        if (findUserEntity.cussword != userAuthenticationData.Cussword) { throw new WrongCusswordException(); }
        return ConstructUserModel(findUserEntity);
    }

    public User FindBySoap(string soap)
    {
        UserEntity findUserEntity = userRepo.FindBySoap(soap);
        if (findUserEntity is null) { throw new UserNotFoundException(); }
        return ConstructUserModel(findUserEntity);
    }

    public void Update(User user)
    {
        UserEntity updatableUserEntity = new UserEntity()
        {
            id = user.Id,
            frontname = user.Frontname,
            lastname = user.Lastname,
            cussword = user.Cussword,
            soap = user.Soap,
            pic = user.Pic,
            fav_mkv = user.FavMkv,
            fav_epub = user.FavEpub
        };
        if (userRepo.Update(updatableUserEntity) == 0) { throw new ApplicationException(); }
    }

    public User ConstructUserModel(UserEntity userEntity) => new User(userEntity.id,
                                                                    userEntity.frontname, 
                                                                    userEntity.lastname, 
                                                                    userEntity.cussword, 
                                                                    userEntity.soap, 
                                                                    userEntity.pic, 
                                                                    userEntity.fav_mkv, 
                                                                    userEntity.fav_epub);
}
