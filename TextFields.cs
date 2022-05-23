using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Client
{
    public partial class TextFields
    {
        public Guid Id { get; set; }
        public string ShortDesc { get; set; }
        public int Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Avaliable { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public DateTime DateAdded { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string CodeWord { get; set; }
        public string Name { get; set; }
        public string LongDesc { get; set; }
    }
}
