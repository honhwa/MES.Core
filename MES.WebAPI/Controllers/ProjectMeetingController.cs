using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ProjectMeetingController : ControllerBase
    {
        [Route("api/GetMeetingTrackList"), HttpGet]
        public CommonRep<專案追蹤履歷列表> GetMeetingTrackList(string projectNo)
        {
            CommonRep<專案追蹤履歷列表> commonRep = new CommonRep<專案追蹤履歷列表>();
            ProjectMeetingMiddle middle = new ProjectMeetingMiddle();
            try
            {
                commonRep.resultList = middle.getMeetingTrackList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetMeetingRecord"), HttpGet]
        public CommonRep<專案管理紀錄表> GetMeetingRecord(string recordNo)
        {
            CommonRep<專案管理紀錄表> commonRep = new CommonRep<專案管理紀錄表>();
            ProjectMeetingMiddle middle = new ProjectMeetingMiddle();
            try
            {
                commonRep.result = middle.getMeetingRecord(recordNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/InsertMeetingRecord"), HttpPost]
        public CommonRep<string> InsertMeetingRecord([FromBody] 專案管理紀錄表 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProjectMeetingMiddle middle = new ProjectMeetingMiddle();
            try
            {
                middle.insertMeetingRecord(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateMeetingRecord"), HttpPost]
        public CommonRep<string> UpdateMeetingRecord([FromBody] 專案管理紀錄表 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProjectMeetingMiddle middle = new ProjectMeetingMiddle();
            try
            {
                middle.updateMeetingRecord(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetMeetingDetailList"), HttpGet]
        public CommonRep<專案管理紀錄明細> GetMeetingDetailList(string recordNo)
        {
            CommonRep<專案管理紀錄明細> commonRep = new CommonRep<專案管理紀錄明細>();
            ProjectMeetingMiddle middle = new ProjectMeetingMiddle();
            try
            {
                commonRep.resultList = middle.getMeetingDetailList(recordNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveMeetingDetailList"), HttpPost]
        public CommonRep<string> SaveMeetingDetailList([FromBody] SaveMeetingDetailRequest request)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProjectMeetingMiddle middle = new ProjectMeetingMiddle();
            try
            {
                middle.saveMeetingDetailList(request.RecordNo, request.List);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetPendingFeedbackList"), HttpGet]
        public CommonRep<專案待回報事項列表> GetPendingFeedbackList()
        {
            CommonRep<專案待回報事項列表> commonRep = new CommonRep<專案待回報事項列表>();
            ProjectMeetingMiddle middle = new ProjectMeetingMiddle();
            try
            {
                commonRep.resultList = middle.getPendingFeedbackList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetActiveAccountList"), HttpGet]
        public CommonRep<account> GetActiveAccountList()
        {
            CommonRep<account> commonRep = new CommonRep<account>();
            ProjectMeetingMiddle middle = new ProjectMeetingMiddle();
            try
            {
                commonRep.resultList = middle.getActiveAccountList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
    }

    public class SaveMeetingDetailRequest
    {
        public string RecordNo { get; set; }
        public List<專案管理紀錄明細> List { get; set; }
    }
}
