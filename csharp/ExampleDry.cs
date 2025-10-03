public class EmailSender {
    public void SendEmail(string to, string subject, string body) {
        // Code to send email
    }
}

// Using the EmailSender class in multiple places
EmailSender emailSender = new EmailSender();
emailSender.SendEmail("user@example.com", "Subject 1", "Body 1");
emailSender.SendEmail("user2@example.com", "Subject 2", "Body 2");
