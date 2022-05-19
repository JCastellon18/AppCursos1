using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCursos
{
    class Global
    {
        public static int idpuntero= 0;

        public static List<Modulos> modulo1 = new List<Modulos>
        {
             new Modulos(1, "Conceptos básicos de Bases de Datos en Excel | Gestión de la Información #1 ", "https://goo.gl/Rof9Yf", "No usa una base de datos como ejemplo", "N/A")
            ,new Modulos(2, "Ejemplos de Bases de Datos en Excel | Gestión de la Información #2", "https://goo.gl/iUF2rL", "No 1 EJEMPLO BD", "https://www.poli.edu.co/sites/default/files/basesdatos/No-1-EJEMPLO-BD.XLS")
            ,new Modulos(3, "Diversos ejemplos de Bases de Datos en Excel | Gestión de la Información #3", "https://goo.gl/baXcJW", "EJEMPLO_BANCOS	", "https://www.poli.edu.co/sites/default/files/basesdatos/EJEMPLO_BANCOS.XLSX")
            ,new Modulos(4, "¿Que es una Tabla Resumen en Excel y que es una Base de Datos? | Gestión de la Información #4 ", "https://goo.gl/hj8vYo", "No 3 NO BD", "https://www.poli.edu.co/sites/default/files/basesdatos/No-3-NO-BD.XLS")
        };

        public static List<Modulos> modulo2 = new List<Modulos>
        {
            new Modulos(1, "¿Cómo ingresar datos en una Base de Datos de Excel? | Gestión de la Información #5", "https://goo.gl/5kEcGd", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
           ,new Modulos(2, "Aprende a ordenar Bases de Datos en Excel | Gestión de la Información #6", "https://goo.gl/eGZ5j9", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX	")
           ,new Modulos(3, "¿Cómo generar subtotales en una Base de Datos en Excel? | Gestión de la Información #7", "https://goo.gl/cq9NGR", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(4, "¿Cómo se generan autofiltros en una Base de Datos en Excel? | Gestión de la Información #8	", "https://goo.gl/Zcm4r6", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(5, "¿Cómo crear un filtro avanzado en una Base de Datos en Excel? | Gestión de la Información #9", "https://goo.gl/z6Nzwu", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(6, "Aprende a validar datos en Excel | Gestión de la Información #10", "https://goo.gl/JyMCeE","BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")													
        };
        public static List<Modulos> modulo3 = new List<Modulos>
        {
            new Modulos(1, "¿Cómo crear Tablas Dinámicas en Excel? | Gestión de la Información #11", "https://goo.gl/2npG6Y", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(2, "Agrupar campos en Tablas Dinámicas en Excel | Gestión de la Información #12", "https://goo.gl/SKGwGt", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(3, "Mostrar datos como porcentaje de fila o columna | Gestión de la Información #13", "https://goo.gl/urrrP5", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(4, "Segmentación de Datos en Tablas Dinámicas en Excel | Gestión de la Información #14", "https://goo.gl/e5NfSt", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
        };
        public static List<Modulos> modulo4 = new List<Modulos>
        {
            new Modulos(1,"Combinando correspondencia con Word y una base de datos en Excel | Gestión de la Información #15", "https://goo.gl/LPM51S", "No 4.5 TABLA DINAMICA BD PERSONAL","http://comunicaciones.poligran.edu.co/documentacion/No4-5-TABLA-DINAMICA-BD-PERSONAL.xlsm")
            ,new Modulos(2,"Formato condicional en Excel Parte 1 | Gestión de la Información #16", "https://goo.gl/fxXnqo", "BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(3,"Formato condicional en Excel Parte 2 | Gestión de la Información #17", "https://goo.gl/1ybnkZ", "BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(4,"Formato condicional en Excel Parte 3 | Gestión de la Información #18", "https://goo.gl/HVRNvA", "BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(5,"¿Cómo generar minigráficos en Excel? | Gestión de la Información #19", "https://goo.gl/wZB4VD", "BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(6,"Cinta y barra de menú rápida en Excel | Gestión de la Información #20", "https://goo.gl/pj8wua", "Libro limpio Excel", "N/A")
            ,new Modulos(7,"Conoce todos los menús en la presentación de excel | Gestión de la Información #21", "https://goo.gl/FtMcTZ", "Libro limpio Excel & BD_VENTAS", "https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX")
            ,new Modulos(8,"Conoce todas las opciones de menú en Excel | Gestión de la Información #22", "https://goo.gl/XxTo2b", "Libro limpio Excel", "N/A")
            ,new Modulos(9,"¿Cómo hacer consultas web desde Excel y generar Bases de Datos? | Gestión de la Información #23	", "https://goo.gl/XnXS9W", "CONSULTA_WEB", "https://www.poli.edu.co/sites/default/files/basesdatos/CONSULTA_WEB.XLSX")
            ,new Modulos(10, "Creación de Macros en Excel | Gestión de la Información #24", "https://goo.gl/NhNsT3", "No 4.5 TABLA DINAMICA BD PERSONAL", "http://comunicaciones.poligran.edu.co/documentacion/No4-5-TABLA-DINAMICA-BD-PERSONAL.xlsm")
        };
    }

    public class Modulos
    {
        int id;
        string nombre_video;
        string URL_YT;
        string nombre_archi;
        string URL_BD;

        public Modulos(int id, string nombre_video, string uRL_YT, string nombre_archi, string uRL_BD)
        {
            this.id = id;
            this.nombre_video = nombre_video;
            URL_YT = uRL_YT;
            this.nombre_archi = nombre_archi;
            URL_BD = uRL_BD;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre_video { get => nombre_video; set => nombre_video = value; }
        public string URL_YT1 { get => URL_YT; set => URL_YT = value; }
        public string Nombre_archi { get => nombre_archi; set => nombre_archi = value; }
        public string URL_BD1 { get => URL_BD; set => URL_BD = value; }
    }

}