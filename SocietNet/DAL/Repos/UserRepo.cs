using SocietNet.DAL.Entities;
using System.Collections.Generic;

namespace SocietNet.DAL.Repos;

public class UserRepo : BaseRepo, IUserRepo
{
    public int Create(UserEntity userEntity) => Execute(@"insert into users(frontname, lastname, cussword, soap)
                                                        values(:frontname,:lastname,:cussword,:soap)", userEntity);
    public IEnumerable<UserEntity> FindAll() => Query<UserEntity>(@"select * from users");
    public UserEntity FindBySoap(string soap) => QueryFirstOrDefault<UserEntity>(@"select * from users where soap = :soap_p", new { soap_p = soap });
    public UserEntity FindById(int id) => QueryFirstOrDefault<UserEntity>(@"select * from users where id = :id_p", new { id_p = id });
    public int Update(UserEntity userEntity) => Execute(@"update users set frontname = :frontname, lastname = :lastname, cussword = :cussword,
                                                        soap = :soap, pic = :pic, fav_mkv = :fav_mkv, fav_epub = :fav_epub
                                                        where id = :id", userEntity);
    public int DeleteById(int id) => Execute(@"delete from users where id = :id_p", new { id_p = id });
}

public interface IUserRepo
{
    int Create(UserEntity userEntity);
    UserEntity FindBySoap(string soap);
    IEnumerable<UserEntity> FindAll();
    UserEntity FindById(int id);
    int Update(UserEntity userEntity);
    int DeleteById(int id);
}
