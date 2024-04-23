namespace service_app_2.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public  BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
