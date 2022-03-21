using System;
using System.Collections.Generic;
using System.Text;

namespace StorageSystem
{
    public class Storage
    {
        public List<Article> ArticleStock = new List<Article>();
        public void BookOut(decimal quantity, int articleNumber) {  }
        public void BookIn(decimal quantity, int articleNumber) { }
        public void CreateArticle(int articleNumber, string articleDescription, quantityUnit quantityUnit, decimal Price) 
        {
            Article article = new Article(articleNumber, articleDescription, quantityUnit, Price);
            ArticleStock.Add(article);
        }
        public void ChangePrice(int articleNumber, decimal newPrice) { }
        public void DeleteArticle(int articleNumber) { }
        public decimal GetAmountOfArticle(int articleNumber) { return 12; }
    }
}
