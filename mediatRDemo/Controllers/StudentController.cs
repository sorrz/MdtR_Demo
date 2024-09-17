using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        var response = await _mediator.Send(new GetAllStudentsQuery());
        return Ok(response.Students);  // Always returns a list (empty or populated)
    }
}
