using DemoAPIs.Repository.Data;
using DemoAPIs.Repository.DTOs;
using DemoAPIs.Repository.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPIs.Repository.Controllers
{
    [Route("api/v1/dogs")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] // monsite.com/api/v1/dogs
        public IActionResult GetAll()
        {
            var chiens = _context.Dogs.ToList();

            return Ok(chiens);
        }

        [HttpGet] // monsite.com/api/v1/dogs?breed=...
        public IActionResult GetWithBreed([FromQuery] string breed)
        {
            var chiens = _context.Dogs
                .Where(dog => dog.Breed.StartsWith(breed))
                .ToList();

            return Ok(chiens);
        }

        [HttpGet("{dogId}")] // monsite.com/api/v1/dogs/:dogId
        public IActionResult GetById(int dogId)
        {
            var chienTrouve = _context.Dogs.FirstOrDefault(dog => dog.DogId == dogId);

            if (chienTrouve == null)
            {
                return NotFound();
            } else
            {
                return Ok(chienTrouve);
            }
        }

        [HttpPost] // monsite.com/api/v1/dogs 
        public IActionResult CreateDog([FromBody] DogCreationRequest payload)
        {
            // On va extraire les informations du chien via le DTO
            var dogName = payload.Name;
            var dogBreed = payload.Breed;
            var dogColor = (DogColor) Enum.Parse(typeof(DogColor), payload.Color);


            // 'jj/mm/aaaa' => ['jj', 'mm', 'aaaa']
            var dateArray = payload.BirthDate.Split('/');

            var day = int.Parse(dateArray[0]);
            var month = int.Parse(dateArray[1]);
            var year = int.Parse(dateArray[2]);

            var dogBirthdate = new DateOnly(year, month, day);

            var newDog = new Dog()
            {
                Name = dogName,
                Breed = dogBreed,
                Color = dogColor,
                BirthDay = dogBirthdate
            };

            _context.Dogs.Add(newDog);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { Id = newDog.DogId }, newDog);
        }

        [HttpPatch("{dogId}")] // monsite.com/api/v1/dogs/:dogId
        public IActionResult EditById(int dogId, [FromBody] DogEditRequest payload)
        {
            var chienTrouve = _context.Dogs.FirstOrDefault(dog => dog.DogId == dogId);

            if (chienTrouve == null) 
            {
                return NotFound();
            } else
            {
                if (payload.Name != null && payload.Name != string.Empty)
                    chienTrouve.Name = payload.Name;

                if (payload.Breed != null && payload.Breed != string.Empty) 
                    chienTrouve.Breed = payload.Breed;

                if (payload.Color != null && payload.Color != string.Empty)
                    chienTrouve.Color = (DogColor) Enum.Parse(typeof(DogColor), payload.Color);

                if (payload.BirthDate != null && payload.BirthDate != string.Empty)
                {
                    var dateArray = payload.BirthDate.Split('/');

                    var day = int.Parse(dateArray[0]);
                    var month = int.Parse(dateArray[1]);
                    var year = int.Parse(dateArray[2]);

                    chienTrouve.BirthDay = new DateOnly(year, month, day);
                }

                _context.SaveChanges();
                return NoContent();
            }


                [HttpDelete("{dogId}")] // monsite.com/api/v1/dogs/:dogId
                public IActionResult DeleteById(int dogId)
                {
                    var chienTrouve = _context.Dogs.FirstOrDefault(dog => dog.DogId == dogId);

                    if (chienTrouve != null)
                    {
                        _context.Dogs.Remove(chienTrouve);
                        _context.SaveChanges();

                        return NoContent();
                    } else
                    {
                        return NotFound();
                    }
                }



    }
}
