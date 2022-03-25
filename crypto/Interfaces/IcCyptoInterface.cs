using crypto.Entities;

namespace crypto.Interfaces
{
    public interface IcCyptoInterface
    {
        Crypto GetCrypto(int id);
        void AddCrypto(Crypto crypto);
        void RemoveCrypto(int id);  
        void UpdateCrypto(Crypto crypto);
    }
}
