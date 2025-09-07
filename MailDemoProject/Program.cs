using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

var message = new MimeMessage();

var from = new MailboxAddress("Cristian", "cristian.teodorescu97@gmail.com");
message.From.Add(from);
var to = new MailboxAddress("Alexandru", "cristian.teodorescu97@yahoo.com");
message.To.Add(to);
message.Subject = "Let's test MimeKit for a simple email demo.";
message.Body = new TextPart(TextFormat.Plain) 
{
    Text = """

    Hello Alexandru,

    Let's test the functionality of MimeKit library in a simple email!

    Thanks,
    Cristi
    """
};

using var smtp = new SmtpClient();
await smtp.ConnectAsync("localhost", 1025);
await smtp.SendAsync(message);
await smtp.DisconnectAsync(true);
Console.WriteLine("Mail sent!");