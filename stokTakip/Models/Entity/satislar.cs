//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stokTakip.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class satislar
    {
        public int satisId { get; set; }
        public Nullable<int> urunId { get; set; }
        public Nullable<int> musteriId { get; set; }
        public Nullable<byte> adet { get; set; }
        public Nullable<decimal> satisFiyat { get; set; }
    
        public virtual musteriler musteriler { get; set; }
        public virtual urunler urunler { get; set; }
    }
}