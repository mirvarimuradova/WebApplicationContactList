using Microsoft.AspNetCore.Mvc;
using WebApplicationContactList.Repository;

namespace WebApplicationContactList.Controllers
{
    public class ContactController : Controller
    {
        ContactRepository contactRepository = new ContactRepository();
        public IActionResult Index()
        {
          
                
            return View(contactRepository.GetContact());
        }

        public IActionResult Details(int id) {


            return View(contactRepository.GetById(id));

        }

        [HttpPost]
        public IActionResult AddContact(string name, string surname, string email, string phone)
        {
           
            contactRepository.AddContact(name, surname, email, phone);
            return View();
        }
    }
}
