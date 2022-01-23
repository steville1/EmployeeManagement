using AutoMapper;
using EmployeeManagement.Application.Contract;
using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.DTOs.Validator;
using EmployeeManagement.Application.Responses;
using EmployeeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features
{
    public class BusinessService : IBusinessService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BusinessService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> AddEmployee(EmployeeDto employeeDto)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateEmployeeDtoValidator();
            var validationResult = await validator.ValidateAsync(employeeDto);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var employee = _mapper.Map<Employee>(employeeDto);
                employee = await _unitOfWork.Employee.Add(employee);
                response.Success = true;
                response.Message = "Creation Successful";
            }

            return response;
        }

        public async Task<BaseCommandResponse> DeleteEmployee(EmployeeDto employeeDto)
        {
            var response = new BaseCommandResponse();
            var employee = _mapper.Map<Employee>(employeeDto);
            await _unitOfWork.Employee.Delete(employee);
            response.Success = true;
            response.Message = "Creation Successful";
            return response;
        }

        public async Task<object> GetAllEmployee()
        {
            var allEmployee = await _unitOfWork.Employee.GetAll();
            return allEmployee;
        }

        public async Task<object> GetEmployeeById(int id)
        {
            var allEmployee = await _unitOfWork.Employee.Get(id);
            return allEmployee;
        }

        public async Task<BaseCommandResponse> UpdateEmployee(EmployeeDto employeeDto)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateEmployeeDtoValidator();
            var validationResult = await validator.ValidateAsync(employeeDto);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var employee = _mapper.Map<Employee>(employeeDto);
                await _unitOfWork.Employee.Update(employee);
                response.Success = true;
                response.Message = "Creation Successful";
            }

            return response;
        }
    }
}
