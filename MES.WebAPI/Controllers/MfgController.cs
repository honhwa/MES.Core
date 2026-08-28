using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class MfgController : ControllerBase
    {
        #region 零件申請單
        /// <summary>
        /// 零件申請單取號
        /// </summary>
        /// <returns></returns>
        [Route("api/GetMiscMfgNo"), HttpGet]
        public CommonRep<string> GetMiscMfgNo()
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                commonRep.result = mfgMiddle.getMiscMfgNo();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        [Route("api/CreateMiscMfgOrder"), HttpPost]
        public CommonRep<string> CreateMiscMfgOrder([FromBody] 零件申請單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                int execCnt = mfgMiddle.createMiscMfgOrder(form);
                execCnt += mfgMiddle.updateSalesOrderMachineNo(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetMiscMfgByNo"), HttpGet]
        public CommonRep<零件申請單> GetMiscMfgByNo(string orderNo)
        {
            CommonRep<零件申請單> commonRep = new CommonRep<零件申請單>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                commonRep.result = mfgMiddle.getMiscMfgByNo(orderNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateMiscMfgOrder"), HttpPost]
        public CommonRep<string> UpdateMiscMfgOrder([FromBody] 零件申請單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                mfgMiddle.updateMiscMfgOrder(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ApproveMiscMfg"), HttpGet]
        public CommonRep<string> ApproveMiscMfg(string orderNo, string username)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                mfgMiddle.approveMiscMfg(orderNo, username);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UnapproveMiscMfg"), HttpGet]
        public CommonRep<string> UnapproveMiscMfg(string orderNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                mfgMiddle.unapproveMiscMfg(orderNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/VoidMiscMfg"), HttpGet]
        public CommonRep<string> VoidMiscMfg(string orderNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                mfgMiddle.voidMiscMfg(orderNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetWorkOrderPickList"), HttpGet]
        public CommonRep<工令單> GetWorkOrderPickList()
        {
            CommonRep<工令單> commonRep = new CommonRep<工令單>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                commonRep.resultList = mfgMiddle.getWorkOrderPickList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/StageBRGParts"), HttpGet]
        public CommonRep<string> StageBRGParts(string orderNo, string custName, string projectNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                mfgMiddle.stageBRGParts(orderNo, custName, projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetBRGPartsList"), HttpGet]
        public CommonRep<零件申請BRG> GetBRGPartsList(string orderNo)
        {
            CommonRep<零件申請BRG> commonRep = new CommonRep<零件申請BRG>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                commonRep.resultList = mfgMiddle.getBRGPartsList(orderNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/SetBRGSelected"), HttpPost]
        public CommonRep<string> SetBRGSelected([FromBody] SetBRGSelectedRequest request)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                mfgMiddle.setBRGSelected(request.OrderNo, request.CheckedIds);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ConfirmBRGSelection"), HttpGet]
        public CommonRep<string> ConfirmBRGSelection(string orderNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                mfgMiddle.confirmBRGSelection(orderNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetCustomerSearchList"), HttpGet]
        public CommonRep<零件單客戶篩選列表> GetCustomerSearchList(string keyword)
        {
            CommonRep<零件單客戶篩選列表> commonRep = new CommonRep<零件單客戶篩選列表>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                commonRep.resultList = mfgMiddle.getCustomerSearchList(keyword);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetMiscMfgOverviewList"), HttpGet]
        public CommonRep<零件申請總覽列表> GetMiscMfgOverviewList()
        {
            CommonRep<零件申請總覽列表> commonRep = new CommonRep<零件申請總覽列表>();
            MfgMiddle mfgMiddle = new MfgMiddle();
            try
            {
                commonRep.resultList = mfgMiddle.getMiscMfgOverviewList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }
        #endregion
    }

    public class SetBRGSelectedRequest
    {
        public string OrderNo { get; set; }
        public List<int> CheckedIds { get; set; }
    }
}
