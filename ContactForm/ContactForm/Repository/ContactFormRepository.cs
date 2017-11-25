using ContactForm.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactForm.Repository
{
    public class ContactFormRepository : AbstractRepository<Models.ContactForm>, IContactFormRepository
    {
    }
}