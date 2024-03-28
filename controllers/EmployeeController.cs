using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPOCService.functionality;
using finalPOCService.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace finalPOCService.controllers
{
    [ApiController]
    [Route("exl/[controller]")]
    public class EmployeeController : Controller
    {
        IEmployeeFunctionality functionality;

        public EmployeeController(IEmployeeFunctionality _functionality)
        {
            functionality = _functionality;
        }


        [HttpGet]
        [Route("getEmployeeDetails")]
        public IActionResult getEmployeeDetails()
        {
            return Ok(functionality.getEmployeeDetails());
        }


        [HttpGet]
        [Route("searchEmployee")]
        public IActionResult searchEmployee(int id)
        {
            return Ok(functionality.searchEmployee(id));
        }


        [HttpPost]
        [Route("addEmployee")]
        public IActionResult addEmployee(Employee emp)
        {
            return Ok(functionality.addEmployee(emp));
        }
    }
}