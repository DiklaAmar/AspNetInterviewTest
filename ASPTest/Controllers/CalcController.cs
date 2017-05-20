using System.Collections.Generic;
using System.Web.Http;

namespace ASPTest.Controllers
{
    public class CalcController : ApiController
    {
        IEvents _eventRep = new EventsRepository();
        /// <summary>
        /// Return Next Position
        /// </summary>
        /// <param name="Position"></param>
        /// <returns></returns>
        public int Get(int Position)
        {
            return _eventRep.Next(Position);
        }

        public List<int> Get()
        {
            return _eventRep.GetAllItems();
        }
    }
}
