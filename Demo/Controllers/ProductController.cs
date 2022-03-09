using Microsoft.AspNetCore.Mvc;
using Demo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult getAll()
        {
            //get product info from model
            ProductSampleData context = new ProductSampleData();
            List<Product> productsModel= context.Products();
            //return view 
            return View("getAllProduct",productsModel);//model =null
        }
        //product/details/2//?age=11
        public IActionResult DEtails(int id)//,int age)
        {
            ProductSampleData context = new ProductSampleData();
            List<Product> ProductList = context.Products();
            Product product= ProductList.FirstOrDefault(p=>p.Id==id);
            return View("GetDetails", product);//
        }
    }
}
