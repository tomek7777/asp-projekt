using System.Linq;

namespace Lab_5_2.Models
{
    public class EFContactRepository:IContactRepository
    {
        private ApplicationDbContext _context;

        public EFContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Contact> contacts => _context.Contacts;

        public void addIssue(int contactId, Issue issue)
        {
            Contact contact = _context.Contacts.Find(contactId);
            contact.Issues.Add(issue);
            _context.Contacts.Update(contact);
            _context.SaveChanges();
        }
    }
}