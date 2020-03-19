using Jason_CRUD.ViewModel;

using System.Linq;
using System.Web.Mvc;

namespace Jason_CRUD.Controllers
{
    public class CustomerController : BaseController
    {
        public CustomerController()
        {
        }

        public CustomerController(ApplicationUserManager userManager, ApplicationSignInManager signInManager) : base(userManager, signInManager)
        {
        }

        public ActionResult Index(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                ViewBag.Msg = message;
            }
            var customer = _context.Customers.ToList();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Index(CustomerViewModel model)
        {
            try
            {
                if (model != null && string.IsNullOrEmpty(model.Id))
                {
                    var customerModel = new Jason_CRUD.Models.Customers
                    {
                        Id = System.Guid.NewGuid().ToString(),
                        Email = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName
                    };
                    _context.Customers.Add(customerModel);
                    _context.SaveChanges();
                }
                else
                {
                    var customer = _context.Customers.FirstOrDefault(x => x.Id == model.Id);
                    if (customer != null)
                    {
                        customer.FirstName = model.FirstName;
                        customer.LastName = model.LastName;
                        customer.Email = model.Email;
                        _context.SaveChanges();
                    }
                }
                return RedirectToAction("Index", new { message = string.IsNullOrEmpty(model.Id) ? "Customer Successfully Added" : "Customer Successfully Updated" });
            }
            catch (System.Exception ex)
            {
                return RedirectToAction("Index", new { message = "Something went wrong. Please try again Later." });
            }
        }
        public ActionResult GetCustomerDetails(string id)
        {
            var vm = new CustomerViewModel();
            if (!string.IsNullOrEmpty(id))
            {
                var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
                vm = new CustomerViewModel { Id = customer.Id, Email = customer.Email, FirstName = customer.FirstName, LastName = customer.LastName };
            }
            var html = ConvertViewToString("~/Views/Customer/_AddNewCustomer.cshtml", vm);
            var jsonData = new { html };
            return Json(jsonData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Delete(string id)
        {
            try
            {
                _context.Customers.Remove(_context.Customers.FirstOrDefault(x => x.Id == id));
                _context.SaveChanges();
                return RedirectToAction("Index", new { message = "Customer Successfully Deleted" });
            }
            catch (System.Exception)
            {
                return RedirectToAction("Index", new { message = "Something went wrong. Please try again Later." });
            }
        }
    }
}
