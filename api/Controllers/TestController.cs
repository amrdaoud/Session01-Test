using api.Data;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly ISingletonService _singletonService;
        private readonly ICombineService _combineService;
        public TestController(ApplicationDbContext db, ITransientService transientService, IScopedService scopedService, ISingletonService singletonService, ICombineService combineService)
        {
            _db = db;
            _scopedService = scopedService;
            _transientService = transientService;
            _singletonService = singletonService;
            _combineService = combineService;
        }
        [HttpGet]
        public IActionResult GetTest() {
            var result = _db.CarTypes
            .Find(1);
            var cars = result.Cars.ToList();
            return Ok(result);
        }
        [HttpGet("transient")]
        public IActionResult GetTransient() {
            var result = new {first= _transientService.getGuid(), second = _combineService.getTransient()};
            return Ok(result);
        }
        [HttpGet("scoped")]
        public IActionResult GetScoped() {
            var result = new {first= _scopedService.getGuid(), second = _combineService.getScoped()};
            return Ok(result);
        }
        [HttpGet("singleton")]
        public IActionResult GetSingleton() {
            return Ok(_singletonService.getGuid());
        }
    }
}