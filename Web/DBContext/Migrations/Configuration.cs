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
                Title = "Las mejores ofertas de la semana en Amazon, eBay y otras tiendas ‘online’",
                Content = "Queda poco más de una semana para Noche Buena, fecha que supone el arranque oficial de las fiestas de Navidad. Y a algunas casas llega Papá Noel, por lo que muchos tendrán que ultimar los regalos para que estén listos para la mañana del 25 de diciembre.",
                Image = "https://ep01.epimg.net/elpais/imagenes/2018/12/14/escaparate/1544797990_137191_1544801472_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "La inteligencia artificial aprende a engañar a los ‘captcha’",
                Content = "La era de los captcha textuales, esas secuencias de caracteres que los humanos debemos reconocer para demostrar que no somos máquinas, ha llegado a su ocaso. Una reciente investigación, cofinanciada por China y Reino Unido, demuestra que variantes de esta medida de seguridad aún masivamente difundidas en Internet han quedado obsoletas. El estudio presenta un sistema de inteligencia artificial.",
                Image = "https://ep01.epimg.net/tecnologia/imagenes/2018/11/05/actualidad/1541435024_805547_1541435350_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "La demanda de profesionales tecnológicos crece un 40% en un año",
                Content = "Nace la plataforma Barcelona Digital Talent para captar talento y posicionar la ciudad como capital tecnológica.",
                Image = "https://ep01.epimg.net/ccaa/imagenes/2018/12/13/catalunya/1544724477_092330_1544724782_miniatura_normal.jpg",
                DatePublication = DateTime.Now                
            });
            defaultNews.Add(new News
            {
                Title = "Cómo poner una contraseña a un USB o a un disco duro externo",
                Content = "El usuario puede proteger sus archivos con un ‘software’ de encriptación gratuito en apenas 10 minutos.",
                Image = "https://ep01.epimg.net/tecnologia/imagenes/2018/12/10/actualidad/1544434764_789610_1544436526_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "¿Móvil o cámara réflex?",
                Content = "La nueva generación de teléfonos ofrece imágenes de 48 megapíxeles de resolución.",
                Image = "https://ep01.epimg.net/tecnologia/imagenes/2018/12/13/actualidad/1544690463_872267_1544692302_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "La ‘fintech’ Revolut se convierte en banco para operar en toda Europa",
                Content = "La firma tecnológica Revolut ha decidido convertirse en banco pese a los duros requerimientos regulatorios y de capital que tendrá que asumir. La empresa ha recibido la licencia bancaria europea por el supervisor de Londres y se implementará en 2019.",
                Image = "https://ep01.epimg.net/economia/imagenes/2018/05/04/actualidad/1525437097_263678_1526237360_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "La gran apuesta china: hacer de la necesidad virtud",
                Content = "El panel de científicos de la ONU sobre cambio climático ha advertido de que solo tenemos una ventana de 12 años para aplicar las medidas necesarias para asegurar que la temperatura del planeta no suba más de dos grados al final de siglo.",
                Image = "https://ep01.epimg.net/elpais/imagenes/2018/12/12/opinion/1544633407_383123_1544640213_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Las puertas que la tecnología puede abrir",
                Content = "África es el continente en el que los niños y los jóvenes están menos conectados, pero también donde más iniciativas intentan acercar el entorno digital a los más pequeños para ampliar sus oportunidades.",
                Image = "https://ep01.epimg.net/elpais/imagenes/2018/11/12/planeta_futuro/1542024538_178764_1542026065_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "¿Pasas demasiado tiempo con tu móvil?",
                Content = "Según una encuesta anual sobre tendencias en Internet, en 2017 la población adulta de Estados Unidos pasó una media de tres horas y 20 minutos diarios ocupada con sus teléfonos móviles y sus tabletas, el doble que hace tan solo dos años. ",
                Image = "https://ep01.epimg.net/politica/imagenes/2018/03/02/actualidad/1520012219_058442_1520013167_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            defaultNews.Add(new News
            {
                Title = "Coche eléctrico...para la ciudad",
                Content = "Si se piensa en automóviles con una autonomía de entre 300 y 400 kilómetros, aumentarán las inversiones en peajes y en redes capilares de distribución y habrá una subida notable del recibo de la luz.",
                Image = "https://ep01.epimg.net/elpais/imagenes/2018/12/11/opinion/1544554615_819331_1544555307_miniatura_normal.jpg",
                DatePublication = DateTime.Now
            });
            context.News.AddRange(defaultNews);
        }
    }
}
