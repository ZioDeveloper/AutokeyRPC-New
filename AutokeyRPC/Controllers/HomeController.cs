using AutokeyRPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutokeyRPC.Models;
using System.Data.Entity;

namespace AutokeyRPC.Controllers
{
    public class HomeController : Controller
    {
        private AutokeyEntities db = new AutokeyEntities();
        
        
        public ActionResult Index(string SearchString, string SearchLocation)
        {
            // Carico DropDownList
            using (AutokeyEntities val = new AutokeyEntities())
            {
                Session["Scelta1"] = "";
                var fromDatabaseEF = new SelectList(val.RPC_Cantieri_vw.ToList(), "IDCantiere", "ragioneSociale");
                ViewData["RPC_Cantieri_vw"] = fromDatabaseEF;

            }

            TempData["mySearch"] = SearchLocation;
            TempData["myIDOperatore"] = SearchString;

            // Verifico esista il perito...
            using (AutokeyEntities db = new AutokeyEntities())
            {
                if (String.IsNullOrEmpty(SearchString))
                {
                    return View();
                }
                else
                {
                    if (SearchString.Length == 4)
                    {
                        try
                        {
                            var periti = (from s in db.AUK_tecnici
                                          where s.Codice == SearchString
                                          select s.ID).First();
                            if (periti.ToString() != null)
                            {
                                var model = new Models.HomeModel();

                                //var telai = from s in db.RPC_Telai
                                //            where s.IDCantiere.ToString() == SearchLocation
                                //            && s.IDOperatore.ToString() == SearchString
                                //            select s;
                                var telai = from s in db.RPC_Telai
                                            where s.IDCantiere.ToString() == SearchLocation
                                            select s;
                                model.RPC_Telai = telai.ToList();
                                return View("VinList", model);
                            }
                            else
                            {
                                return View();
                            }
                        }
                        catch(Exception exc)
                        {
                            ViewBag.Messaggio = "Codice non riconosciuto.";
                            return View("IncorrectLogin");
                        }
                        
                    }
                    else
                    {
                        ViewBag.Messaggio = "Lunghezza codice errata.";
                        return View("IncorrectLogin");
                    }
                }
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Home";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatti.";

            return View();
        }

        public ActionResult Delete()
        {
            ViewBag.Message = "Delete.";

            return View();
        }

        public ActionResult Image()
        {
            ViewBag.Message = "Images";

            return View();
        }

        public ActionResult Edit(int ID)
        {
            RPC_Telai telai = db.RPC_Telai.Find(ID);

            return View(telai);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = " ID, IDCantiere, IDOperatore, IDLotto, IsFinished, InsertDate, Telaio, Descr")] RPC_Telai rPC_Telai,string SearchResult)
        {
            if (ModelState.IsValid)
            {
                string myIDOperatore = TempData["myIDOperatore"] as string;
                if (rPC_Telai.IsFinished == true)
                    rPC_Telai.IDOperatore = myIDOperatore.ToUpper();
                else
                    rPC_Telai.IDOperatore = null;

                db.Entry(rPC_Telai).State = EntityState.Modified;
                db.SaveChanges();

                var model = new Models.HomeModel();

                
                string mySearch = TempData["mySearch"] as string;

                var telai = from s in db.RPC_Telai
                            where s.IDCantiere.ToString() == mySearch
                            select s;
               
                model.RPC_Telai = telai.ToList();

                TempData["mySearch"] = mySearch;


                //return View("VinList", model);
                return RedirectToAction("DoRefresh", "Home");


            }
            else
            {
                return View(rPC_Telai);
            }
        }

        public ActionResult DoRefresh(string Scelta1, string SearchTelaio)
        {
            var model = new Models.HomeModel();

            if (Scelta1 != null)
                Session["Scelta1"] = Scelta1;
            else
                Scelta1 = Session["Scelta1"].ToString();

            string mySearch = TempData["mySearch"] as string;

            //string strName = Request["Scelta1"].ToString();

            if(SearchTelaio != null && SearchTelaio != "")
            {

                var telai = from s in db.RPC_Telai
                            where s.IDCantiere.ToString() == mySearch
                            && s.Telaio.Contains(SearchTelaio)
                            select s;
                model.RPC_Telai = telai.ToList();

            }

            else if (Scelta1 == "TUTTE")
            {
                var telai = from s in db.RPC_Telai
                            where s.IDCantiere.ToString() == mySearch
                            select s;
                model.RPC_Telai = telai.ToList();
            }
            else if (Scelta1 == "CHIUSE")
            {
                var telai = from s in db.RPC_Telai
                            where s.IDCantiere.ToString() == mySearch
                            && s.IsFinished == true
                            select s;
                model.RPC_Telai = telai.ToList();
            }
            else if (Scelta1 == "APERTE")
            {
                var telai = from s in db.RPC_Telai
                            where s.IDCantiere.ToString() == mySearch
                            && s.IsFinished == false
                            select s;
                model.RPC_Telai = telai.ToList();
            }
            else 
            {
                var telai = from s in db.RPC_Telai
                            where s.IDCantiere.ToString() == mySearch
                            select s;
                model.RPC_Telai = telai.ToList();
            }


            TempData["mySearch"] = mySearch;
            

            return View("VinList", model);
           
        }
    }
}