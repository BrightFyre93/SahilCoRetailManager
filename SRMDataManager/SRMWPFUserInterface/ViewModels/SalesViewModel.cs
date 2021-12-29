using Caliburn.Micro;
using SRMDesktopUI.Library.API;
using SRMDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private IProductEndPoint _productEndPoint;

        public SalesViewModel(IProductEndPoint productEndPoint)
        {
            _productEndPoint = productEndPoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadProducts();
        }

        public async Task LoadProducts()
        {
            var products = await _productEndPoint.GetAll();
            Products = new BindingList<ProductModel>(products);
        }

        private BindingList<ProductModel> _products;

        public BindingList<ProductModel> Products
        {
            get { return _products; }
            set
            { 
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set 
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        private int _itemQuantity;

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal
        {
            //TODO replace with calculation
            get
            {
                return "$0.00";
            }
        }

        public string Tax
        {
            //TODO replace with calculation
            get
            {
                return "$0.00";
            }
        }

        public string Total
        {
            //TODO replace with calculation
            get
            {
                return "$0.00";
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;

                // Make sure something is selected
                // Make sure item quantity is greater than 0

                return output;
            }
        }

        public void AddToCard()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                // Make sure something is selected

                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                // Make sure something is in cart

                return output;
            }
        }

        public void CheckOut()
        {

        }
    }
}
