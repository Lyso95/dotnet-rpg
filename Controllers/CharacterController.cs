using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };
        
        [HttpGet("GetAll")]
        
        public ActionResult<List<Character>> GetGet()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}