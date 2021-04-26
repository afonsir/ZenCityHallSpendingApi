using AutoMapper;
using Dtos;
using Microsoft.AspNetCore.Mvc;
using ZenCityHallSpendingApi.Repositories;

namespace ZenCityHallSpendingApi.Controllers
{
    [ApiController]
    [Route("api/v1/empenhos")]
    public class EmpenhosController : ControllerBase
    {
        private readonly IEmpenhoRepository _repository;
        private readonly IMapper _mapper;

        public EmpenhosController(IEmpenhoRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.FindAll());
        }

        [HttpGet("{function}")]
        public ActionResult<EmpenhoTotalValueDto> GetByFunction(string function)
        {
            var empenho = _repository.FilterByFunction(function);         
            return Ok(_mapper.Map<EmpenhoTotalValueDto>(empenho));
        }
    }
}
