using SocietNet.BLL.Models;
using SocietNet.BLL.Services;
using SocietNet.PLL.Helpers;

namespace SocietNet.PLL.Views;

public class MessageIncomingView
{
    UserService userService;
    MessageService messageService;
    public MessageIncomingView(UserService userService, MessageService messageService)
    {
        this.userService = userService;
        this.messageService = messageService;
    }

    public void Display(User user)
    { 
        List<Message> messages = messageService.GetIncomingMessages(user);
        if (messages.Count == 0) { InYellow.WriteLine("No messages were recieved."); return; }
        foreach (Message message in messages)
        {
            User teller = userService.FindById(message.TellerId);
            Console.WriteLine($"From: {teller.Soap} ({teller.Frontname} {teller.Lastname})\n {message.Content}");
            InYellow.WriteLine("Reply? [y/n] ");
            if (Console.ReadKey(true).Key.ToString() == "Y") { Program.messageSendingView.Display(user, teller.Id); }
            Console.Write(Environment.NewLine);
        }
    }
}
