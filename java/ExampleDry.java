public class EmailSender {
    public void sendEmail(String to, String subject, String body) {
        // Code to send email
    }
}

// Using the EmailSender class in multiple places
EmailSender emailSender = new EmailSender();
emailSender.sendEmail("user@example.com", "Subject 1", "Body 1");
emailSender.sendEmail("user2@example.com", "Subject 2", "Body 2");
