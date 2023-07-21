using Bank.Entities;
using Bank.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bank.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CoinController : ControllerBase
    {
        private readonly CoinRepository _coinRepository;

        public CoinController(CoinRepository coinRepository)
        {
            _coinRepository = coinRepository;
        }

        [HttpGet]
        public IEnumerable<Coin> GetAll()
        {
            return _coinRepository.GetAll();
        }

        [HttpPost]
        public void AddCoin(Coin coin)
        {
            _coinRepository.CreateCoin(coin);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _coinRepository.DeleteCoin(id);
        }

        [HttpGet("{id?}")]
        public Coin GetCoin(int? id, string name)
        {
            if (id.HasValue)
            {
                return _coinRepository.GetCoin(id.Value);
            }
            else if (!string.IsNullOrEmpty(name))
            {
                return _coinRepository.GetCoinByName(name);
            }
            return null;
        }

        [HttpPut]
        public void EditCoin(Coin c)
        {
            _coinRepository.EditCoin(c);
        }
    }
}
