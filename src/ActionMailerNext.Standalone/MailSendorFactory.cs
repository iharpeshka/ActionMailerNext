﻿using ActionMailerNext.Implementations.Mandrill;
using ActionMailerNext.Implementations.SendGrid;
using ActionMailerNext.Implementations.SMTP;
using ActionMailerNext.Interfaces;

namespace ActionMailerNext.Standalone
{
    internal static class MailSendorFactory
    {
        public static IMailSender GetSender(MailMethod method = MailMethod.Smtp)
        {
            switch (method)
            {
                case MailMethod.Smtp:
                {
                    return new SmtpMailSender();
                }
                case MailMethod.Mandrill:
                {
                    return new MandrillMailSender();
                }
                case MailMethod.SendGrid:
                {
                    return new SendGridMailSender();
                }
                default:
                {
                    return null;
                }
            }
        }

        public static IMailAttributes GetAttributes(MailMethod method = MailMethod.Smtp)
        {
            switch (method)
            {
                case MailMethod.Smtp:
                {
                    return new SmtpMailAttributes();
                }
                case MailMethod.Mandrill:
                {
                    return new MandrillMailAttributes();
                }
                case MailMethod.SendGrid:
                {
                    return new SendGridMailAttributes();
                }
                default:
                {
                    return null;
                }
            }
        }
    }
}