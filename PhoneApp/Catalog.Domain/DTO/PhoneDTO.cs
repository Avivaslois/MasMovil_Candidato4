using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure.DTO
{
    public class PhoneDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public Decimal Price { get; set; }
        public string ImgUrl { get; set; }
    }
}
