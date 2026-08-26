using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class WorkOrderController : ControllerBase
    {
        [Route("api/GetWorkOrderOverviewList"), HttpGet]
        public CommonRep<工令單> GetWorkOrderOverviewList(string projectNo, string custName, string machineType, bool onlyOpen)
        {
            CommonRep<工令單> commonRep = new CommonRep<工令單>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                commonRep.resultList = workOrderMiddle.getWorkOrderOverviewList(projectNo, custName, machineType, onlyOpen);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetWorkOrderDetail"), HttpGet]
        public CommonRep<工令單> GetWorkOrderDetail(string projectNo)
        {
            CommonRep<工令單> commonRep = new CommonRep<工令單>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                commonRep.result = workOrderMiddle.getWorkOrderByProjectNo(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/InsertWorkOrder"), HttpPost]
        public CommonRep<string> InsertWorkOrder([FromBody] 工令單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.insertWorkOrder(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateWorkOrder"), HttpPost]
        public CommonRep<string> UpdateWorkOrder([FromBody] 工令單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.updateWorkOrder(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/DeleteWorkOrder"), HttpGet]
        public CommonRep<string> DeleteWorkOrder(string projectNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.deleteWorkOrder(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ApproveWorkOrder"), HttpGet]
        public CommonRep<string> ApproveWorkOrder(string projectNo, string username)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.approveWorkOrder(projectNo, username);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UnapproveWorkOrder"), HttpGet]
        public CommonRep<string> UnapproveWorkOrder(string projectNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.unapproveWorkOrder(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/CloseWorkOrder"), HttpGet]
        public CommonRep<string> CloseWorkOrder(string projectNo, bool closed)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.closeWorkOrder(projectNo, closed);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        // ── 工程分析表總覽 (P-工程總覽) ──────────────────────────────────
        [Route("api/GetEngineeringOverviewList"), HttpGet]
        public CommonRep<工令單> GetEngineeringOverviewList()
        {
            CommonRep<工令單> commonRep = new CommonRep<工令單>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                commonRep.resultList = workOrderMiddle.getEngineeringOverviewList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        // ── 工程分析表 (P-工程) ────────────────────────────────────────
        [Route("api/UpdateEngineeringAudit"), HttpGet]
        public CommonRep<string> UpdateEngineeringAudit(string projectNo, string createdBy, string createdDate, string modifiedBy, string modifiedDate)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.updateEngineeringAudit(projectNo, createdBy, createdDate, modifiedBy, modifiedDate);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ApproveEngineering"), HttpGet]
        public CommonRep<string> ApproveEngineering(string projectNo, string username)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.approveEngineering(projectNo, username);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UnapproveEngineering"), HttpGet]
        public CommonRep<string> UnapproveEngineering(string projectNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.unapproveEngineering(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        // ── 自訂單新增機台2025 (Command81) ──────────────────────────────
        [Route("api/GetUnconvertedOrderMachineList"), HttpGet]
        public CommonRep<訂單機台候選> GetUnconvertedOrderMachineList()
        {
            CommonRep<訂單機台候選> commonRep = new CommonRep<訂單機台候選>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                commonRep.resultList = workOrderMiddle.getUnconvertedOrderMachineList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ConvertOrderMachineToWorkOrder"), HttpGet]
        public CommonRep<string> ConvertOrderMachineToWorkOrder(string projectNo, string username)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            WorkOrderMiddle workOrderMiddle = new WorkOrderMiddle();
            try
            {
                workOrderMiddle.convertOrderMachineToWorkOrder(projectNo, username);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
    }
}
