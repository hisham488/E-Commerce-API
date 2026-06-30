namespace E_Commerce.Domain.Commen
{
    public abstract class BaseEntities<Tkey>
    {
        public Tkey Id { get; set; } = default!;
    }
}
