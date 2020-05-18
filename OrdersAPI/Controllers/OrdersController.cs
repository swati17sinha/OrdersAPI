using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrdersAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly ILogger<OrdersController> _logger;
        private readonly List<Order> orders = new List<Order>()
        {
            new Order(){OrderId=1, OrderAmount=250, OrderDate= new DateTime(2020,04,14), UserId=1},
            new Order(){OrderId=2, OrderAmount=450, OrderDate= new DateTime(2020,04,15), UserId=1},
            new Order(){OrderId=3, OrderAmount=250, OrderDate= new DateTime(2020,04,14), UserId=2},
            new Order(){OrderId=4, OrderAmount=450, OrderDate= new DateTime(2020,04,15), UserId=2}
        };
        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            return orders.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<List<Order>> Get(int id)
        {
            return orders.Where(o => o.UserId.Equals(id)).ToList();
        }
    }
}