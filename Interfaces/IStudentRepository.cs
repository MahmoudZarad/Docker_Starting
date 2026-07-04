using StudentApi.Models;

namespace StudentApi.Interfaces;

public interface IStudentRepository
{
    Task<List<Student>> GetAllAsync();

    Task<Student?> GetByIdAsync(int id);

    Task AddAsync(Student student);

    Task SaveChangesAsync();
}
