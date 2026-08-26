using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class EngineeringAnalysisController : ControllerBase
    {
        [Route("api/GetEngineeringModuleList"), HttpGet]
        public CommonRep<工程分析表> GetEngineeringModuleList(string projectNo)
        {
            CommonRep<工程分析表> commonRep = new CommonRep<工程分析表>();
            EngineeringAnalysisMiddle middle = new EngineeringAnalysisMiddle();
            try
            {
                commonRep.resultList = middle.getModuleList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetAllDesignModuleList"), HttpGet]
        public CommonRep<設計模組表> GetAllDesignModuleList()
        {
            CommonRep<設計模組表> commonRep = new CommonRep<設計模組表>();
            EngineeringAnalysisMiddle middle = new EngineeringAnalysisMiddle();
            try
            {
                commonRep.resultList = middle.getAllDesignModuleList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveEngineeringModuleList"), HttpPost]
        public CommonRep<string> SaveEngineeringModuleList([FromBody] SaveModuleListRequest request)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            EngineeringAnalysisMiddle middle = new EngineeringAnalysisMiddle();
            try
            {
                middle.saveModuleList(request.ProjectNo, request.List);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
    }

    public class SaveModuleListRequest
    {
        public string ProjectNo { get; set; }
        public List<工程分析表> List { get; set; }
    }
}
