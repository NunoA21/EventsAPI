using EventsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        /// <summary>
        /// Gets the schools students list
        /// </summary>
        /// <returns>list of students</returns>
        [HttpGet]
        public async Task<IEnumerable<string>> GetStudentsList()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Gets a specific student
        /// </summary>
        /// <param name="id">id of the required student</param>
        /// <returns>the required student</returns>
        [HttpGet("{id}")]
        public async Task<string> GetStudent(int id)
        {
            return "student";
        }

        /// <summary>
        /// Inserts a new student in the system
        /// </summary>
        /// <param name="student">student to create</param>
        [HttpPost]
        public async Task<string> Post([FromBody] Student student)
        {
            return "inserted!";
        }

        /// <summary>
        /// Updates a specific student 
        /// </summary>
        /// <param name="id">student to update</param>
        [HttpPut("{id}")]
        public async Task<string> Update([FromBody] Student student)
        {
            return "updated!";
        }

        /// <summary>
        /// Deletes a specific student
        /// </summary>
        /// <param name="id">student to delete</param>
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return "deleted!";
        }
    }
}
