using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AsTiKa.Models;

namespace AsTiKa.Controllers
{
    public class Asiakkaan_omaisuusController : Controller
    {
        private AsTiKaEntities db = new AsTiKaEntities();

        // GET: Asiakkaan_omaisuus
        public ActionResult Index()
        {
            return View(db.Asiakkaan_omaisuus.ToList());
        }

        // GET: Asiakkaan_omaisuus/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asiakkaan_omaisuus asiakkaan_omaisuus = db.Asiakkaan_omaisuus.Find(id);
            if (asiakkaan_omaisuus == null)
            {
                return HttpNotFound();
            }
            return View(asiakkaan_omaisuus);
        }

        // GET: Asiakkaan_omaisuus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asiakkaan_omaisuus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Henkilökohtaiset_tavarat,Huonekalut,Tekstiilit,Vuode_ja_liinavaatteet")] Asiakkaan_omaisuus asiakkaan_omaisuus)
        {
            if (ModelState.IsValid)
            {
                db.Asiakkaan_omaisuus.Add(asiakkaan_omaisuus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asiakkaan_omaisuus);
        }

        // GET: Asiakkaan_omaisuus/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asiakkaan_omaisuus asiakkaan_omaisuus = db.Asiakkaan_omaisuus.Find(id);
            if (asiakkaan_omaisuus == null)
            {
                return HttpNotFound();
            }
            return View(asiakkaan_omaisuus);
        }

        // POST: Asiakkaan_omaisuus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Henkilökohtaiset_tavarat,Huonekalut,Tekstiilit,Vuode_ja_liinavaatteet")] Asiakkaan_omaisuus asiakkaan_omaisuus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asiakkaan_omaisuus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asiakkaan_omaisuus);
        }

        // GET: Asiakkaan_omaisuus/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asiakkaan_omaisuus asiakkaan_omaisuus = db.Asiakkaan_omaisuus.Find(id);
            if (asiakkaan_omaisuus == null)
            {
                return HttpNotFound();
            }
            return View(asiakkaan_omaisuus);
        }

        // POST: Asiakkaan_omaisuus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Asiakkaan_omaisuus asiakkaan_omaisuus = db.Asiakkaan_omaisuus.Find(id);
            db.Asiakkaan_omaisuus.Remove(asiakkaan_omaisuus);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
