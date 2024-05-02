using Microsoft.AspNetCore.Mvc;

namespace Modul9_1302220016.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class mhsController : Controller
    {
        private static List<string> Course = new List<string>
        {
            "KPL", "BD", "PBO"
        };
        private static List<mhs> Listmhs = new List<mhs>
        {
            new mhs("rizqi", "1302220016", Course, 2022),
            new mhs("ryan", "1302220010", Course, 2022),
            new mhs("rizal", "1302220020", Course, 2022),
    };
        [HttpGet]
        public IEnumerable<mhs> Get()
        {
            return Listmhs;
        }
        [HttpGet("{id}")]
        public mhs get(int id)
        {
            return Listmhs[id];
        }
        [HttpPost]
        public void post(mhs mhs)
        {
            Listmhs.Add(mhs);
        }
        [HttpDelete("{id}")]
        public void delete(int id)
        {
            Listmhs.RemoveAt(id);
        }
    }
}
