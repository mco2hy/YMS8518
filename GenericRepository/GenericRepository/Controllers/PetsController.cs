using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public PetsController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _unitOfWork.PetRepository.getAll();
            return new JsonResult(books);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Pet pet)
        {
            _unitOfWork.PetRepository.Insert(pet);
            _unitOfWork.Complete();
            return new JsonResult(pet);
        }
    }
}