using System.Linq;

namespace Lab_5_2.Models
{
    public interface IContactRepository
    {
        IQueryable<Contact> contacts { get; }
        void addIssue(int contactId, Issue issue);
    }
}