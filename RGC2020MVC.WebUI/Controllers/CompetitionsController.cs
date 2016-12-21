using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RGC2020MVC.DAL.Data;
using RGC2020MVC.DAL.Repositories;
using RGC2020MVC.Model;
using RGC2020MVC.WebUI.ViewModels;

namespace RGC2020MVC.WebUI.Controllers
{
    public class CompetitionsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Competitions
        public ActionResult Index()
        {
            var competitions = db.Competitions.Include(c => c.CompetitionType);
            return View(competitions.ToList());
        }

        // GET: Competitions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competition competition = db.Competitions.Find(id);
            if (competition == null)
            {
                return HttpNotFound();
            }
            return View(competition);
        }

        // GET: Competitions/Create
        public ActionResult Create()
        {
            CompetitionTypeRepository competitionTypeRepository = new CompetitionTypeRepository(db);
            CreateCompetitionViewModel createCompetitionViewModel = new CreateCompetitionViewModel();
            createCompetitionViewModel.CompetitionTypes = competitionTypeRepository.GetAll().ToList();
            createCompetitionViewModel.Date = DateTime.Now;           
            createCompetitionViewModel.PageTitle = "Create Competition";


            return View(createCompetitionViewModel);
        }

        // POST: Competitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCompetitionViewModel createCompetitionViewModel)
        {
            if (ModelState.IsValid)
            {
                CompetitionRepository competitionRepository = new CompetitionRepository(db);
                Competition competition = new Competition();

                competition.Name = createCompetitionViewModel.Name;
                competition.CompetitionType = null;
                competition.CompetitionTypeId = createCompetitionViewModel.CompetitionTypeId;
                competition.Date = createCompetitionViewModel.Date;
                competition.TotalMoney = 0;
                competition.CreatedAt = DateTime.Now;
                competition.UpdatedAt = DateTime.Now;

                competitionRepository.Insert(competition);
                competitionRepository.Commit();
                return RedirectToAction("Index");
            }

            CompetitionTypeRepository competitionTypeRepository = new CompetitionTypeRepository(db);
            createCompetitionViewModel.CompetitionTypes = competitionTypeRepository.GetAll().ToList();
            createCompetitionViewModel.PageTitle = "Create Competition";
            return View(createCompetitionViewModel);
        }

        // GET: Competitions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competition competition = db.Competitions.Find(id);
            if (competition == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompetitionTypeId = new SelectList(db.CompetitionTypes, "Id", "Description", competition.CompetitionTypeId);
            return View(competition);
        }

        // POST: Competitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Date,CompetitionTypeId,TotalMoney,CreatedAt,UpdatedAt")] Competition competition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(competition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompetitionTypeId = new SelectList(db.CompetitionTypes, "Id", "Description", competition.CompetitionTypeId);
            return View(competition);
        }

        // GET: Competitions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Competition competition = db.Competitions.Find(id);
            if (competition == null)
            {
                return HttpNotFound();
            }
            return View(competition);
        }

        // POST: Competitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Competition competition = db.Competitions.Find(id);
            db.Competitions.Remove(competition);
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
