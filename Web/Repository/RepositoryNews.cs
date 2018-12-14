using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DBContext;

namespace Repository
{
    public class RepositoryNews : Interfaces
    {
        private Context context = new Context();
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
          
        }

        public News FindNew()
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public List<News> ListNews()
        {
            List<News> List = context.News.ToList();
            return List;
        }

        public List<News> ListNews(DateTime FechaInicio, DateTime FechaFin)
        {
            throw new NotImplementedException();
        }
    }
}
