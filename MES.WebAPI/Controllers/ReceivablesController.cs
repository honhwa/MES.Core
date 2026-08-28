using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ReceivablesController : ControllerBase
    {
        [Route("api/GetReceivablesByProjectNo"), HttpGet]
        public CommonRep<專案應收沖款> GetReceivablesByProjectNo(string projectNo)
        {
            CommonRep<專案應收沖款> commonRep = new CommonRep<專案應收沖款>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                commonRep.result = middle.getByProjectNo(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateReceivables"), HttpPost]
        public CommonRep<string> UpdateReceivables([FromBody] 專案應收沖款 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                middle.updateReceivables(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetPaymentTermList"), HttpGet]
        public CommonRep<付款方式> GetPaymentTermList()
        {
            CommonRep<付款方式> commonRep = new CommonRep<付款方式>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                commonRep.resultList = middle.getPaymentTermList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetCurrencyList"), HttpGet]
        public CommonRep<string> GetCurrencyList()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                commonRep.resultList = middle.getCurrencyList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetCustomerNameByCode"), HttpGet]
        public CommonRep<string> GetCustomerNameByCode(string custCode)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                commonRep.result = middle.getCustomerNameByCode(custCode);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetReceivablesDetailList"), HttpGet]
        public CommonRep<專案應收沖款明細> GetReceivablesDetailList(string projectNo)
        {
            CommonRep<專案應收沖款明細> commonRep = new CommonRep<專案應收沖款明細>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                commonRep.resultList = middle.getDetailList(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SaveReceivablesDetailList"), HttpPost]
        public CommonRep<string> SaveReceivablesDetailList([FromBody] SaveReceivablesDetailRequest request)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                middle.saveDetailList(request.ProjectNo, request.DetailList);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetReceivablesOverviewList"), HttpGet]
        public CommonRep<專案應收沖款總覽列表> GetReceivablesOverviewList(string custCode)
        {
            CommonRep<專案應收沖款總覽列表> commonRep = new CommonRep<專案應收沖款總覽列表>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                commonRep.resultList = middle.getOverviewList(custCode);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetReceivablesCustomerFilterList"), HttpGet]
        public CommonRep<零件單客戶篩選列表> GetReceivablesCustomerFilterList()
        {
            CommonRep<零件單客戶篩選列表> commonRep = new CommonRep<零件單客戶篩選列表>();
            ReceivablesMiddle middle = new ReceivablesMiddle();
            try
            {
                commonRep.resultList = middle.getCustomerFilterList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
    }

    public class SaveReceivablesDetailRequest
    {
        public string ProjectNo { get; set; }
        public List<專案應收沖款明細> DetailList { get; set; }
    }
}
