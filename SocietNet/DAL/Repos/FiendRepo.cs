using SocietNet.DAL.Entities;
using System.Collections.Generic;

namespace SocietNet.DAL.Repos;

public class FiendRepo : BaseRepo, IFiendRepo
{
    public int Create(FiendEntity fiendEntity) => Execute(@"insert into fiends (user_id, fiend_id)
                                                            values(:user_id,:fiend_id)", fiendEntity);
    public IEnumerable<FiendEntity> FindAllByUserId(int userId) => Query<FiendEntity>(@"select * from fiends where user_id = :user_id",
                                                                            new { user_id = userId });
    public int Delete(int id) => Execute(@"delete from fiends where id = :id_p", new { id_p = id });
}

public interface IFiendRepo
{
    int Create(FiendEntity fiendEntity);
    IEnumerable<FiendEntity> FindAllByUserId(int userId);
    int Delete(int id);
}
