using SocietNet.BLL.Models;
using SocietNet.DAL.Entities;
using SocietNet.DAL.Repos;

namespace SocietNet.BLL.Services;

public class MessageService
{
    IMessageRepo messageRepo;
    public MessageService() { messageRepo = new MessageRepo(); }

    public void SendMessage(MessageForm messageForm)
    {
        if (string.IsNullOrEmpty(messageForm.Content)) { throw new ArgumentNullException(); }
        if (messageForm.Content.Length > 5120) { throw new ArgumentOutOfRangeException(); }
        MessageEntity messageEntity = new MessageEntity() { teller_id = messageForm.TellerId, listener_id = messageForm.ListenerId, content = messageForm.Content };
        messageRepo.Create(messageEntity);
    }
}
