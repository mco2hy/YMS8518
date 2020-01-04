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
    public class RoomsController : ControllerBase
    {
        public IUnitOfWork _unitOfWork;

        public RoomsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return new JsonResult(_unitOfWork.RoomRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return new JsonResult(_unitOfWork.RoomRepository.Get(id));
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Room room)
        {
            _unitOfWork.RoomRepository.Insert(room);
            _unitOfWork.Complete();
            return new JsonResult(room);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Room room)
        {
            _unitOfWork.RoomRepository.Update(room);
            _unitOfWork.Complete();
            return new JsonResult(room);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.RoomRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult(id);
        }
    }
}