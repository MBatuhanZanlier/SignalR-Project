namespace SignalR.EntityLayer.DAL.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
