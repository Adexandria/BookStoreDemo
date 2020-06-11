using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books.Data
{
  public  class SqlData :IData
    {
        private readonly AppDbContext app;
        public SqlData(AppDbContext app)
        {
            app = this.app;
        }
        public Book.info.Books Add(Book.info.Books added)
        {
            app.Add(added);
            return added;





        }

        public int Commit()
        {
            return app.SaveChanges();
        }

        public Book.info.Books Delete(int id)
        {
            var query = GetId(id);
            if (query != null)
            {
                app.Book.Remove(query);
            }
            return query;
        }

        public IEnumerable<Book.info.Books> GetAllData()
        {
            return app.Book.OrderBy(r => r.Name);
        }

        public int GetCount()
        {
            return app.Book.Count();
        }

        public IEnumerable<Book.info.Books> GetData(string name)
        {
            var query = from a in app.Book
                        where string.IsNullOrWhiteSpace(name) || a.Name.StartsWith(name)
                        orderby a.Name
                        select a;
            return query;
        }

        public Book.info.Books GetId(int id)
        {
            return app.Book.Find(id);
        }

        public Book.info.Books Update(Book.info.Books update)
        {
            var query = app.Book.Attach(update);
            query.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return update;
        }
    }
}

