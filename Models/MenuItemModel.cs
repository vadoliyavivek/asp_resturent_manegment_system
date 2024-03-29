namespace MRV_resturant.Models
{
    public class MenuItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Catagorey { get; set; }
        public decimal Price { get; set; }
        public byte[] ImageData { get; internal set; }
    }
}
