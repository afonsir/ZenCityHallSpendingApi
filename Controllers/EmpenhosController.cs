using Microsoft.AspNetCore.Mvc;
using ZenCityHallSpendingApi.Repositories;

namespace ZenCityHallSpendingApi.Controllers
{
    [ApiController]
    [Route("api/v1/empenhos")]
    public class EmpenhosController : ControllerBase
    {
        private readonly IEmpenhoRepository _repository;

        public EmpenhosController(IEmpenhoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.FindAll());
        }
    }
}
