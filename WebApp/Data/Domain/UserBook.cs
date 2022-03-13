namespace WebApp.Data.Domain
{
    public class UserBook: BaseEntity
    {
        public virtual User User { get; set; }
        public virtual Category Category{ get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

    }
}
