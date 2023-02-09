using ELibrary.Models;
using ELibrary.ViewModel;

namespace ELibrary.Interface
{
    public interface IMemberServices
    {
        public void Add(MemberViewModel member);

        public List<Member> Get();

       
    }
}
