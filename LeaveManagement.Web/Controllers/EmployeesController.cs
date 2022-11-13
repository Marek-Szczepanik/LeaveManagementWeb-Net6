﻿using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Controllers
    {
    public class EmployeesController : Controller
        {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository, ILeaveTypeRepository leaveTypeRepository)
            {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
            }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
            {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
            }

        // GET: EmployeesController/ViewAllocations/employeeId
        public async Task<ActionResult> ViewAllocations(string id)
            {
            var model = await leaveAllocationRepository.GetEmployeeAllocation(id);
            return View(model);
            }

        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
            {
            var model = await leaveAllocationRepository.GetEmployeeAllocation(id);
            if (model == null)
                {
                return NotFound();
                }
            return View(model);
            }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
            {
            try
                {
                if (ModelState.IsValid)
                    {
                    if (await leaveAllocationRepository.UpdateEmployeeAllocation(model))
                        {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                        }

                    return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId});
                    }
                }
            catch(Exception ex)
                {
                ModelState.AddModelError(string.Empty, "An Error Has Occured. Please Try Again Later");
                }
            model.Employee = mapper.Map<EmployeeListVM>(userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
            }
        }
    }