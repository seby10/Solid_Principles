namespace Dependency_Inversion_Principle_Correct;

internal class Program
{
    static void Main(string[] args)
    {
        IMessageSender emailSender = new EmailSender();
        IMessageSender smsSender = new SMSSender();
        IMessageSender whtsappSender = new WhatsAppSender();

        NotificationService service1 = new(emailSender);
        service1.SendNotification("I appreciate your love towards me, but it's not mutual, Sorry!", "fc@gmail.com");

        NotificationService service2 = new(smsSender);
        service2.SendNotification("I need a new laptop!. Mine is slow as hell", "0983372092");
        
        NotificationService service3 = new(whtsappSender);
        service3.SendNotification("Good morning guys, let's have a meeting to discuss our progress", "John Pork");


    }
}
