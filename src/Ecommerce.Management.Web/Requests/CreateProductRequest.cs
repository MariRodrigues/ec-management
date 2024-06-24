namespace Ecommerce.Management.Web.Requests
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public int SubcategoryId { get; set; }
        public int Quantity { get; set; }
        public List<string> Images { get; set; } = new List<string>();
        //public List<ProductSizeRequest> Sizes { get; set; } = new List<ProductSizeRequest>();
    }

    //public class ProductSizeRequest
    //{
    //    public SizeEnum Size { get; set; }
    //    public int Quantity { get; set; }
    //}
}
