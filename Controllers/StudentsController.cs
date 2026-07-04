using Microsoft.AspNetCore.Mvc;
using StudentApi.Interfaces;
using StudentApi.Models;

namespace StudentApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController(IStudentRepository _repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repository.GetAllAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Create(Student student)
    {
        await _repository.AddAsync(student);
        await _repository.SaveChangesAsync();

        return Ok(student);
    }
}
