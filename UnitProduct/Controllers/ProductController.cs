using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitProduct.Models;

namespace UnitProduct.Controllers
{
    public class ProductController : Controller
    {

        private static List<ArticleDetails> shoppingCart = new List<ArticleDetails>();

        public IActionResult Index()
        {
            return View(Product.GetAllProduct());
        }
        public IActionResult AddProduct(string articleName, int articleCost)
        {
            shoppingCart.Add(new ArticleDetails
            {
                ArticleName = articleName,
                ArticleCost = articleCost
            });
            return RedirectToAction("Index");
        }
        public IActionResult Calculate(int totalPrice,int totalDiscount)
        {
            List<ArticleDetails> user = new List<ArticleDetails>(shoppingCart);
            shoppingCart.Clear();
            TotalSum sum = new TotalSum();
            sum.TotalProduct = user;
            sum.GrandTotal = totalPrice;
            sum.TotalDiscount = totalDiscount;
            return View(sum);
        }



        [HttpPost]
        public IActionResult Index(CustomerCategory customerCategory)
        {
            int totalDiscount;
            int totalPrice = Sum(customerCategory.Customer, shoppingCart, out totalDiscount);
            return RedirectToAction("Calculate", new { totalPrice = totalPrice, totalDiscount = totalDiscount });
        }
           
        
        public int Sum(string customerCategory,List<ArticleDetails>user ,out int totalDiscount)
        {
            int totalBill = 0;
            totalDiscount = 0;

            foreach(var item in user)
            {
                if(customerCategory=="Regular")
            {
                totalBill = totalBill + item.ArticleCost * 90 / 100;
                totalDiscount = totalDiscount + item.ArticleCost * 10 / 100;
            }
                if(customerCategory=="Premium")
            {
                totalBill = totalBill + item.ArticleCost * 80 / 100;
                totalDiscount = totalDiscount + item.ArticleCost * 20 / 100;
            }

            }
            return totalBill;
        }


        
    }
}