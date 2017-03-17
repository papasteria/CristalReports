using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CristalReport.model;

namespace CristalReport.controlador
{
    class productosManager
    {
        public static List<string> ListarDeptos()
        {
            List<string> deptos = new List<string>();
            try
            {
                using(var ctx = new DataModel())
                {
                    var Lista = ctx.productos.GroupBy(r => r.sDepartamemto).ToList();
                    foreach(var item in Lista)
                    {
                        deptos.Add(item.Key.ToString().ToUpper());
                    }
                    deptos.Add("TODOS");
                        

                }
            }
            catch (Exception)
            {

                throw;
            }
            return deptos;
        }
    }
}
