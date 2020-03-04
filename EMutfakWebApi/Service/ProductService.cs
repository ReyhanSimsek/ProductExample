using EMutfakWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMutfakWebApi.Service
{
    public class ProductService
    {
        /*
        C - Create
        R - Read
        U - Update
        D - Delete
        */


     
        public void Create(Products product)
        {
            var context = new EMutfakContext();

            context.Product.Add(product);
            context.SaveChanges();
        }


        public Products Get(int id)
        {
            var context = new EMutfakContext();
            return context.Product.Where(p => p.ID == id).FirstOrDefault();
        }

    public List<Products> GetList ()
     {
        var context = new EMutfakContext();
            return context.Product.ToList();

     }

    public void Update(Products product)
        {
        var context = new EMutfakContext();
            var oldProduct = context.Product.Where(p => p.ID == product.ID).FirstOrDefault();
            if (oldProduct != null)
            {
                oldProduct.NameSurname = product.NameSurname;
                oldProduct.Password = product.Password;
                oldProduct.PasswordReply = product.PasswordReply;
                oldProduct.Price = product.Price;
                oldProduct.Rate = product.Rate;
                oldProduct.TCKN = product.TCKN;
                oldProduct.CalculatedValue = product.CalculatedValue;
                context.SaveChanges();
            }
        }

        public void Delete (int id)
        {
            var context = new EMutfakContext();
            Products prd = context.Product.Where(p => p.ID == id).FirstOrDefault();
            context.Product.Remove(prd);
            context.SaveChanges();

        }
}
}