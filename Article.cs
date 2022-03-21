using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystem
{
    public class Article
    {
        public int ArticleNumber { get; set;}
        public string ArticleDescription { get; set; }
        public decimal Price { get; set; }
        public decimal StorageQuantity { get; set; }
        public quantityUnit quantityUnit { get; set; }
        public Article()
        {

        }
        public Article(int articleNumber, string articleDescription, quantityUnit QuantityUnit, decimal price)
        {
            this.ArticleNumber = articleNumber;
            this.ArticleDescription = articleDescription;
            this.Price = price;
            this.quantityUnit = QuantityUnit;
        }
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
