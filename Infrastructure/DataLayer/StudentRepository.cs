using Microsoft.EntityFrameworkCore;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    async Task<List<Student>> IStudentRepository.GetAllAsync()
    {
        return await _context.Students.ToListAsync();
    }
}
