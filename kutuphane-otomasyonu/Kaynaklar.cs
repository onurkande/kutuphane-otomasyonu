//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kutuphane_otomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kaynaklar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kaynaklar()
        {
            this.Kayitlar = new HashSet<Kayitlar>();
        }
    
        public int kaynak_id { get; set; }
        public string kaynak_ad { get; set; }
        public string kaynak_yazar { get; set; }
        public string kaynak_yayinci { get; set; }
        public Nullable<int> kaynak_sayfa_sayisi { get; set; }
        public Nullable<System.DateTime> kaynak_basim_tarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayitlar> Kayitlar { get; set; }
    }
}
