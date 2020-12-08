﻿using Code_First_with_Repository_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_with_Repository_Pattern.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        // GET: Category
        public ActionResult Index()
        {
            return View(categoryRepository.GetAll());
        }
    }
}