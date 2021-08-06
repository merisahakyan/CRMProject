namespace DatabaseAccessLayer.Entities
{
    public class EmailTemplate : BaseEntity
    {
        public string Name { get; set; }
        public string Body { get; set; }
    }

}
