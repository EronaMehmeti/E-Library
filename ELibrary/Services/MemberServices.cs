using ELibrary.Models;
using ELibrary.Interface;
using ELibrary.ViewModel;

namespace ELibrary.Services
{
    public class MemberServices : IMemberServices
    {
        private readonly LibraryDbContext _context;

        public MemberServices(LibraryDbContext context)
        {
            _context = context;
        }

        public void Add(MemberViewModel member)
        {
            var _member = new Member()
            {
               Email = member.Email
            };
            _context.Members.Add(_member);
            _context.SaveChanges();
        }

        public List<Member> Get() => _context.Members.ToList();
   
    }
}
