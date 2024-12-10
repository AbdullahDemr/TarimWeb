using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TopAnnouncementController : Controller
    {
        private readonly ITopAnnouncementService _topAnnouncementService;

        public TopAnnouncementController(ITopAnnouncementService topAnnouncementService)
        {
            _topAnnouncementService = topAnnouncementService;
        }
        public IActionResult Index()
        {
            var values = _topAnnouncementService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTopAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTopAnnouncement(TopAnnouncement topAnnouncement)
        {
            topAnnouncement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            topAnnouncement.Status = false;
            _topAnnouncementService.Insert(topAnnouncement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTopAnnouncement(int id)
        {
            var values = _topAnnouncementService.GetById(id);
            _topAnnouncementService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTopAnnouncement(int id)
        {
            var values = _topAnnouncementService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTopAnnouncement(TopAnnouncement topAnnouncement)
        {
            _topAnnouncementService.Update(topAnnouncement);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _topAnnouncementService.TopAnnouncementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _topAnnouncementService.TopAnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
