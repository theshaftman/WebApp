using System;
using System.Net;
using System.Net.Mail;
using KTConstruction.Model.Interfaces;

namespace KTConstruction.Model.Data
{
    public class MailModel : IMailModel
    {
        bool IMailModel.SendMail(string emailFrom, string emailContent)
        {
            emailFrom = emailFrom.Trim();
            emailContent = emailContent.Trim();
            bool status = false;
            try
            {
                if (!string.IsNullOrEmpty(emailFrom) &&
                    !string.IsNullOrEmpty(emailContent))
                {
                    MailMessage message = new MailMessage(Constant.USERNAME, Constant.MAIL_TO);
                    message.CC.Add(emailFrom);
                    message.Subject = "KT Construction: Contact Request Information";
                    message.IsBodyHtml = true;
                    message.Body = emailContent;

                    SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587);
                    mailer.Credentials = new NetworkCredential(Constant.USERNAME, Constant.PASSWORD);
                    mailer.EnableSsl = true;
                    mailer.Send(message);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                status = false;
            }
            return status;
        }
    }
}