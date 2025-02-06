using SocietNet.BLL.Models;
using SocietNet.BLL.Services;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class MessageOutcomingView
{
    UserService userService;
    MessageService messageService;
    public MessageOutcomingView(UserService userService, MessageService messageService)
    {
        this.userService = userService;
        this.messageService = messageService;
    }

    public void Display(User user)
    {
        List<Message> messages = messageService.GetOutcomingMessages(user);
        if (messages.Count == 0) { InYellow.WriteLine("No messages were sent."); return; }
        foreach (Message message in messages)
        {
            User listener = userService.FindById(message.ListenerId);
            Console.WriteLine($"To: {listener.Soap} ({listener.Frontname} {listener.Lastname})\n {message.Content}");
            Console.Write(Environment.NewLine);
            AnyKey.WaitFor();
        }
    }
}
