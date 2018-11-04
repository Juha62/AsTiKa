using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AsTiKa.Models;

namespace AsTiKa.Controllers
{
    public class VuokrasopimusController : Controller
    {
        private AsTiKaEntities db = new AsTiKaEntities();

        // GET: Vuokrasopimus
        public ActionResult Index()
        {
            return View(db.Vuokrasopimus.ToList());
        }

        // GET: Vuokrasopimus/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vuokrasopimus vuokrasopimus = db.Vuokrasopimus.Find(id);
            if (vuokrasopimus == null)
            {
                return HttpNotFound();
            }
            return View(vuokrasopimus);
        }

        // GET: Vuokrasopimus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vuokrasopimus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Vuokramäärä,Huoneiston_numero,Sopijapuolen_tiedot")] Vuokrasopimus vuokrasopimus)
        {
            if (ModelState.IsValid)
            {
                db.Vuokrasopimus.Add(vuokrasopimus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vuokrasopimus);
        }

        // GET: Vuokrasopimus/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vuokrasopimus vuokrasopimus = db.Vuokrasopimus.Find(id);
            if (vuokrasopimus == null)
            {
                return HttpNotFound();
            }
            return View(vuokrasopimus);
        }

        // POST: Vuokrasopimus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Vuokramäärä,Huoneiston_numero,Sopijapuolen_tiedot")] Vuokrasopimus vuokrasopimus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vuokrasopimus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vuokrasopimus);
        }

        // GET: Vuokrasopimus/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vuokrasopimus vuokrasopimus = db.Vuokrasopimus.Find(id);
            if (vuokrasopimus == null)
            {
                return HttpNotFound();
            }
            return View(vuokrasopimus);
        }

        // POST: Vuokrasopimus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            Vuokrasopimus vuokrasopimus = db.Vuokrasopimus.Find(id);
            db.Vuokrasopimus.Remove(vuokrasopimus);
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
