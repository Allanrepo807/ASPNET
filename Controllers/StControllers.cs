using SkeltalStudentApi.models;
using SkeltalStudentApi.servcies;
using Microsoft.AspNetCore.Mvc;

namespace SkeltalStudentApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StController : ControllerBase
{

    public StController(){}

    [HttpGet]
    public ActionResult<List<Student>> GetAll() =>
        StServices.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Student> Get(int id)
    {
        var pizza = StServices.Get(id);

        if(pizza == null)
            return NotFound();

        return pizza;
    }   

    [HttpPost]
    public IActionResult Create()
    {
        var result = StServices.Add();
        return Ok(result);
    }
    [HttpPut]
    public IActionResult Update()
    {
        var result = StServices.Update();
        return Ok(result);
    }
    [HttpDelete]
    public IActionResult Delete()
    {
        var result = StServices.Delete();
        return Ok(result);
    }
}
