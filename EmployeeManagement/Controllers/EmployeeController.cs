using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IBusinessService _businessService;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(IBusinessService businessService, ILogger<EmployeeController> logger)
        {
            _businessService = businessService;
            _logger = logger;
        }
        // GET: api/<EmployeeController>
        [Route("GetAllEmployee")]
        [HttpGet]
        public async Task<ActionResult<Object>> GetAllEmployee()
        {
            var employee = await _businessService.GetAllEmployee();
            return Ok(employee);
        }

        
        // GET api/<EmployeeController>/5
        [Route("GetEmployeeById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Object>> GetEmployeeById(int id)
        {
            var user = await _businessService.GetEmployeeById(id);
            return Ok(user);
        }

        // POST api/<EmployeeController>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> AddEmployee(EmployeeDto employeeDto)
        {
            try
            {
                var result = await _businessService.AddEmployee(employeeDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message.ToString());
                return null;

            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        public async Task<ActionResult<EmployeeDto>> UpdateStudent(EmployeeDto studentDto)
        {
            try
            {
                var result = await _businessService.UpdateEmployee(studentDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message.ToString());
                return null;

            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeDto>> DeleteEmployee(EmployeeDto employeeDto)
        {
            try
            {
                var result = await _businessService.DeleteEmployee(employeeDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message.ToString());
                return null;

            }
        }
    }
}
