using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace WhatShouldWeEat.Common.Helpers
{
    public class MailHelper
    {
        public static bool SendMail(string body, string to, string subject, bool isHtml = true)
        {
            return SendMail(body, new List<string> { to }, subject, isHtml);
        }

        public static bool SendMail(string body, List<string> to, string subject, bool isHtml = true)
        {
            bool result = false;

            try
            {
                var message = new MailMessage();
                message.From = new MailAddress("entegre95@gmail.com");

                to.ForEach(x =>
                {
                    message.To.Add(new MailAddress(x));
                });

                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = isHtml;

                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials =
                        new NetworkCredential("entegre95@gmail.com","3rs1n1995128Ed");

                    smtp.Send(message);
                    result = true;
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return result;
        }
    }
}
