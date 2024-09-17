using MediatR;

public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, GetAllStudentsResponse>
{
    private readonly IStudentRepository _studentRepository;

    public GetAllStudentsQueryHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<GetAllStudentsResponse> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
    {
        var students = await _studentRepository.GetAllAsync();

        return new GetAllStudentsResponse
        {
            Students = students.Select(student => new StudentDto
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age
            }).ToList()
        };
    }
}
