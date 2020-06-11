using System;
using Book.info;
using System.Collections.Generic;
using System.Text;

namespace Books.Data
{
  public  interface IData 
    {
        IEnumerable<Book.info.Books> GetAllData();
        IEnumerable<Book.info.Books> GetData(string name);
        public Book.info.Books GetId(int id);
        Book.info.Books Update(Book.info.Books update);
        Book.info.Books Delete(int id);
        Book.info.Books Add(Book.info.Books added);
        int GetCount();
        int Commit();
    }
}
