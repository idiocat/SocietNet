using SocietNet.DAL.Entities;
using System.Collections.Generic;

namespace SocietNet.DAL.Repos;

public class MessageRepo : BaseRepo, IMessageRepo
{
    public int Create(MessageEntity messageEntity) => Execute(@"insert into messages(content, teller_id, listener_id)
                                                                values(:content,:teller_id,:listener_id)", messageEntity);
    public IEnumerable<MessageEntity> FindByTellerId(int tellerId) => Query<MessageEntity>(@"select * from messages where teller_id = :teller_id",
                                                                                            new { teller_id = tellerId });
    public IEnumerable<MessageEntity> FindByListenerId(int listenerId) => Query<MessageEntity>(@"select * from messages where listener_id = :listener_id",
                                                                                                new { listener_id = listenerId });
    public int DeleteById(int messageId) => Execute(@"delete from messages where id = :id", new { id = messageId });
}

public interface IMessageRepo
{
    int Create(MessageEntity messageEntity);
    IEnumerable<MessageEntity> FindByTellerId(int tellerId);
    IEnumerable<MessageEntity> FindByListenerId(int listenerId);
    int DeleteById(int messageId);
}
