namespace DBContext.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DBContext.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DBContext.Context context)
        {
            List<News> defaultNews = new List<News>();
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 1",
                Content = "Contenido Nocitica 1",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 2",
                Content = "Contenido Nocitica 2",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 3",
                Content = "Contenido Nocitica 3",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 4",
                Content = "Contenido Nocitica 4",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 5",
                Content = "Contenido Nocitica 5",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 6",
                Content = "Contenido Nocitica 6",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 7",
                Content = "Contenido Nocitica 7",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 8",
                Content = "Contenido Nocitica 8",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 9",
                Content = "Contenido Nocitica 9",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Titulo Noticia 10",
                Content = "Contenido Nocitica 10",
                Image = "Hola.jpg",
                DatePublication = DateTime.Now
            });
            context.News.AddRange(defaultNews);
        }
    }
}
