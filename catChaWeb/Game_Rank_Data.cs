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
    
    public partial class Game_Rank_Data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game_Rank_Data()
        {
            this.Shop_Member_Info = new HashSet<Shop_Member_Info>();
        }
    
        public int Rank_ID { get; set; }
        public string Rank_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Member_Info> Shop_Member_Info { get; set; }
    }
}
