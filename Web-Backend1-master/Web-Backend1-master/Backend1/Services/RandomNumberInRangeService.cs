using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend1.Services
{
    public class RandomNumberInRangeService : IRandomNumberInRangeService
    {
        public int GenerateRandomNumber() => new Random().Next(15000);
    }
}
