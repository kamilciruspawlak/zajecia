using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContactForm.Models;
using ContactForm.Service;
using ContactForm.Repository;
using ContactForm.Interface;
using ContactForm.Repository.Interfaces;

namespace ContactForm.Controllers
{
    public class ContactFormsController : Controller
    {
        private IEmailService _emailService;
        private IContactFormRepository _contactRepository;
        public ContactFormsController(IEmailService emailService, IContactFormRepository contactFormRepository)
        {
            _emailService = emailService;
            _contactRepository = contactFormRepository;
        }

       
        // GET: ContactForms
        public ActionResult Index()
        {
            return View(_contactRepository.GetWhere(x => x.Id>0));
        }

        // GET: ContactForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.ContactForm contactForm = _contactRepository.GetWhere(x=>x.Id==id.Value).FirstOrDefault();
            if (contactForm == null)
            {
                return HttpNotFound();
            }
            return View(contactForm);
        }

        // GET: ContactForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(  Models.ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.Create(contactForm);
                var message = _emailService.CreateMailMessae(contactForm);
                _emailService.SendEmail(message);
                return RedirectToAction("Index");
            }

            return View(contactForm);
        }


        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.ContactForm contactForm = _contactRepository.GetWhere(x => x.Id == id.Value).FirstOrDefault();
            if (contactForm == null)
            {
                return HttpNotFound();
            }
            return View(contactForm);
        }

        // POST: ContactForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Models.ContactForm contactForm = _contactRepository.GetWhere(x => x.Id == id).FirstOrDefault();
            _contactRepository.Delete(contactForm);
          
            return RedirectToAction("Index");
        }

       
    }
}
