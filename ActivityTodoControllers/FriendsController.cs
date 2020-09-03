using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Todo.Example.Api.Entities;
using Todo.Example.Api.Repository;

namespace Todo.Example.Api.Controllers
{
    [ApiController]
    [Route("api/v1/activity")]
    public class ActivityController : ControllerBase
    {
        public RepositoryFile _repositoryFile;

        public ActivityController() =>
            this._repositoryFile = new RepositoryFile();

        [HttpGet]
        public IEnumerable<Activity> GetAll()
        {
            return _repositoryFile.GetAllTodoFromFile();
        }

        [HttpGet("{id}")]
        public Activity GetById(int id)
        {
            return _repositoryFile.GetTodoById(id);
        }

        [HttpPost]
        public void Post([FromBody] Activity activity)
        {
            _repositoryFile.Insert(activity);
        }
    }
}