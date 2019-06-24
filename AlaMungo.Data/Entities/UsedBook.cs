using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    partial class UsedBook
    {
        public string BookTitle { get; set; }   // 책 제목
        public string BookWriter { get; set; }  // 저자
        public int BookPrice { get; set; }      // 가격
    }
}
