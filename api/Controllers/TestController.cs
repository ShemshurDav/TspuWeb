using Microsoft.AspNetCore.Mvc;

namespace tspuWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        [Route("{count}")]
        public int[] GetRandomNumbers(int count)
        {
            Random random = new Random();
            int[] randomNumbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                randomNumbers[i] = random.Next(0, 100);
            }

            return randomNumbers;
        }

    }
}
