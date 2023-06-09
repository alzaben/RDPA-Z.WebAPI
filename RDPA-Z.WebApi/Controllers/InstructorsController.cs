using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RDPA_Z.Core.IRepositories;
using RDPA_Z.Core.Models;

namespace RDPA_Z.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IBaseRepository<InstructorRequest> _InstructorRepository;

        public InstructorsController(IBaseRepository<InstructorRequest> instructorRepository)
        {
            _InstructorRepository = instructorRepository;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_InstructorRepository.FindAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetInstructorId(int id)
        {
            return Ok(_InstructorRepository.FindById(id));
        }
        [HttpPost("Post")]
        public IActionResult PostInstructor(InstructorRequest instructor)
        {
            return(Ok(_InstructorRepository.Post(instructor)));
        }
    }
}
