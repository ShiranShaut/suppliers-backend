using suppliers_backend.DAL;
using suppliers_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace suppliers_backend.Controllers
{
    [RoutePrefix("supplier")]
    public class SupplierController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public IHttpActionResult Register(SupplierModel i_SupplierModel)
        {
            if (i_SupplierModel == null)
                return BadRequest("Supplier Not Valid");
            try
            {
                SupplierDal.Register(i_SupplierModel);
                return Ok("Supplier Saved Successfully");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("supplier/{id}")]
        public HttpResponseMessage GetSupplierById(int id)
        {
            try
            {
                SupplierModel supplier = SupplierDal.GetSupplierById(id);
                return Request.CreateResponse(HttpStatusCode.OK, supplier);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpGet]
        [Route("suppliers")]
        public HttpResponseMessage GetSuppliers()
        {
            try
            {
                List<SupplierModel> suppliers = SupplierDal.GetSuppliers();
                return Request.CreateResponse(HttpStatusCode.OK, suppliers);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
