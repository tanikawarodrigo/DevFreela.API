using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService) 
        { 
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var user = _userService.GetById(id);
            if(user == null) 
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody]NewUserInputModel createUserModel)
        {
            var id = _userService.Create(createUserModel);
            return CreatedAtAction(nameof(GetById), new { id = id }, createUserModel);
        }

        //Poderia ser post, mas muitos projetos trabalham com a atualização do sistema. Ex. Ultima vez logado
        //[HttpPut("{id}/login")]
        //public IActionResult Login(int id, [FromBody]LoginModel loginModel)
        //{
        //    return NoContent();
        //}


    }
}
