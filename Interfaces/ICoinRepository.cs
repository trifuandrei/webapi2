using Bank.Entities;
using System.Collections.Generic;

namespace Bank.Interfaces
{
    public interface ICoinRepository
    {
        List<Coin> GetAll();
        void CreateCoin(Coin c);
        void DeleteCoin(int id);
        Coin GetCoin(int id);
        void EditCoin(Coin c);
        Coin GetCoinByName(string name);
    }
}
