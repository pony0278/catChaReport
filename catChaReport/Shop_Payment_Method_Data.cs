//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace catChaReport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Payment_Method_Data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Payment_Method_Data()
        {
            this.Shop_Order_Total_Table = new HashSet<Shop_Order_Total_Table>();
        }
    
        public int Payment_Method_ID { get; set; }
        public string Payment_Method_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Order_Total_Table> Shop_Order_Total_Table { get; set; }
    }
}
