//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KitchensWithZest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Photo
    {
        public int PhotoId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> GalleryId { get; set; }
        [DisplayName("Photo")]
        public string PhotoPath { get; set; }
        [NotMapped]
        public IEnumerable<HttpPostedFileBase> PhotoFiles { get; set; }

        public virtual Gallery Gallery { get; set; }
        public virtual Product Product { get; set; }
    }
}
