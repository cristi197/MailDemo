using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using MimeKit.Utils;

var message = new MimeMessage();

var from = new MailboxAddress("Cristian", "cristian.teodorescu97@gmail.com");
message.From.Add(from);
var to = new MailboxAddress("Alexandru", "cristian.teodorescu97@yahoo.com");
message.To.Add(to);
message.Subject = "Let's test MimeKit for a simple email demo.";
var bb = new BodyBuilder();

var imageEntity = bb.LinkedResources.Add("photo.jpeg");
imageEntity.ContentId = MimeUtils.GenerateMessageId();
var htmlBody = $"""
    <p>Hello, look at this picture</p>
    <img src="cid:{imageEntity.ContentId}" alt="A dummy photo"/>
    """;
bb.TextBody = "Hello world in plain text!";
bb.HtmlBody = htmlBody;
message.Body = bb.ToMessageBody();  

using var smtp = new SmtpClient();
await smtp.ConnectAsync("localhost", 1025);
await smtp.SendAsync(message);
await smtp.DisconnectAsync(true);
Console.WriteLine("Mail sent!");