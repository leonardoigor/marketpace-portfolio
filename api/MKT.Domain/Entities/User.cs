using MKT.Domain.Entities.Base;

namespace MKT.Domain.Entities
{
    public class User : EntityBase
    {
        public String Name { get; set; }
        public String LastName { get; set; }
        public String LastToken { get; set; }
    }
}
