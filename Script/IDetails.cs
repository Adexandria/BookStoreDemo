using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Data
{
   public interface IDetails 
   {
        public Book.info.Details GetDetails(int id);
    }
}
