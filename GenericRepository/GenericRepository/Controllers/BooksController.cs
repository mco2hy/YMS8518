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
    public class BooksController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public BooksController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _unitOfWork.BookRepository.getAll();
            return new JsonResult(books);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Book book)
        {
            _unitOfWork.BookRepository.Insert(book);
            _unitOfWork.Complete();
            return new JsonResult(book);
        }
    }
}
