using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.ViewModels;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISnowboardRepository _snowboardRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISnowboardRepository snowboardRepository, ShoppingCart shoppingCart)
        {
            _snowboardRepository = snowboardRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int snowboardId)
        {
            var selectedSnowboard = _snowboardRepository.Snowboards.FirstOrDefault(s => s.Id == snowboardId);

            if (selectedSnowboard != null)
            {
                _shoppingCart.AddToCart(selectedSnowboard, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int snowboardId)
        {
            var selectedSnowboard = _snowboardRepository.Snowboards.FirstOrDefault(s => s.Id == snowboardId); 

            if (selectedSnowboard != null)
            {
                _shoppingCart.RemoveFromCart(selectedSnowboard);
            }

            return RedirectToAction("Index");
        }




    }
}
