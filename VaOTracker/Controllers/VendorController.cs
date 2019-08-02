using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VaOTracker.Models;

namespace VaOTracker.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDesc)
    {
      Vendor newVendor = new Vendor(vendorName,vendorDesc);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrder = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrder);
      return View(model);
    }


    // This one creates new Items within a given Vendor, not new Categories:
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      double priceconverstion = double.Parse(orderPrice, System.Globalization.CultureInfo.InvariantCulture);
      Order newOrder = new Order(orderTitle, orderDescription, priceconverstion, orderDate);
      foundVendor.AddItem(newOrder);
      List<Order> vendorOrder = foundVendor.Orders;
      model.Add("orders", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  }
}
