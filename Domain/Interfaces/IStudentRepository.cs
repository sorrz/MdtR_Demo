
public interface IStudentRepository
{
    Task<List<Student>> GetAllAsync();
}