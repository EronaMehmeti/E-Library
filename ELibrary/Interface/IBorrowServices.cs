
using ELibrary.Models;
using ELibrary.ViewModel;

namespace ELibrary.Interface

{
    public interface IBorrowServices
    {

        public void Add(BorrowViewModel borrow); 
        public List<Borrow> Get();
        public Borrow GetById(int borrowId);
        public  Borrow UpdatebyId(int borrowId, BorrowViewModel borrow);
        public void Delete(int id);
       
    }
}

