namespace SingleResponsibilityPrinciple;

// In a user authentication system, we can separate authentication logic from user management logic.

#region Not following SRP
public class AuthenticationManagerWrongWay
{
    public void AuthenticateUser(string username, string password)
    {
        // Authentication logic
    }

    public void CreateUser(string username, string password)
    {
        // User creation logic
    }
}
#endregion


#region Following SRP
public class AuthenticationManager
{
    public void AuthenticateUser(string username, string password)
    {
        // Authentication logic
    }
}

public class UserManager
{
    public void CreateUser(string username, string password)
    {
        // User creation logic
    }
}
#endregion