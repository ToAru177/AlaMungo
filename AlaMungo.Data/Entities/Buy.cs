using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    partial class Buy
    {
        public string BuyerId { get; set; }   // 구매자 ID
        public string BookTitle { get; set; }   // 책 제목
        public string Writer { get; set; }  // 저자
        public string Qulity { get; set; }  // 품질
        public int Price { get; set; }      // 가격
    }
}
