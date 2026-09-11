namespace E_Commerce.Domain.Commen
{
    public abstract class BaseEntity<Tkey>
    {
        public Tkey Id { get; set; } = default!;
    }
}
