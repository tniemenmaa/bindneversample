using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BindNeverSample;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    [HttpPost("BindNever")]
    public IActionResult BindNeverAction([BindNever]SampleModel sample)
    {
        return Ok(sample);
    }

    [HttpPost("WithoutBindNever")]
    public IActionResult WithoutBindNeverAction(SampleModel sample) 
    {
        return Ok(sample);
    }
}
