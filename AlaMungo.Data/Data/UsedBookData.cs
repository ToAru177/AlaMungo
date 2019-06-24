using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public class UsedBookData :EntityData<UsedBook>
    {
        public List<UsedBook> Search(string title, string writer, string quality)
        {
            using (YesAlaMungoEntities context = DbContextFactory.Create())
            {
                var query = from x in context.UsedBooks
                            select new
                            {
                                UsedBook = x,
                                BookTitle = x.MetaDataBook.Title,
                                BookWriter = x.MetaDataBook.Writer,
                                BookPrice = x.MetaDataBook.Price,
                            };

                if (string.IsNullOrEmpty(title) == false)
                    query = query.Where(x => x.UsedBook.BookTitle.Contains(title));

                if (string.IsNullOrEmpty(writer) == false)
                    query = query.Where(x => x.UsedBook.BookWriter.Contains(writer));

                if (string.IsNullOrEmpty(quality) == false)
                    query = query.Where(x => x.UsedBook.Quality.Contains(quality));

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.UsedBook.BookTitle = item.BookTitle;
                    item.UsedBook.BookWriter = item.BookWriter;
                    item.UsedBook.BookPrice = item.BookPrice;
                    
                }

                return list.ConvertAll(x => x.UsedBook);
            }
        }
    }
}
