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
    
    public partial class Game_Product_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game_Product_Category()
        {
            this.Game_Product_Total = new HashSet<Game_Product_Total>();
        }
    
        public int Product_Category_ID { get; set; }
        public string Category_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Product_Total> Game_Product_Total { get; set; }
    }
}
