using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace AlaMungo.Data
{
    public class BuyData : EntityData<Buy>
    {

        public List<Buy> Search(string title,DateTime? fromDate,DateTime? ToDate)
        {
            using (YesAlaMungoEntities context = new YesAlaMungoEntities())
            {


                /*
                 * 구매버튼을 눌렀을 경우
                 * 구매 동시에                *
                 */
                //var query = from x in context.Buys
                //    where x.UsedBooks
                //    select x;

                //var productsInCategory = db.Categorys
                //    .Where(c => c.CategoryId == categoryId)
                //    .SelectMany(c => c.Products);


                //var products = (from p in db.Product_Category
                //    join ProductTable pt on p.ID = pt.ProductID
                //join Category c on c.ID = P.CategoryID
                //select new
                //{
                //    p.ID,
                //    p.Name,
                //    p.Description,
                //    p.Price
                //}).ToList();


                //buy 에서 title 과 customerId만 빼오면되는데.
                var query = from x in context.Buys
                    join y in context.UsedBooks on x.BuyID equals y.UsedBookID
                    select new
                    {
                        Buy = x,
                        Title = y.MetaDataBook.Title
                    };

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.Buy.Title = item.Title;
                }


               
                //var list =context.UsedBooks.SelectMany (x => x.Buys);
                // list.Where(x=>x.)

               // var query = from VAR in  
               

                return list.ConvertAll(x=>x.Buy);

            }
        }

        public List<Buy> Search(string title, string writer, string quality)
        {
            using (YesAlaMungoEntities context = DbContextFactory.Create())
            {
                var query = from x in context.UsedBooks
                            from y in context.Buys
                            select new
                            {
                                Buy = y,
                                UsedBook = x,
                                BuyerId = y.Customer.LoginID,
                                BookTitle = x.MetaDataBook.Title,
                                BookWriter = x.MetaDataBook.Writer,
                                BookPrice = x.MetaDataBook.Price,
                                BookQuality = x.Quality
                            };

                if (string.IsNullOrEmpty(title) == false)
                    query = query.Where(x => x.Buy.BookTitle.Contains(title));

                if (string.IsNullOrEmpty(writer) == false)
                    query = query.Where(x => x.Buy.BookWriter.Contains(writer));

                if (string.IsNullOrEmpty(quality) == false)
                    query = query.Where(x => x.Buy.BookQulity.Contains(quality));

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.Buy.BookTitle = item.BookTitle;
                    item.Buy.BookWriter = item.BookWriter;
                    item.Buy.BookQulity = item.BookQuality;
                    item.Buy.BookPrice = item.BookPrice;
                    item.Buy.BuyerId = item.BuyerId;
                }

                return list.ConvertAll(x => x.Buy);
            }
        }
    }
}
