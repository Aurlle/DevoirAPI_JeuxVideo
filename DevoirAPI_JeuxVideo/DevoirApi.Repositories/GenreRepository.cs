using DevoirApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevoirApi.Repositories
{
    public class GenreRepository : IRepository<GenrePOCO>
    {
        private string _cnstr;

       
        public GenreRepository(string cnstr)
        {
            _cnstr = cnstr;
        }

        public IEnumerable<GenrePOCO> GetAll()
        {

        }
    }
}
