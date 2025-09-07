using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

var message = new MimeMessage();

var from = new MailboxAddress("Cristian", "cristian.teodorescu97@gmail.com");
message.From.Add(from);
var to = new MailboxAddress("Alexandru", "cristian.teodorescu97@yahoo.com");
message.To.Add(to);
message.Subject = "Let's test MimeKit for a simple email demo.";
var bb = new BodyBuilder();
bb.TextBody = "Hello world in plain text!";
bb.HtmlBody = "<p>Hello world <em>in HTML!</em></p>";
bb.Attachments.Add("test.jpeg");
message.Body = bb.ToMessageBody();  

using var smtp = new SmtpClient();
await smtp.ConnectAsync("localhost", 1025);
await smtp.SendAsync(message);
await smtp.DisconnectAsync(true);
Console.WriteLine("Mail sent!");