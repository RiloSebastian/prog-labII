using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesAbstractas;
using ClasesInstanciables;
using Archivos;

namespace TestUnitarios
{
    [TestClass]
    public class testPersonas
    {
        [TestMethod]
        public void TestExcepcionAlumnos()
        {
            Alumno a1;
            a1 = new Alumno(1, "Rafael", "Rodriguez", "15478632", Persona.Enacionalidad.Extranjero, Universidad.EClases.Laboratorio, Alumno.EEstadoDeCuenta.Becado);
            
            
        }
    }
}
