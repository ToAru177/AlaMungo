//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlaMungo.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsedBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsedBook()
        {
            this.Buys = new HashSet<Buy>();
            this.Sells = new HashSet<Sell>();
        }
    
        public int UsedBookID { get; set; }
        public int MetaDataID { get; set; }
        public string Quality { get; set; }
    
        public virtual MetaDataBook MetaDataBook { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy> Buys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sell> Sells { get; set; }
    }
}