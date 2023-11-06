using Microsoft.AspNetCore.Mvc;
using api_service;
using api_model;
namespace Missile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissleController : ControllerBase
    {
        readonly MissleService _service;

        public MissleController(MissleService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Missle> GetData()
        {
            return _service.GetData();
        }
        [HttpPost]
        public bool post(Missle m)
        {
            return _service.add(m);
        }
        [HttpGet]
        [Route("GetDataByCity")]
        public IEnumerable<Missle> GetDataByCity(string city)
        {
            return _service.GetDataByCity(city);
        }


        [HttpGet]
        [Route("GetCities")]
        public IEnumerable<string> GetCities()
        {

            return _service.GetCities();
        }
    }
}
