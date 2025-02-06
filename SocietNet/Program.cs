using SocietNet.BLL.Services;
using SocietNet.PLL.Views;

namespace SocietNet;
/// <summary>
/// yes, it's a play on english word "society" and russian word "сосед"
/// </summary>
public class Program
{
    public static UserService userService = new UserService();
    public static MessageService messageService = new MessageService();
    public static FiendService fiendService = new FiendService();

    public static MainView mainView = new MainView();
    public static RegistrationView registrationView = new RegistrationView(userService);
    public static AuthenticationView authenticationView = new AuthenticationView(userService);
    public static UserMenuView userMenuView = new UserMenuView();
    public static UserInfoView userInfoView = new UserInfoView();
    public static UserUpdateView userUpdateView = new UserUpdateView();
    public static MessageSendingView messageSendingView = new MessageSendingView(userService, messageService);
    public static MessageOutcomingView messageOutcomingView = new MessageOutcomingView(userService, messageService);
    public static MessageIncomingView messageIncomingView = new MessageIncomingView(userService, messageService);
    public static FiendViewingView fiendViewingView = new FiendViewingView(fiendService, userService);
    public static FiendDetailedView fiendDetailedView = new FiendDetailedView(userService);
    public static FiendAddingView fiendAddingView = new FiendAddingView(userService, fiendService);
    public static FiendRemovingView fiendRemovingView = new FiendRemovingView(fiendService);

    static void Main() { mainView.Display(); }
}