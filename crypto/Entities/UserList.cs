namespace crypto.Entities
{
    public class UserList
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Crypto cryptos { get; set; }
    }
}
