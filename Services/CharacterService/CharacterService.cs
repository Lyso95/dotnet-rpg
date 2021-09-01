using System.Collections.Generic;
using dotnet_rpg.Models;
using System.Linq;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        public List<Character> characters = new List<Character>
        {
            private static List<Character> characters = new List<Character>{
                new Character();
                new Character{ Id = 1, Name = "Sam"}
            };
        
        }
                
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}