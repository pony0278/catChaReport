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
    
    public partial class Shop_Common_Address_Data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Common_Address_Data()
        {
            this.Shop_Order_Total_Table = new HashSet<Shop_Order_Total_Table>();
        }
    
        public Nullable<int> Member_ID { get; set; }
        public int Address_ID { get; set; }
        public string Recipient_Name { get; set; }
        public string Recipient_Phone { get; set; }
        public string Recipient_Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Order_Total_Table> Shop_Order_Total_Table { get; set; }
        public virtual Shop_Member_Info Shop_Member_Info { get; set; }
    }
}
