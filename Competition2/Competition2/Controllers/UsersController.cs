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
    public class UsersController : ControllerBase
    {
        public IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return new JsonResult(_unitOfWork.UserRepository.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return new JsonResult(_unitOfWork.UserRepository.Get(id));
        }


        [HttpPost]
        public IActionResult Insert([FromBody] User user)
        {
            _unitOfWork.UserRepository.Insert(user);
            _unitOfWork.Complete();
            return new JsonResult(user);
        }


        [HttpPut]
        public IActionResult Update([FromBody] User user)
        {
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.Complete();
            return new JsonResult(user);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.UserRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult(id);
        }
    }
}