using DrYoReparo.Backend.Data;
using DrYoReparo.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrYoReparo.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersServicesController : ControllerBase
    {
        private readonly DataContext _context;

        public OrdersServicesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.OrdersServices.OrderBy(t => t.DateIncome).ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var task = _context.OrdersServices.FirstOrDefault(x => x.Id == id);
            if(task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public IActionResult Post(OrderService orderService)
        {
            _context.Add(orderService);
            _context.SaveChanges();
            return Ok(orderService);
        }

        [HttpPut]
        public IActionResult Put(OrderService orderService) 
        {
            var task = _context.OrdersServices.FirstOrDefault(x => x.Id == orderService.Id);
            if (task == null)
            {
                return NotFound();
            }

            task.Brand = orderService.Brand;
            task.CommentTechnical = orderService.CommentTechnical;
            task.DateIncome = orderService.DateIncome;
            task.DateWithdrawal = orderService.DateWithdrawal;
            task.Diagnosis = orderService.Diagnosis;
            task.Email = orderService.Email;
            task.EquipmentType = orderService.EquipmentType;
            task.LastnameOwner = orderService.LastnameOwner;
            task.NameOwner = orderService.NameOwner;
            task.Phone = orderService.Phone;
            task.RepairStatus = orderService.RepairStatus;
            task.RepairValue = orderService.RepairValue;

            _context.Update(task);
            _context.SaveChanges();
            return Ok(task);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var task = _context.OrdersServices.FirstOrDefault(x => x.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            _context.Remove(task);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
