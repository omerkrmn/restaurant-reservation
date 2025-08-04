using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RR.Repositories.Conctrats;
using RR.Repositories.EFCore;

namespace RR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly IRepositoryManager _manager;

        public TableController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        public IActionResult CreateTable([FromBody] string tableName)
        {
            _manager.Table.Create(new Models.Table());
            return Ok($"Table '{tableName}' created successfully.");
        }
    }
}
