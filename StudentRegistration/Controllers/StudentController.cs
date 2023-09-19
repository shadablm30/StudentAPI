using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Data;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Students;
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id , [FromBody] Student student)
        {
            var studentfromdb = _context.Students.Find(id);
            studentfromdb.Name = student.Name;
            studentfromdb.FatherName = student.FatherName;
            studentfromdb.MotherName = student.MotherName;
            studentfromdb.Email = student.Email;
            studentfromdb.Mobile = student.Mobile;

            _context.Students.Update(studentfromdb);
            _context.SaveChanges();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var studentfromdb = _context.Students.Find(id);
            _context.Students.Remove(studentfromdb);
            _context.SaveChanges();
        }
    }
}
