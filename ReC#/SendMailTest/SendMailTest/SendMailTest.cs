using System.Net;
using System.Net.Mail;

class SendMailTest
{
    static void Main(string[] args)
    {
        SmtpClient smtpServer = new SmtpClient("smtp.live.com");
        var mail = new MailMessage();
        //[1]보내는 이메일 넣는 곳
        mail.From = new MailAddress("");
    }
}