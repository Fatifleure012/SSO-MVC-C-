﻿using System.Web.Mvc;

namespace WebApp2.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public ActionResult Index()
    {
      return View();
    }
  }
}