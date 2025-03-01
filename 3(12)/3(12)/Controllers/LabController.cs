using _3_12_.Model;
using Microsoft.AspNetCore.Mvc;

namespace _3_12_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LabController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LabController(ILogger<LabController> logger, AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        [HttpGet("Add")]
        public IActionResult Add(string name)
        {
            lab12 lab = new lab12 { Name = name };
            _context.Laba.Add(lab);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public IActionResult Show()
        {
            var bd = _context.Laba.ToList();
            return Ok(bd);
        }
    }
}
