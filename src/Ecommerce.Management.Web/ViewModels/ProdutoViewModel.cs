namespace Ecommerce.Management.Web.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Quantity { get; set; }
        public double Value { get; set; }
        public virtual List<ProductImages> Images { get; set; }
    }
    public class ProductImages
    {
        public string Url { get; set; }
    }
}
