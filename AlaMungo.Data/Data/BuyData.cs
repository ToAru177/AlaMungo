using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public class BuyData : EntityData<Buy>
    {
        public List<Buy> Search(string title, string writer, int? qualityId)
        {
            using (YesAlaMungoEntities context = DbContextFactory.Create())
            {
                var query = from x in context.UsedBooks
                            from y in context.Buys
                            from z in context.UsedBooks
                            select new
                            {
                                Quality = z,
                                Buy = y,
                                UsedBook = x,
                                BuyerId = y.Customer.LoginID,
                                BookTitle = x.MetaDataBook.Title,
                                BookWriter = x.MetaDataBook.Writer,
                                BookPrice = x.MetaDataBook.Price,
                                //BookQuality = z.Quality.Grade
                            };

                //if (string.IsNullOrEmpty(title) == false)
                //    query = query.Where(x => x.Buy.BookTitle.Contains(title));

                //if (string.IsNullOrEmpty(writer) == false)
                //    query = query.Where(x => x.Buy.BookWriter.Contains(writer));

                //if (qualityId.HasValue)
                //    query = query.Where(x => x.UsedBook.QualityID == qualityId);

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.Buy.BookTitle = item.BookTitle;
                   // item.Buy.BookWriter = item.BookWriter;
                    //item.Buy.BookQulity = item.BookQuality;
                    //item.Buy.BookPrice = item.BookPrice;
                    item.Buy.BuyerId = item.BuyerId;
                }

                return list.ConvertAll(x => x.Buy);
            }
        }
    }
}
