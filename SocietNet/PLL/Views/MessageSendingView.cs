using SocietNet.BLL.Models;
using SocietNet.BLL.Services;
using SocietNet.PLL.Helpers;
using SocietNet.BLL.Exceptions;

namespace SocietNet.PLL.Views;

public class MessageSendingView
{
    UserService userService;
    MessageService messageService;
    public MessageSendingView(UserService userService, MessageService messageService)
    {
        this.userService = userService;
        this.messageService = messageService;
    }

    public void Display(User user, int? listenerId = null)
    {
        while (true)
        {
            MessageForm messageForm = new MessageForm();
            messageForm.TellerId = user.Id;

            if (listenerId != null) { messageForm.ListenerId = (int)listenerId; }
            else
            {
                Console.Write("To (soap): ");
                try { messageForm.ListenerId = userService.FindBySoap(Console.ReadLine()).Id; }
                catch (UserNotFoundException) { InRed.WriteLine("No societ with such soap."); }
                catch (Exception ex) { Console.WriteLine("Something went awfully wrong. Please consult your shrink."); Console.WriteLine(ex.Message); }
            }

            Console.Write("Message (up to 5k symbols): ");
            messageForm.Content = Console.ReadLine();
            try { messageService.SendMessage(messageForm); InGreen.WriteLine("Message sent."); }
            catch (ArgumentNullException) { InRed.WriteLine("Too short."); }
            catch (ArgumentOutOfRangeException) { InRed.WriteLine("Too long."); }
            catch (Exception ex) { Console.WriteLine("Something went awfully wrong. Please consult your shrink."); Console.WriteLine(ex.Message); }

            if (!Repeater.Repeat()) { break; }
        }
    }
}
