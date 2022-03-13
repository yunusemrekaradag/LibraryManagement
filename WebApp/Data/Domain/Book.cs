namespace WebApp.Data.Domain
{
    public class Book: BaseEntity
    {
        public virtual Category Category { get; set; }
        public virtual Writer Writer { get; set; }
        public string BookName { get; set; }
        public DateTime BookRecordDate { get; set; }

    }
}
