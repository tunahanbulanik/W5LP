using System;


namespace W5LP
{
    public class Car
    {
        private DateTime _productDate;
        private string _productId;
        private string _productBrandName;
        private string _productModel;
        private string _productColor;
        private int _productDoorNumber;

        public DateTime ProductDate
        {
            get { return _productDate; }
            set { _productDate = DateTime.Now; }
        }
        public string ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public string ProductBrandName
        {
            get { return _productBrandName; }
            set { _productBrandName = value; }
        }
        public string ProductModel
        {
            get { return _productModel; }
            set { _productModel = value; }
        }
        public string ProductColor
        {
            get { return _productColor; }
            set { _productColor = value; }
        }
        public int ProductDoorNumber
        {
            get { return _productDoorNumber; }
            set { _productDoorNumber = value; }
        }

        public override string ToString()
        {

            return $"Product date: {ProductDate}\n" +
                   $"Product ID: {ProductId}\n" +
                   $"Product brand name: {ProductBrandName}\n" +
                   $"Product model: {ProductModel}\n" +
                   $"Product color: {ProductColor}\n" +
                   $"Product door amount: {ProductDoorNumber}";
        }
    }
}
