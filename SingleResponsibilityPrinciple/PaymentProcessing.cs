namespace SingleResponsibilityPrinciple;

// We will separate payment processing into distinct components.

#region Not following SRP
public class PaymentProcessor
{
    public void ProcessPayment(decimal amount, PaymentInfo paymentInfo)
    {
        // Payment processing logic
    }
}
#endregion


#region Following SRP
public class PaymentGateway
{
    public void ProcessPayment(decimal amount, PaymentInfo paymentInfo)
    {
        // Payment processing logic using a payment gateway
    }
}

public class PaymentLogger
{
    public void LogPayment(decimal amount, PaymentInfo paymentInfo)
    {
        // Log payment details
    }
}
#endregion
