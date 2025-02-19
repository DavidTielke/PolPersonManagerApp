using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly PersonManager _manager;

        public PersonController()
        {
            _manager = new PersonManager();
        }

        [HttpGet()]
        [Route("/Persons/Adults")]
        public IEnumerable<Person> GetAllAdults()
        {
            return _manager.GetAllAdults();
        }
        [HttpGet()]
        [Route("/Persons/Children")]
        public IEnumerable<Person> GetAllChildren()
        {
            return _manager.GetAllChildren();
        }
    }
}
