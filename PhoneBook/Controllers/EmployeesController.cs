using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using PhoneBook.Core.Enums;
using PhoneBook.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace PhoneBook.Models.Controllers
{
    [Route("api/Employees/{action}", Name = "EmployeesApi")]
    public class EmployeesController : ApiController
    {
        private PhoneBookContext phoneBookContext = new PhoneBookContext();
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions) {
            var employees = phoneBookContext.Employees;

            loadOptions.PrimaryKey = new[] { "Id" };
            loadOptions.PaginateViaPrimaryKey = true;

            return Request.CreateResponse(DataSourceLoader.Load(employees, loadOptions));
        }
        public HttpResponseMessage GetByFullName(DataSourceLoadOptions loadOptions, string fullname)
        {
            var employees = phoneBookContext.Employees.Where(
                x => x.FullName.Contains(fullname)
            );

            return Request.CreateResponse(DataSourceLoader.Load(employees, loadOptions));
        }
        public HttpResponseMessage GetByDateOfBirth(DataSourceLoadOptions loadOptions, string dateOfBirth)
        {
            DateTime date = DateTimeWrapper.ParseClientSideDate(dateOfBirth);
            var employees = phoneBookContext.Employees.Where(
                x => DbFunctions.TruncateTime(x.DateOfBirth) == date
            );

            return Request.CreateResponse(DataSourceLoader.Load(employees, loadOptions));
        }

        public HttpResponseMessage GetSorted(DataSourceLoadOptions loadOptions, SortTypes sortType)
        {
            var employees = new Dictionary<SortTypes, IQueryable<Employees>>()
            {
                { SortTypes.SortByName, phoneBookContext.Employees.OrderBy(x => x.FullName) },
                { SortTypes.SortByDateOfBirth, phoneBookContext.Employees.OrderBy(x => x.DateOfBirth) }
            };

            return Request.CreateResponse(DataSourceLoader.Load(employees[sortType].ToList(), loadOptions));
        }


        protected override void Dispose(bool disposing) {
            if (disposing) {
                phoneBookContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}