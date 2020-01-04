using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Competition2.Interfaces;
using Competition2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Competition2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        public IUnitOfWork _unitOfWork;

        public PetsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return new JsonResult(_unitOfWork.PetRepository.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return new JsonResult(_unitOfWork.PetRepository.Get(id));
        }


        [HttpPost]
        public IActionResult Insert([FromBody] Pet pet)
        {
            _unitOfWork.PetRepository.Insert(pet);
            _unitOfWork.Complete();
            return new JsonResult(pet);
        }


        [HttpPut]
        public IActionResult Update([FromBody] Pet pet)
        {
            _unitOfWork.PetRepository.Update(pet);
            _unitOfWork.Complete();
            return new JsonResult(pet);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.PetRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult(id);
        }
    }
}