using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public AnimalsController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var animals = _unitOfWork.AnimalRepository.GetAll();
            return new JsonResult(animals);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Models.Animal animal)
        {
            _unitOfWork.AnimalRepository.Insert(animal);
            _unitOfWork.complete();
            return new JsonResult(animal);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Models.Animal animal)
        {
            _unitOfWork.AnimalRepository.Update(animal);
            _unitOfWork.complete();
            return new JsonResult(animal);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.AnimalRepository.Delete(id);
            _unitOfWork.complete();
            return new JsonResult("ok");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var animals = _unitOfWork.AnimalRepository.GetById(id);
            return new JsonResult(animals);
        }
    }
}