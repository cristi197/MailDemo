# MailDemo

# 📧 MailDemo with MimeKit & MailKit

This is a simple **.NET demo project** that demonstrates how to send an email using  
[MimeKit](https://github.com/jstedfast/MimeKit) and [MailKit](https://github.com/jstedfast/MailKit) libraries.  
It uses [Mailpit](https://github.com/axllent/mailpit) as a local SMTP server for testing.

---

## 🚀 Features
- Create and send a plain-text email
- Configure sender and recipient addresses
- Connect to a local SMTP server (Mailpit on port `1025`)
- Log success message to console after sending

---

## 🛠 Requirements
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Mailpit](https://github.com/axllent/mailpit) running locally

---

## ▶️ Running the Project

1. **Clone the repository**
   ```bash
   git clone https://github.com/<your-username>/MailDemo.git
   cd MailDemo

2. **Run Mailpit (via Docker)**
   ```bash
   docker run -d -p 1025:1025 -p 8025:8025 axllent/mailpit
3. **Run the demo**
   ```bash
   dotnet run
