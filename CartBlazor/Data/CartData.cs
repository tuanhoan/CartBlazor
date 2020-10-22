using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartBlazor.Data
{
    interface IServices{
        public List<Cart> LoadData();
        public List<Cart> LoadCart();
}
    public class CartData:IServices
    {
        public List<CartImg> LoadData()
        {
            var context = new Context();
            return context.CartImgs.ToList();
        }
        public List<Cart> LoadCart()
        {
            var context = new Context();
            return context.Carts.ToList();
        }

        List<Cart> IServices.LoadData()
        {
            throw new NotImplementedException();
        }

        List<Cart> IServices.LoadCart()
        {
            throw new NotImplementedException();
        }
    }
}
