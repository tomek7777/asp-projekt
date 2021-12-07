using Lab_5_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5_2.Controllers
{
    public class ContactController : Controller
    {
        private ICRUDContactRepository repository;
        private IContactRepository contactRepository;

        public ContactController(ICRUDContactRepository repository, IContactRepository contactRepository)
        {
            this.repository = repository;
            this.contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            if (ModelState.IsValid)
            {
                return View("ConfirmContact", repository.Add(contact));
            }
            else
            {
                return View("AddForm");
            }
        }

        public IActionResult List()
        {
            return View(repository.FindAll());
        }

        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return View("List", repository.FindAll());
        }

        public IActionResult EditForm(int id)
        {
            return View(repository.FindById(id));
        }

        public IActionResult Edit(Contact contact)
        {
           repository.Update(contact);
           return View("List", repository.FindAll());  
        }


        public IActionResult Issue()
        {
            Issue issue = new Issue()
            {
                Title = "Test",
                Date = new DateTime()
            };
            contactRepository.addIssue(4, issue);
            return View("List", repository.FindAll());
        }
    }
}

