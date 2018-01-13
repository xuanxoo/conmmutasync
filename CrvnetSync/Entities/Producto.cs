﻿using CrvnetSync.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrvnetSync.Entities
{
    public class Producto
    {
        public long id { get { return Convert.ToInt64(referencia); } }
        public string referencia { get; set; }
        public string estado { get; set; }
        public string nota { get; set; }
        public string ubicacion { get; set; }
        public decimal precio { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string version { get; set; }
        public string articulo { get; set; }
        public string familia { get; set; }

        public string colorvehiculo { get; set; }

        public int puertasvehiculo { get; set; }
        public string metadatos { get; set; }

        public string descripcion
        {
            get {
                StringBuilder sb = new StringBuilder();
                

                var metadatosStr = this.metadatos.Split('|');
                foreach(var meta in metadatosStr)
                {
                    if(!string.IsNullOrEmpty(meta))
                        sb.AppendFormat("{0} <br/>", meta);
                }

                sb.AppendFormat("<strong>Estado: {0}</strong>", estado);

                return sb.ToString();
            }
        }

        public string titulo
        {
            get { return articulo + " - " + version; }
        }

        public Producto(EntradaStock entrada)
        {
            this.referencia = entrada.referencia;
            this.estado = entrada.estado;
            this.nota = entrada.nota;
            this.precio = entrada.precio;
            this.marca = entrada.marca;
            this.modelo = entrada.modelo;
            this.version = entrada.version;
            this.familia = entrada.familia;
            this.articulo = entrada.articulo;
            this.metadatos = entrada.metadatos;
            this.colorvehiculo = entrada.color;
            this.puertasvehiculo = entrada.puertas;
            
        }
    }
}
