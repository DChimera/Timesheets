using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimesheetsApp.Entities;
using TimesheetsApp.Models;

namespace TimesheetsApp.Controllers
{
    public class TimesheetsController : Controller
    {
        private TimesheetsDbContext _timesheetsDbContext;
        public TimesheetsController(TimesheetsDbContext timesheetDbContext)
        {
            _timesheetsDbContext = timesheetDbContext;
        }
        public IActionResult Items()
        {
            var timesheets = _timesheetsDbContext.Timesheets.ToList();

            return View(timesheets);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            TimesheetViewModel timesheetViewModel = new TimesheetViewModel()
            {
                ActiveTimesheet = _timesheetsDbContext.Timesheets.Find(id)
            };
            return View(timesheetViewModel);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            TimesheetViewModel timesheetViewModel = new TimesheetViewModel()
            {
                ActiveTimesheet = _timesheetsDbContext.Timesheets.Find(id)
            };

            return View(timesheetViewModel);
        }
        [HttpPost]
        public IActionResult Edit(TimesheetViewModel timesheetViewModel)
        {
            if (ModelState.IsValid)
            {
                _timesheetsDbContext.Timesheets.Update(timesheetViewModel.ActiveTimesheet);
                _timesheetsDbContext.SaveChanges();
                return RedirectToAction("Items", "Timesheets");
            }
            else
            {
                return View(timesheetViewModel);
            }
        }


        [HttpGet]
        public IActionResult Add(int id)
        {
            TimesheetViewModel timesheetViewModel = new TimesheetViewModel()
            {
                ActiveTimesheet = _timesheetsDbContext.Timesheets.Find(id)
            };
            return View(timesheetViewModel);
        }
        [HttpPost]
        public IActionResult Add(TimesheetsDbContext timesheetDbContext)
        {
            return View(timesheetDbContext);
        }
        public IActionResult Index(TimesheetViewModel timesheetViewModel)
        {
            if (ModelState.IsValid)
            {
                _timesheetsDbContext.Timesheets.Update(timesheetViewModel.ActiveTimesheet);
                _timesheetsDbContext.SaveChanges();
                return RedirectToAction("Items", "Timesheets");
            }
            else
            {
                return View(timesheetViewModel);
            }
        }
    }
}
