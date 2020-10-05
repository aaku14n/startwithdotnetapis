using System;

namespace ProductsAPI
{
    public class Product
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public String Brand { get; set; }
        public String Category { get; set; }
        public Int16 Quantity { get; set; }
        public Boolean Status { get; set; }

    }
}