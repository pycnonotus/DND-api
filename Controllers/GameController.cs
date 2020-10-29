using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers {
    public class GameController : ControllerBaseApi {
        [HttpGet]

        public async Task<string> Check () {
            return "Ok;";
        }
    }
}
