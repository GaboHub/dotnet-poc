using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_api.Modelo
{
    public class Client { 
        public long id { get; set; }
        public string nombre { get; set; }
        public string apellido {get; set;}
        public int edad {get; set;}

    public override bool Equals(Object obj)
    {
        //Check for null and compare run-time types.
        if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        else {
            Client c = (Client) obj;
            return (id == c.id) && (nombre == c.nombre) && (apellido == c.apellido) && (edad == c.edad);
        }
    }

    }
    
}