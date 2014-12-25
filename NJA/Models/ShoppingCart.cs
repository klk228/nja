using System;
using System.Collections.Generic;
namespace NJA.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;
        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public IEnumerable<Product> Products { get; set; }
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }

    public interface IDiscountHelper
    {
         decimal ApplyDiscount(decimal totalParam);
    }
    public class MinimumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            return totalParam * 1;
           // throw new NotImplementedException();
        }
    }
}