using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvenOddPrimeNumber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenOddPrimeController : ControllerBase
    {
        [HttpPost]
        [Route("api/EvenOdd")]
        public string EvenOdd([FromBody] int n)
        {
            if (n % 2 == 0) return "Even";
            return "Odd";
        }

        [HttpPost]
        [Route("api/Prime")]
        public string Prime([FromBody] int n)
        {
            if (n < 2) return "Not a prime number";
            bool isPrime = false;
            for (int i = 2; i*i <= n; i++)
            {
                if(n % i == 0)
                {
                    isPrime = false;
                    break;
                }
                isPrime = true;
            }
            return isPrime ? "A prime number" : "Not a prime number";
        }
    }
}
