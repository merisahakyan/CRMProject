namespace DatabaseAccessLayer.Entities
{
    public class ClientGroup : BaseEntity
    {
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}
