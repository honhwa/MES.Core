using MES.Core.Model;
using MES.WebAPI.MiddleWare;
using MES.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MES.WebAPI.Controllers
{
    [ApiController]
    public class ProductSpecController : ControllerBase
    {
        [Route("api/GetProductSpecOverviewList"), HttpGet]
        public CommonRep<產品規格總覽列表> GetProductSpecOverviewList()
        {
            CommonRep<產品規格總覽列表> commonRep = new CommonRep<產品規格總覽列表>();
            ProductSpecMiddle productSpecMiddle = new ProductSpecMiddle();
            try
            {
                commonRep.resultList = productSpecMiddle.getProductSpecOverviewList();
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/GetProductSpecDetail"), HttpGet]
        public CommonRep<產品規格單> GetProductSpecDetail(string projectNo)
        {
            CommonRep<產品規格單> commonRep = new CommonRep<產品規格單>();
            ProductSpecMiddle productSpecMiddle = new ProductSpecMiddle();
            try
            {
                commonRep.result = productSpecMiddle.getProductSpecByProjectNo(projectNo);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/InsertProductSpec"), HttpPost]
        public CommonRep<string> InsertProductSpec([FromBody] 產品規格單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProductSpecMiddle productSpecMiddle = new ProductSpecMiddle();
            try
            {
                productSpecMiddle.insertProductSpec(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UpdateProductSpec"), HttpPost]
        public CommonRep<string> UpdateProductSpec([FromBody] 產品規格單 form)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProductSpecMiddle productSpecMiddle = new ProductSpecMiddle();
            try
            {
                productSpecMiddle.updateProductSpec(form);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/ApproveProductSpec"), HttpGet]
        public CommonRep<string> ApproveProductSpec(string projectNo, string username)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProductSpecMiddle productSpecMiddle = new ProductSpecMiddle();
            try
            {
                productSpecMiddle.approveProductSpec(projectNo, username);
            }
            catch (Exception ex)
            {
                commonRep.ErrorMessage = ex.Message;
                commonRep.WorkStatus = WorkStatus.Fail.ToString();
            }
            return commonRep;
        }

        [Route("api/UnapproveProductSpec"), HttpGet]
        public CommonRep<string> UnapproveProductSpec(string projectNo)
        {
            CommonRep<string> commonRep = new CommonRep<string>();
            ProductSpecMiddle productSpecMiddle = new ProductSpecMiddle();
            try
            {
                productSpecMiddle.unapproveProductSpec(projectNo);
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
