using API_DNDD.Managers;
using Microsoft.AspNetCore.Mvc;
using API_DNDD.Classes;

namespace API_DNDD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreaturesController : ControllerBase
    {
        private CreaturesManager CM = new CreaturesManager();

        [HttpGet]
        [Route("id/{id}")]
        public Creature Get(int id)
        {
            return CM.GetById(id);
        }
        [HttpGet]
        public List<Creature> GetAll()
        {
            return CM.GetAll();
        }
    }
}