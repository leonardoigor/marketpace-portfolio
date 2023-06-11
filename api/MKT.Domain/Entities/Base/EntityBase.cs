namespace MKT.Domain.Entities.Base
{
    public class EntityBase
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        protected virtual void NotificationsConfig()
        {
        }
    }
}
