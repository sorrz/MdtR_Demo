public class GetAllStudentsResponse
{
    public List<StudentDto> Students { get; set; } = new List<StudentDto>();
    public int Count => Students.Count;
}