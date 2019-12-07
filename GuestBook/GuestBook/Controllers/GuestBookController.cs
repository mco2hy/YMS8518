using GuestBook.Data.Context;
using GuestBook.Data.Dto;
using GuestBook.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuestBook.Controllers
{
    public class GuestBookController : Controller
    {
        private readonly DataContext _dataContext;
        public GuestBookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            List<GuestNote> guestNotes = _dataContext.GuestNotes.ToList();
            return View(guestNotes);
        }

        public IActionResult Manage()
        {
            if (HttpContext.Session.GetInt32(key:"userId") != null)
            {
                return RedirectToAction("AdminDashboard", controllerName: "GuestBook");
            }
            return View();
        }

        public IActionResult LoginAction([FromBody]GuestBookLoginDto guestBookLoginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(error: "Bad boy");
            }


            User user = _dataContext.Users.SingleOrDefault
                (a => a.Username == guestBookLoginDto.Username && a.Password == guestBookLoginDto.Password);

            if (user != null)
            {
                HttpContext.Session.SetInt32("userId", user.Id);
                return new JsonResult("OK");
            }
            else
            {
                return Unauthorized();
            }

            
        }

        public IActionResult LogoutAction()
        {
            HttpContext.Session.Remove(key: "userId");
            return RedirectToAction("Manage",controllerName:"GuestBook");
        }
        public IActionResult AdminDashboard()
        {
            if (HttpContext.Session.GetInt32("userId") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Manage", controllerName: "GuestBook");
            }

            
        }
        public IActionResult SendAction([FromBody]GuestBookSendActionDto guestBookSendActionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(error: "Bizde yapardık zamanında");
            }

            GuestNote guestNote = new GuestNote();
            guestNote.Name = guestBookSendActionDto.Name;
            guestNote.Surname = guestBookSendActionDto.Surname;
            guestNote.Email = guestBookSendActionDto.Email;
            guestNote.Message = guestBookSendActionDto.Message;
            guestNote.CreateDate = DateTime.Now;

            _dataContext.GuestNotes.Add(guestNote);
            _dataContext.SaveChanges(); //Databases a kaydet.

            return new JsonResult("ok");
        }
        
    }
}