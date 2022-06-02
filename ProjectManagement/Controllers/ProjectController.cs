using Contracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagement.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private List<Project> projectList;
        private ILoggerManager _logger;

        public ProjectsController(ILoggerManager logger)
        {
            _logger = logger;
            projectList = new List<Project>
            {
                new Project {Id=Guid.NewGuid(), Name ="Project 1 " },
                new Project {Id=Guid.NewGuid(), Name ="Project 2 " },
                new Project {Id=Guid.NewGuid(), Name ="Project 3 " },
                new Project {Id=Guid.NewGuid(), Name ="Project 4x " }
            };
        }
       

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
               
                _logger.LogInfo("Projects.Get() has been run.");
                return Ok(projectList);

            }
            catch (Exception ex)
            {
                _logger.LogError("Projects.Get() has been crashed : "+ ex.Message);
                throw;
            }  
        }
    }
}
