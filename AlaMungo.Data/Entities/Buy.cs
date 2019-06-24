using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    partial class Buy
    {
        public string Title { get; set; }
        public string BuyerId { get; set; }   // 구매자 ID
        public string BookTitle { get; set; }   // 책 제목
        public string BookWriter { get; set; }  // 저자
        public string BookQulity { get; set; }  // 품질
        public int BookPrice { get; set; }      // 가격
    }
}
