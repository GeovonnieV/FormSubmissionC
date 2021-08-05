using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmissionC.Models;

namespace FormSubmissionC.Controllers
    {
        public class FormController : Controller
            {
                [HttpGet("")]
                public IActionResult Index()
                    {
                        return View();
                    }

                [HttpPost("")]
                public IActionResult CreateIndex(Form user)
                    {
                        if(ModelState.IsValid)
                            {
                                // If everything is cool go to the success page
                                return RedirectToAction("SuccessPage");
                            }
                        else{
                            return View("Index");
                        }
                    }

                [HttpGet("success")]
                public IActionResult SuccessPage()
                    {
                        return View("SuccessPage");
                    }

            }

    }