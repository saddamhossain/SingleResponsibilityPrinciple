namespace SingleResponsibilityPrinciple;


#region Not following SRP
public interface IUserServiceWrongWay
{
    void Login(string userName, string password);

    void Register(string email, string userName, string phoneNumber, string password, string confirmPasword);

    void LogError(Exception exception, string errorMessage);

    void SendEmail(string emailAddress, string content);
}
#endregion


#region Following SRP
public interface IUserService
{
    void Login(string userName, string password);

    void Register(string email, string userName, string phoneNumber, string password, string confirmPasword);
}

public interface ILoggerService
{
    void Log(Exception exception, string errorMessage);
}

public interface IEmailService
{
    void Send(string emailAddress, string content);
}
#endregion


#region Following SRP
/*
This way, each interface focuses on a single responsibility.
One for login functionality and another for registration functionality.
This would provide a more granular separation of concerns, following the principle more strictly.

However, it's worth noting that the level of separation can vary based on the specific context and our design goals.
Sometimes, combining related behaviors into a single interface can be reasonable if they are closely related and likely to change for similar reasons.

Note: I didn't include ILoggerService and IEmailService as we understand that we also have these.
*/

public interface ILoginService
{
    void Login(string userName, string password);
}

public interface IRegistrationService
{
    void Register(string email, string userName, string phoneNumber, string password, string confirmPasword);
}
#endregion