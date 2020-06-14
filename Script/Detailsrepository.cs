using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Data
{
   public class Detailsrepository : IDetails
    {
        private readonly AppDbContext app;

        public Detailsrepository(AppDbContext app)
        {
            this.app = app;
        }
        public Book.info.Details GetDetails(int id)
        {
            return app.Details.Find(id);
        }
    }
}
