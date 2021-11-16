using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Heladeria
{
   
    public class ClienteBL
    {

        BindingList<Cliente> ListaCliente { get; set; }

        public ClienteBL()
        {
             
            ListaCliente = new BindingList<Cliente>();

            
        }

        public BindingList<Cliente> ObtenerCliente()
        {
            
            
            return ListaCliente;
        }

        public Resultado  GuardarCliente(Cliente cliente)
        {
            var resultado2 = Validar(cliente);
            if(resultado2.Exitoso == false)
            {
                return resultado2;
            }
            if (cliente.id == 0)
            {
                cliente.id = ListaCliente.Max(item => item.id) + 1;
            }
            resultado2.Exitoso = true;
            return resultado2;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaCliente.Add(nuevoCliente);
        }

        public bool EliminarCliente (int id)
        {
            foreach (var cliente in ListaCliente)
            {
               if (cliente.id == id)
                {
                    ListaCliente.Remove(cliente);
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar (Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }



            return resultado;
        }
    }
    public class Cliente
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

    }

    public class Resultado2
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    } 
}
