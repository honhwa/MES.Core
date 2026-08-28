using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class WorkOrderScheduleController : ControllerBase
    {
        [Route("api/GetWorkOrderScheduleList"), HttpGet]
        public CommonRep<工令時程表> GetWorkOrderScheduleList(string projectNo)
        {
            CommonRep<工令時程表> commonRep = new CommonRep<工令時程表>();
            WorkOrderScheduleMiddle middle = new WorkOrderScheduleMiddle();
            try
            {
                commonRep.resultList = middle.getScheduleList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveWorkOrderScheduleList"), HttpPost]
        public CommonRep<string> SaveWorkOrderScheduleList([FromBody] SaveWorkOrderScheduleRequest request)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderScheduleMiddle middle = new WorkOrderScheduleMiddle();
            try
            {
                middle.saveScheduleList(request.ProjectNo, request.List);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetProcedureList"), HttpGet]
        public CommonRep<工序設定> GetProcedureList()
        {
            CommonRep<工序設定> commonRep = new CommonRep<工序設定>();
            WorkOrderScheduleMiddle middle = new WorkOrderScheduleMiddle();
            try
            {
                commonRep.resultList = middle.getProcedureList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetWorkOrderScheduleHoursComparison"), HttpGet]
        public CommonRep<工令時程統計> GetWorkOrderScheduleHoursComparison(string projectNo)
        {
            CommonRep<工令時程統計> commonRep = new CommonRep<工令時程統計>();
            WorkOrderScheduleMiddle middle = new WorkOrderScheduleMiddle();
            try
            {
                commonRep.resultList = middle.getHoursComparison(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
    }

    public class SaveWorkOrderScheduleRequest
    {
        public string ProjectNo { get; set; }
        public List<工令時程表> List { get; set; }
    }
}
