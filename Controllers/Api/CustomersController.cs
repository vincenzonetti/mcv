using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Veenca.Models;
using Veenca.Dtos;
using Veenca.App_Start;
using AutoMapper;
using System.Data.Entity;
namespace Veenca.Controllers.Api
{

    public class CustomersController : ApiController
    {
        private ApplicationDbContext _contex;
        public CustomersController() {
            _contex = new ApplicationDbContext();
        }
        //GET /api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = _contex.Customers
                .Include(c => c.MembershipType);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.name.Contains(query));

            var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }
        //GET /api/customers/1
        public IHttpActionResult GetCustomer(int id) {
            var customer = _contex.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
            {
                return NotFound();
            }


            return Ok(Mapper.Map<Customer, CustomerDto>(customer));


        }
        //POST/api/Customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto) {

            if (!ModelState.IsValid) {
                return BadRequest();
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _contex.Customers.Add(customer);
            _contex.SaveChanges();
            customerDto.id = customer.id;
            return Created(new Uri(Request.RequestUri + "/" + customer.id), customerDto);
        }

        //PUT /api/customers/1
        [HttpPut]
        public void UpdateCustomers(int id, CustomerDto customerDto) { 

            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDb = _contex.Customers.SingleOrDefault(c => c.id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(customerDto, customerInDb);

            _contex.SaveChanges();
        } 
        //Delete /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _contex.Customers.SingleOrDefault(c => c.id == id);

            if (customerInDb == null)
                return NotFound();

            _contex.Customers.Remove(customerInDb);
            _contex.SaveChanges();

            return Ok();
        }
  
    }


}
