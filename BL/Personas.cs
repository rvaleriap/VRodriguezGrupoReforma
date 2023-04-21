using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Personas
    {
      public static  ML.Result Add(ML.Personas personas)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VRodriguezGrupoReformaEntities context = new DL.VRodriguezGrupoReformaEntities())
                {
                    int query = context.AddPersona(personas.Nombre, personas.Direccion, personas.Edad, personas.Correo, personas.HabilidadPrincipal, personas.HabilidadSecundaria);
                    if(query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se pudo ingresar";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
