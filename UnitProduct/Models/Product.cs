using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitProduct.Models
{
    public class Product
    {
        public static IEnumerable<ArticleDetails> GetAllProduct()
        {
            return new List<ArticleDetails>
            {
                new ArticleDetails
                {
                   ArticleName="Computer",
                   ArticleCost=1000
                },
               new ArticleDetails
               {
                   ArticleName="Chair",
                   ArticleCost=500
               },
               new ArticleDetails
               {
                   ArticleName="Pencil",
                   ArticleCost=400
               },
               new ArticleDetails
               {
                   ArticleName="Books",
                   ArticleCost=550
               },
               new ArticleDetails
               {
                   ArticleName="Table",
                   ArticleCost=300
               },
               new ArticleDetails
               {
                   ArticleName="Fridge",
                   ArticleCost=450
               },
               new ArticleDetails
               {
                   ArticleName="Blackboard",
                   ArticleCost=900
               },
               new ArticleDetails
               {
                   ArticleName="Light",
                   ArticleCost=1000
               },
            };
        }
    }
}
