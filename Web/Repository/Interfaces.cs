using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface Interfaces : IDisposable
    {
        void Guardar();
        void Eliminar();

        News FindNew ();

        List<News> ListNews();

        List<News> ListNews(DateTime FechaInicio, DateTime FechaFin);

    }
}
