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
    
    public partial class Shop_Game_Admin_Data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Game_Admin_Data()
        {
            this.Game_Shop_Blog_Data = new HashSet<Game_Shop_Blog_Data>();
            this.Game_ShopAnnouncement = new HashSet<Game_ShopAnnouncement>();
            this.Shop_Reply_Data = new HashSet<Shop_Reply_Data>();
        }
    
        public int Admin_ID { get; set; }
        public string Admin_Username { get; set; }
        public string Admin_Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Shop_Blog_Data> Game_Shop_Blog_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_ShopAnnouncement> Game_ShopAnnouncement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Reply_Data> Shop_Reply_Data { get; set; }
    }
}
