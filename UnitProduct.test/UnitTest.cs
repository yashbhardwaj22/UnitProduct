using UnitProduct.Controllers;
using UnitProduct.Models;
using NUnit.Framework;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace UnitProduct.Test
{
    [TestFixture]
    public class UnitTesting
    {
        [Test]
        [TestCase("Premium")]
        [TestCase("Regular")]
        public void MyTesting(string customerCategory)
        {
            //Arrange
            ProductController product = new ProductController();
            int totalDiscount = 0;
            int actualTotalCost = 0;
            List<ArticleDetails> user = new List<ArticleDetails>
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
            };
            //Act
            foreach (var item in user)
            {
                if (customerCategory == "Premium")
                {
                    actualTotalCost = actualTotalCost + item.ArticleCost * 80 / 100;
                    totalDiscount = totalDiscount + item.ArticleCost * 20 / 100;
                }
                if (customerCategory == "Regular")
                {
                    actualTotalCost = actualTotalCost + item.ArticleCost * 90 / 100;
                    totalDiscount = totalDiscount + item.ArticleCost * 10 / 100;

                }
            }
            int totalCost = product.Sum(customerCategory, user, out totalDiscount);

            //Assert
            Assert.AreEqual(totalCost, actualTotalCost);
        }
    }
}
