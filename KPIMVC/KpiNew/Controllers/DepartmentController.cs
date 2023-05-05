using KpiNew.Dtos;
using KpiNew.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace KpiNew.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            var department = await _departmentService.GetAllDepartmentAsync();
            if (department.Data == null)
            {
                return NotFound();
            }
            return View(department.Data);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateDepartmentRequestModel model)
        {
            await _departmentService.AddDepartmentAsync(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var department = await _departmentService.GetDepartmentAsyncById(id);
            if (department.Data == null)
            {
                return ViewBag("Department not found");
            }
            return View(department.Data);
        }

        
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var department = await _departmentService.GetDepartmentAsyncById(id);
            if (department == null)
            {
                return NotFound();
            }

            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdateDepartmentRequestModel model)
        {
            await _departmentService.UpdateDepartmentAsync(id, model);
            return RedirectToAction("Index");
        }

        
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var department = await _departmentService.GetDepartmentAsyncById(id);
            if (department.Data == null)
            {
                return ViewBag("Department Not Found");

            }
            return View(department.Data);
        }

        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _departmentService.DeleteDepartmentAsync(id);
            return RedirectToAction("Index");
        }


    }
}