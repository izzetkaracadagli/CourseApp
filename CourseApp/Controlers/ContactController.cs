﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Data.Abstract;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controlers
{
    public class ContactController : Controller
    {
        private IGenericRepository<Contact> repo;
        public ContactController(IGenericRepository<Contact> _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetAll());
        }
    }
}