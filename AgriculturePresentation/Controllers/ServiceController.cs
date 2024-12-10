using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
        
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                Service service = new Service
                {
                  
                    Title = model.Title,
                    Image = model.Image,
                    Description = model.Description,
                    Class1 = model.Class1,
                    Class2 = model.Class2,
                   
                };
           

                _serviceService.Insert(service);
                return RedirectToAction("Index"); 
            }

           
            return View(model);
        }


        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.GetById(id);
            _serviceService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var service = _serviceService.GetById(id);
            if (service == null)
            {
                
                return NotFound();
            }
            var model = new ServiceAddViewModel
            {
                ServiceId = service.ServiceId,
                Title = service.Title,
                Image = service.Image,
                Description = service.Description,
                Class1 = service.Class1,
                Class2 = service.Class2,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                var service = _serviceService.GetById(model.ServiceId);
                if (service == null)
                {
                    
                    return NotFound();
                } 
                service.Title = model.Title;
                service.Image = model.Image;
                service.Description = model.Description;
                service.Class1 = model.Class1;
                service.Class2 = model.Class2;
                _serviceService.Update(service);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
