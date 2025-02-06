using SocietNet.BLL.Services;
using SocietNet.PLL.Views;

namespace SocietNet;
/// <summary>
/// yes, it's a play on english word "society" and russin word "сосед"
/// </summary>
class Program
{
    public static UserService userService = new UserService();
    public static MessageService messageService = new MessageService();

    public static MainView mainView = new MainView();
    public static RegistrationView registrationView = new RegistrationView(userService);
    public static AuthenticationView authenticationView = new AuthenticationView(userService);
    public static UserMenuView userMenuView = new UserMenuView();
    public static UserInfoView userInfoView = new UserInfoView();
    public static UserUpdateView userUpdateView = new UserUpdateView();
    public static MessageSendingView messageSendingView = new MessageSendingView(userService, messageService);
    public static MessageOutcomingView messageOutcomingView = new MessageOutcomingView(userService, messageService);
    public static MessageIncomingView messageIncomingView = new MessageIncomingView(userService, messageService);

    static void Main() { mainView.Display(); }
}