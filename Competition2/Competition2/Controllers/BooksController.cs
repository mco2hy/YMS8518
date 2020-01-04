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
    public class BooksController : ControllerBase
    {
        public IUnitOfWork _unitOfWork;

        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        public ActionResult GetAll()
        {
            return new JsonResult(_unitOfWork.BookRepository.GetAll());
        }

        
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return new JsonResult(_unitOfWork.BookRepository.Get(id));
        }

        
        [HttpPost]
        public IActionResult Insert([FromBody] Book book)
        {
            _unitOfWork.BookRepository.Insert(book);
            _unitOfWork.Complete();
            return new JsonResult(book);
        }

        
        [HttpPut]
        public IActionResult Update([FromBody] Book book)
        {
            _unitOfWork.BookRepository.Update(book);
            _unitOfWork.Complete();
            return new JsonResult(book);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.BookRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult(id);
        }
    }
}
