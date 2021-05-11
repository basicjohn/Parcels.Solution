using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
using Parcels.Models;


namespace Parcels.Controllers
{
  public class ParcelController : Controller
  {

    [HttpGet("/Parcel")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/Parcel/create")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/Parcel")]
    public ActionResult CreateForm(int weight, int length, int width, int height)
    {
      Parcel parcel = new Parcel();
      parcel.SetWeight(weight);
      parcel.SetVolumeWith(length, width, height);

      return RedirectToAction("Index", parcel);
    }
  }
}