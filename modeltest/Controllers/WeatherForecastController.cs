using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MediatR;
using modeltest.Handlers.CreateProcessCommand;

namespace modeltest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;

        public IMediator Mediator { get; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IMapper mapper,IMediator mediator)
        {
            _logger = logger;
            _mapper = mapper;
            Mediator= mediator;
        }

        [HttpPost]
        public async void Post(dynamic json)
        {
            await this.Mediator.Send(new createProcessCommand(json));
        }

    }
}
