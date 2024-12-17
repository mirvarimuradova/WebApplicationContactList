using WebApplicationContactList.Models;

namespace WebApplicationContactList.Repository
{
    public class ContactRepository
    {
        private List<Contact> Contacts = new List<Contact>()
        {


            new Contact(){ID=1,Name="Mirvari", Surname = "Muradova", Email="mirvarimuradova&@gmail.com",Phone="+994 55 777 88 99"},
            new Contact(){ID=2,Name="Zehra", Surname="Malikzade", Email="zarallo@gmail.com", Phone="+994 50 432 66 77"},
            new Contact{ID=3,Name="Roya", Surname ="Abbasova", Email="roya@gmail.com", Phone = "+994 70 555 767 88"},
            new Contact(){ID=4,Name = "Kainat", Surname="Muradova", Email="kmuradova@gmail.com", Phone="+994 77 555 44 33"}
        };

        public void AddContact(string name, string surname, string email , string phone)
        {
            Contact contact = new Contact();
            contact.Name = name;
            contact.Surname = surname;
            contact.Email = email;
            contact.Phone = phone;
            Contacts.Add(contact);
        }
         public List<Contact> GetContact()
        {

            return Contacts;
        }
       
        public Contact GetById(int id)
        {


            return this.Contacts.FirstOrDefault(c => c.ID == id);
        }


    }
}
