using RoboWalk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoboWalk.Controllers
{
    public class RoboWalkController : Controller
    {
        // GET: RoboWalk
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RoboWalk()
        {
            return View();
        }

        public ActionResult StartRobot (int xAxisValue, int yAxisValue, string direction, string walkInput)
        {
            RoboInputModel model = new RoboInputModel();
            string[] stringArray = new string[walkInput.Length];
            for (int i=0; i< walkInput.Length; i++)
            {
                stringArray[i] = walkInput.Substring(i,1);
            }
            for(int i = 0; i < walkInput.Length; i++)
            {
                if (stringArray[i] != "R" && stringArray[i] != "L")
                {
                    xAxisValue = (direction == "West") ? (xAxisValue - Convert.ToInt16(stringArray[i])) : (direction == "East") ? (xAxisValue + Convert.ToInt16(stringArray[i])) : xAxisValue;
                    yAxisValue = (direction == "South") ? (yAxisValue - Convert.ToInt16(stringArray[i])) : (direction == "North") ? (yAxisValue + Convert.ToInt16(stringArray[i])) : yAxisValue;
                }
                if (stringArray[i] == "L")
                {
                    direction = (direction == "North" && stringArray[i] == "L") ? "West" : (direction == "West" && stringArray[i] == "L") ? "South" : (direction == "South" && stringArray[i] == "L") ? "East" : (direction == "East" && stringArray[i] == "L") ? "North" : direction;
                }
                if (stringArray[i] == "R")
                {
                    direction = (direction == "North" && stringArray[i] == "R") ? "East" : (direction == "East" && stringArray[i] == "R") ? "South" : (direction == "South" && stringArray[i] == "R") ? "West" : (direction == "West" && stringArray[i] == "R") ? "North" : direction;
                }
            }

            model.XCordinationValue = xAxisValue;
            model.YCordinationValue = yAxisValue;
            model.Direction = direction;
            var jsonResult = Json(model, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        // GET: RoboWalk/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoboWalk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoboWalk/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RoboWalk/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoboWalk/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RoboWalk/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoboWalk/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
