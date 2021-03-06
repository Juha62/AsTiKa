﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AsTiKa.Models;

namespace AsTiKa.Controllers
{
    public class Tehtävälista_asukkaan_saapuessa_palvelutaloonController : Controller
    {
        private AsTiKaEntities1 db = new AsTiKaEntities1();

        // GET: Tehtävälista_asukkaan_saapuessa_palvelutaloon
        public ActionResult Index()
        {
            return View(db.Tehtävälista_asukkaan_saapuessa_palvelutaloon.ToList());
        }

        // GET: Tehtävälista_asukkaan_saapuessa_palvelutaloon/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tehtävälista_asukkaan_saapuessa_palvelutaloon tehtävälista_asukkaan_saapuessa_palvelutaloon = db.Tehtävälista_asukkaan_saapuessa_palvelutaloon.Find(id);
            if (tehtävälista_asukkaan_saapuessa_palvelutaloon == null)
            {
                return HttpNotFound();
            }
            return View(tehtävälista_asukkaan_saapuessa_palvelutaloon);
        }

        // GET: Tehtävälista_asukkaan_saapuessa_palvelutaloon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tehtävälista_asukkaan_saapuessa_palvelutaloon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Omahoitajan_nimeäminen,Tilojen_ja_päivärytminen_esittely,Asukasopas,Rekisteriselosteesta_kertominen,Asiakkaan_oikeuksien_ja_velvollisuuksien_läpi_käyminen,Vuokrasopimuksen_tekeminen,Asumistuen_hakeminen,Eläkkeensaajan_hoitotuen_hakeminen,Muuttoilmoitus,Valtakirja_apteekkia_varten,E_resepti_suostumus,Asiakasmaksuista_tiedottaminen,Asukaskansion_laatiminen,Henkilötietojen_kirjaaminen,Raha_asioiden_hoito_ja_edunvalvojan_nimeäminen,Omaisuusluettelon_laatiminen")] Tehtävälista_asukkaan_saapuessa_palvelutaloon tehtävälista_asukkaan_saapuessa_palvelutaloon)
        {
            if (ModelState.IsValid)
            {
                db.Tehtävälista_asukkaan_saapuessa_palvelutaloon.Add(tehtävälista_asukkaan_saapuessa_palvelutaloon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tehtävälista_asukkaan_saapuessa_palvelutaloon);
        }

        // GET: Tehtävälista_asukkaan_saapuessa_palvelutaloon/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tehtävälista_asukkaan_saapuessa_palvelutaloon tehtävälista_asukkaan_saapuessa_palvelutaloon = db.Tehtävälista_asukkaan_saapuessa_palvelutaloon.Find(id);
            if (tehtävälista_asukkaan_saapuessa_palvelutaloon == null)
            {
                return HttpNotFound();
            }
            return View(tehtävälista_asukkaan_saapuessa_palvelutaloon);
        }

        // POST: Tehtävälista_asukkaan_saapuessa_palvelutaloon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Omahoitajan_nimeäminen,Tilojen_ja_päivärytminen_esittely,Asukasopas,Rekisteriselosteesta_kertominen,Asiakkaan_oikeuksien_ja_velvollisuuksien_läpi_käyminen,Vuokrasopimuksen_tekeminen,Asumistuen_hakeminen,Eläkkeensaajan_hoitotuen_hakeminen,Muuttoilmoitus,Valtakirja_apteekkia_varten,E_resepti_suostumus,Asiakasmaksuista_tiedottaminen,Asukaskansion_laatiminen,Henkilötietojen_kirjaaminen,Raha_asioiden_hoito_ja_edunvalvojan_nimeäminen,Omaisuusluettelon_laatiminen")] Tehtävälista_asukkaan_saapuessa_palvelutaloon tehtävälista_asukkaan_saapuessa_palvelutaloon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tehtävälista_asukkaan_saapuessa_palvelutaloon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tehtävälista_asukkaan_saapuessa_palvelutaloon);
        }

        // GET: Tehtävälista_asukkaan_saapuessa_palvelutaloon/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tehtävälista_asukkaan_saapuessa_palvelutaloon tehtävälista_asukkaan_saapuessa_palvelutaloon = db.Tehtävälista_asukkaan_saapuessa_palvelutaloon.Find(id);
            if (tehtävälista_asukkaan_saapuessa_palvelutaloon == null)
            {
                return HttpNotFound();
            }
            return View(tehtävälista_asukkaan_saapuessa_palvelutaloon);
        }

        // POST: Tehtävälista_asukkaan_saapuessa_palvelutaloon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tehtävälista_asukkaan_saapuessa_palvelutaloon tehtävälista_asukkaan_saapuessa_palvelutaloon = db.Tehtävälista_asukkaan_saapuessa_palvelutaloon.Find(id);
            db.Tehtävälista_asukkaan_saapuessa_palvelutaloon.Remove(tehtävälista_asukkaan_saapuessa_palvelutaloon);
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
