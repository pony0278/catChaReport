//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace catChaWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Return_Reason_Data_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Return_Reason_Data_Table()
        {
            this.Shop_Return_Data_Table = new HashSet<Shop_Return_Data_Table>();
        }
    
        public int Return_Reason_ID { get; set; }
        public string Return_Reason { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Return_Data_Table> Shop_Return_Data_Table { get; set; }
    }
}
