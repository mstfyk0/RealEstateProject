namespace Domain.Models
{
    public abstract class AuditableBaseEntity
    {
        public virtual int id { get; set; }
    }
}