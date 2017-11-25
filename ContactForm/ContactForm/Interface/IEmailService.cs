using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ContactForm.Interface
{
    public interface IEmailService
    {
        MailMessage CreateMailMessae(Models.ContactForm model);
        void SendEmail(MailMessage message);
    }
}
