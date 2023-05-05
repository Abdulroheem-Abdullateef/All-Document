using KpiNew.Dtos;
using KpiNew.Interface;
using KpiNew.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KpiNew.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IRoleService _roleService;
        private readonly IUserService _userService;

        public EmployeeController(IEmployeeService employeeService, IRoleService roleService,
         IUserService userService, IWebHostEnvironment webHostEnvironment)
        {
            _employeeService = employeeService;
            _roleService = roleService;
            _userService = userService;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var employee = await _employeeService.GetAllEmployeeAsync();
            if (employee == null)
            {
                return NotFound();
            }

            return View();
        }

        public async Task<IActionResult> Create()
        {
            var role = await _employeeService.GetAllEmployeeAsync();
             ViewData["Roles"] = new SelectList(role.Data, "Id", "Name");

            return View();
        }

        [HttpPost]
         public async Task<IActionResult> Create(CreateEmployeeRequestModel model, IFormFile employeePhoto)
        {
            if (employeePhoto != null)
            {
                string employeePhotoPath = Path.Combine(_webHostEnvironment.WebRootPath, "employeePhotos");
                Directory.CreateDirectory(employeePhotoPath);
                string contentType = employeePhoto.ContentType.Split('/')[1];
                string employeeImage = $"AD{Guid.NewGuid()}.{contentType}";
                string fullPath = Path.Combine(employeePhotoPath, employeeImage);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    employeePhoto.CopyTo(fileStream);
                }
                model.EmployeeImage = employeeImage;



            }

            await _employeeService.AddEmployeeAsync(model);
            return RedirectToAction("Index");
        } 

        
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee.Data == null)
            {
                return NotFound();
            }
            return View(employee.Data);
        }

        [HttpGet]
        
        public async Task<IActionResult> Update(int id)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdateEmployeeRequestModel model)
        {
            await _employeeService.UpdateEmployeeAsync(id, model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {

            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee.Data);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _employeeService.DeleteEmployeeAsync(id);
            return RedirectToAction("Index");
        }


        
    }
}