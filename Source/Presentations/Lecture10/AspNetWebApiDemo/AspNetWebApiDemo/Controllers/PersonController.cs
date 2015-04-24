using AspNetWebApiDemo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// Key points
// - ASP.NET Web API code takes care of mapping URLs and HTTP verbs to controller method
// - A Web API controller must inherit from ApiController to be "locatable" by framework.
//   The base class contains common functionality used across controller
// - Model binding
//   - Framework binds incoming data to CLR types (body, header, query string)
//   - Validation via attributes can be used
// - (MediaType)Formatters
//   - Converts input/output from/to XML or JSON or whatever the 
//     Accept/Content-Type header specifies

namespace AspNetWebApiDemo.Controllers
{
    public class PersonController : ApiController
    {
        // don't do static in real production app
        static List<PersonRequest> _people;

        // static constructor
        static PersonController()
        {
            _people = new List<PersonRequest>();
            _people.Add(new PersonRequest { Name = "Ronnie", Age = 36 });
            _people.Add(new PersonRequest { Name = "Dennis", Age = 34 });
        }

        // instance constructor
        public PersonController()
        {
            // ctor called with every call to controller method.
            // This usually means the controller is stateless and
            // would get its data from a database with each call.
        }

        // GET: api/Person
        public IEnumerable<PersonResponse> Get()
        {
            //throw new ArgumentException("Test exception behavior");
            List<PersonResponse> r = new List<PersonResponse>();
            foreach (PersonRequest p in _people)
            {
                r.Add(new PersonResponse { Name = p.Name, Age = p.Age });
            }
            return r;
        }

        // implementation without error handling -- invalid index results in 500: internal server error
        // GET: api/Person/5
        //public string Get(int id)
        //{
        //    //return System.Threading.Thread.CurrentThread.ManagedThreadId.ToString();
        //    return _people[id];
        //}

        // return HttpResponseMessage gives us more control over what gets returned from service
        public HttpResponseMessage Get(int id)
        {           
            if (_people.Count > id)
            {
                PersonRequest p = _people[id];
                PersonResponse response = new PersonResponse { Name = p.Name, Age = p.Age };
                return Request.CreateResponse<PersonResponse>(HttpStatusCode.OK, response);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Person id not found");
            }
        }

        // POST: api/Person
        //public void Post([FromBody]string name)
        //{
        //    _people.Add(name);
        //}

        // in the spirit of the HTTP protocol, if you add a new item, then the response code
        // should be 201 Created (not the default 204 No content status code) and the 201 should have
        // in its header the location of the newly created item.
        public HttpResponseMessage Post([FromBody]PersonRequest person)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            _people.Add(person);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri + "/" + (_people.Count - 1).ToString());
            return response;
        }

        // PUT: api/Person/5
        public HttpResponseMessage Put(int id, [FromBody]PersonRequest person)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            if (_people.Count > id)
            {
                _people[id] = person;
                var response = Request.CreateResponse(HttpStatusCode.OK);
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Person id not found");
            }
        }

        // DELETE: api/Person/5
        public HttpResponseMessage Delete(int id)
        {
            if (_people.Count > id)
            {
                _people.RemoveAt(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Person id not found");
            }
        }
    }
}
