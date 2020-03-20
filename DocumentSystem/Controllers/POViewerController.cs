﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DocumentSystem.Models;
using DocumentSystem.BAL;


namespace DocumentSystem.Controllers
{
    public class POViewerController : Controller
    {

				public ActionResult Index()
				{
					 return View();
				}


				[HttpPost]
				[ValidateAntiForgeryToken]
				public ActionResult Index(POViwerModel model)
				{
					if (ModelState.IsValid)
					{
						POViewerServices PSvc = new POViewerServices();
						model = PSvc.GetPODocument(model.PONumber);

						if (model == null)
						{
							ModelState.AddModelError("PONumber", "Purchase order not found or matched");
							return View("Index", model);
						}
					}
					 return View("Index",model);
				}


				public ActionResult GetPOFile(string PONumber)
				{
					POViwerModel POViewModel = new POViwerModel();

					try
					{
						POViewerServices PSvc = new POViewerServices();
						POViewModel = PSvc.GetPODocument(PONumber);

						if (POViewModel.InvoiceDocument.Length > 0)
						{
							return File(POViewModel.InvoiceDocument, POViewModel.InvoiceMIME);
						}
					}
					catch (Exception ex)
					{
						Console.Write(ex);
					}
					return View("Index", POViewModel);
				}
		
	}
}