using arquetipo.API.Controllers;
using arquetipo.Entity.Dto;
using arquetipo.Infrastructure.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace arquetipo.Test
{
    public class SistemaControllerTest : BaseTest
    {
        private ClienteImplementacion clinteService;
        [Fact]
        public async Task ObtenerCliente()
        {
            //prepacion
            string nombreBD = Guid.NewGuid().ToString();
            var contexto = ConstruirContext(nombreBD);

            contexto.Clientes.Add(new Cliente()
            {

                ClIdentificacion = "1720477332",
                ClNombres = "Eduardo",
                ClEdad = 17,
                ClFechaNacimiento = DateTime.Now,
                ClApellidos = "Araujo",
                ClDireccion = "San ANtonio",
                ClTelefono = "0995691214",
                ClEstadoCivil = "Soltero",
                ClIdentificacionConyuge = "1720477346",
                ClNombreConyuge = "Cinthia",
                ClSujetoCredito = true
            });
            contexto.Clientes.Add(new Cliente()
            {
                ClIdentificacion = "1720477334",
                ClNombres = "Eduardo",
                ClEdad = 17,
                ClFechaNacimiento = DateTime.Now,
                ClApellidos = "Araujo",
                ClDireccion = "San ANtonio",
                ClTelefono = "0995691214",
                ClEstadoCivil = "Soltero",
                ClIdentificacionConyuge = "1720477346",
                ClNombreConyuge = "Cinthia",
                ClSujetoCredito = true
            });
            await contexto.SaveChangesAsync();

            var contexto2 = ConstruirContext(nombreBD);

            //Prueba
            clinteService = new ClienteImplementacion(contexto2);
            var controlador = new ClienteController(clinteService);
            var respuesta = controlador.GetClientes().Result.Resultado;
            //verificacion
            // var cliente = new List<Cliente>(respuesta.Resultado);


            //Assert.AreEqual(2, cliente.Count);

        }


    }
}