using System;
using System.Collections.Generic;
using System.Text;
using WAP2.Models;

namespace WAP2.Services
{
    public class PickerService
    {
        public List<string> categoryPickerList()
        {
            List<string> categorias = new List<string>
            {
                "Motor y Accesorios",
                "Moda y Accesorios",
                "TV, Audio y Foto",
                "Móviles y Telefonía",
                "Informática y Electrónica",
                "Deporte y Ocio",
                "Bicicletas",
                "Consolas y Videojuegos",
                "Hogas y Jardín",
                "Electrodomésticos",
                "Cine, Libros y Música",
                "Niños y Bebés",
                "Coleccionismo",
                "Materiales de construcción",
                "Industria y Agricultura",
                "Joyas y anillos"
            };
            return categorias;
        }
        public List<string> subcategoryPickerList(string option)
        {
            List<string> subcategorias = new List<string>();
            switch (option)
            {
                case "Motor y Accesorios":
                    subcategorias = new List<string>
                    {
                        "GPS y Electrónica",
                        "Herramientas",
                        "Recambios de coches y furgonetas",
                        "Recambios de motor y cuatriciclos",
                        "Otros"
                    };
                    break;
                case "Moda y Accesorios":
                    subcategorias = new List<string>
                    {
                        "Abrigos y Chaquetas",
                        "Accesorios",
                        "Bañadores y bikinis",
                        "Belleza y cosmética",
                        "Bolso, maletas y carteras",
                        "Bufandas y guantes",
                        "Calzado",
                        "Gafas",
                        "Ropa premamá",
                        "Sombreros y gorros",
                        "Trajes, fiesta y bodas",
                        "Ropa interior y calcetines",
                        "Guantes",
                        "Otros"
                    };
                    break;
                case "TV, Audio y Foto":
                    subcategorias = new List<string>
                    {
                        "Auriculares y cascos",
                        "Cámaras de vigilancia",
                        "Cámaras y fotografía",
                        "Drones",
                        "Pilas y cargadores",
                        "Proyectores y accesorios",
                        "Reproductores",
                        "Televisores y accesorios",
                        "Vídeo y accesorios",
                        "Otros"
                    };
                    break;
                case "Móviles y Telefonía":
                    subcategorias = new List<string>
                    {
                        "Accesorios",
                        "Cables",
                        "Piezas y recambios",
                        "Smartwatches",
                        "Tablets",
                        "Teléfonos antiguos",
                        "Teléfonos móviles",
                        "Otros"
                    };
                    break;
                case "Informática y Electrónica":
                    subcategorias = new List<string>
                    {
                        "Cables",
                        "Cargadores y baterías",
                        "Impresoras y accesorios",
                        "Monitores",
                        "Ordenadores y accesorios",
                        "Realidad virtual y aumentada",
                        "Software",
                        "Otros"
                    };
                    break;
                case "Deporte y Ocio":
                    subcategorias = new List<string>
                    {
                        "Baloncesto",
                        "Balonmano",
                        "Estáticas y elípticas",
                        "Fitness, running y yoga",
                        "Fútbol",
                        "Golf",
                        "Juegos recreativos y de mesa",
                        "Manualidad",
                        "Montaña y esquí",
                        "Natación y accesorios piscina",
                        "Patinetes y patinaje",
                        "Rugby",
                        "Tenis y pádel",
                        "Vóley",
                        "Otros deportes"
                    };
                    break;
                case "Bicicletas":
                    subcategorias = new List<string>
                    {
                        "Accesorios para bicicletas",
                        "Bicicletas y triciclos",
                        "Piezas y recambios de bici",
                        "Protección y vestimenta",
                        "Otros"
                    };
                    break;
                case "Consolas y Videojuegos":
                    subcategorias = new List<string>
                    {
                        "Accesorios de consolas",
                        "Consolas",
                        "Manuales y guías",
                        "Merchandasing de videojuegos",
                        "Recambios de consolas",
                        "Videojuegos",
                        "Otros"
                    };
                    break;
                case "Hogar y Jardín":
                    subcategorias = new List<string>
                    {
                        "Almacenaje",
                        "Artículos para mascotas",
                        "Baño",
                        "Cocina, comedor y bar",
                        "Colchones y ropa de cama",
                        "Decoración",
                        "Iluminación interior",
                        "Jardín y exteriores",
                        "Mobiliario y para la casa",
                        "Otros"
                    };
                    break;
                case "Electrodomésticos":
                    subcategorias = new List<string>
                    {
                        "Climatización",
                        "Electrodomésticos",
                        "Lavandería y plancha",
                        "Pequeños electrodomésticos",
                        "Piezas y recambios",
                        "Vitrocerámica",
                        "Otros"
                    };
                    break;
                case "Cine, Libros y Música":
                    subcategorias = new List<string>
                    {
                        "CDs y Vinilos",
                        "Cómics y novelas gráficas",
                        "Equipo profesional de sonido",
                        "Instrumentos musicales",
                        "Libros",
                        "Partituras y libretos",
                        "Películas y Series",
                        "Pósters y merchandasing",
                        "Revistas",
                        "Tocadiscos",
                        "Otros"
                    };
                    break;
                case "Niños y bebés":
                    subcategorias = new List<string>
                    {
                        "Accesorios de baño",
                        "Alimentación de bebé",
                        "Artículos de materinidad",
                        "Artículos escolares",
                        "Cunas y camas",
                        "Disfraces infantiles",
                        "Juguetes, juego y peluches",
                        "Mobiliario infantil",
                        "Ropa infantil",
                        "Seguridad y cuidado",
                        "Transporte del bebé",
                        "Tronas y andadores",
                        "Otros"
                    };
                    break;
                case "Coleccionismo":
                    subcategorias = new List<string>
                    {
                        "Antigüedades",
                        "Artesanías y decoración",
                        "Artículos de escritorio",
                        "Banderas",
                        "Coches y motocicletas",
                        "Coleccionismo deportivo",
                        "Coleccionismo militar",
                        "Filatelia y sellos",
                        "Imanes",
                        "Llaveros",
                        "Moneda y billetes",
                        "Muñecos",
                        "Naipes",
                        "Postales y suvenires",
                        "Relojes",
                        "Otros"
                    };
                    break;
                case "Materiales de contrucción":
                    subcategorias = new List<string>
                    {
                        "Balcones",
                        "Baños",
                        "Cocinas",
                        "Electricidad e Iluminación",
                        "Escaleras y Andamios",
                        "Ferretería",
                        "Herramientas y maquinaria",
                        "Madera y otros materiales",
                        "Pavimentos y revestimientos",
                        "Pinturas y barnices",
                        "Puertas y ventanas",
                        "Otros"
                    };
                    break;
                case "Industria y agricultura":
                    subcategorias = new List<string>
                    {
                        "Herramientas agrícolas",
                        "Insumos agrícolas",
                        "Maquinaria",
                        "Repuestos",
                        "Tractores",
                        "Vehículos",
                        "Equipamiento industrial",
                        "Herramientas",
                        "Insumos industriales",
                        "Repuestos de herramientas",
                        "Repuestos de maquinaria"
                    };
                    break;
                default:
                    break;
            }
            return subcategorias;
        }
        /*public List<Categoria> CategoriasCarouselAll()
        {
            List<String> list = categoryPickerList();
            List<Categoria> categorias = new List<Categoria>();
            foreach (string categoria in list)
            {
                categorias.Add(new Categoria(categoria));
            }
            return categorias;
        }*/
        
        public List<string> statusPickerList()
        {
            List<string> status = new List<string>
            {
                "Nuevo",
                "Algo Usado",
                "Bastante Usado",
                "Muy Usado",
                "Necesita Reparación"
            };
            return status;
        }

        public List<string> genderPickerList()
        {
            List<string> gender = new List<string>
            {
                "Hombre",
                "Mujer"
            };
            return gender;
        }

        public List<Pais> paisPickerList()
        {
            List<Pais> Paises = new List<Pais>();

            Paises.Add(new Pais
            {
                Nombre = "España",
                Url = "esp.png"
            });

            Paises.Add(new Pais
            {
                Nombre = "Francia",
                Url = "france.png"
            });

            Paises.Add(new Pais
            {
                Nombre = "Portugal",
                Url = "portugal.png"
            });

            Paises.Add(new Pais
            {
                Nombre = "Andorra",
                Url = "andorra.png"
            });

            Paises.Add(new Pais
            {
                Nombre = "Alemania",
                Url = "germany.png"
            });

            Paises.Add(new Pais
            {
                Nombre = "Italia",
                Url = "italy.png"
            });

            Paises.Add(new Pais
            {
                Nombre = "Reino Unido",
                Url = "united_kingdom.png"
            });

            return Paises;
        }
    }
}
