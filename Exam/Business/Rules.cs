using Exam.Data;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Business
{
    public class Rules
    {
        public static ModelResponse SaveUser(ModelUSer input)
        {
            ModelResponse res = new ModelResponse();
            try
            {
                BOLSA_EXAMENEntities ctx = new BOLSA_EXAMENEntities();
                var resp= ctx.INSERT_USER(input.username, input.password, input.email, input.name, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
                if (resp==2)
                {
                    res.Message = "Exito";
                    res.Success = true;
                   
                }
                else
                {
                    res.Message = "Error al insertar";
                    res.Success = true;
                }
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.GetBaseException().Message;
            }
            return res;
        }
        public static ModelResponse Getall()
        {
            ModelResponse res = new ModelResponse();
            List<ModelGetUser> list = new List<ModelGetUser>();
            try
            {
                BOLSA_EXAMENEntities ctx = new BOLSA_EXAMENEntities();
                var resp = ctx.ALL_USERS();
                if (resp != null)
                {

                    foreach (var item in resp)
                    {
                        ModelGetUser mod = new ModelGetUser();
                        mod.NOMBRE = item.NOMBRE;
                        mod.EMAIL = item.EMAIL;
                        mod.LLAVE_USUARIO = Convert.ToInt32(item.LLAVE_USUARIO);
                        mod.USUARIO = item.USUARIO;

                        list.Add(mod);
                    }

                    res.Value = list;
                    res.Message = "Exito";
                    res.Success = true;

                }
                else
                {
                    res.Value = list;
                    res.Message = "Error en los datos";
                    res.Success = true;
                }
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.GetBaseException().Message;
            }
            return res;
        }
        
            public static ModelResponse Edit(ModelId input)
        {
            ModelResponse res = new ModelResponse();
            ModelGetUser mod = new ModelGetUser();
            try
            {
                BOLSA_EXAMENEntities ctx = new BOLSA_EXAMENEntities();
                var resp = ctx.SELECT_USER(input.Id).FirstOrDefault();
                if (resp!=null )
                {


                      mod.NOMBRE = resp.NOMBRE;
                      mod.LLAVE_USUARIO = Convert.ToInt32(resp.LLAVE_USUARIO);

                   
                    res.Value = mod;
                    res.Message = "Exito";
                    res.Success = true;

                }
                else
                {
                    res.Value = mod;
                    res.Message = "Error en los datos";
                    res.Success = true;
                }
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.GetBaseException().Message;
            }
            return res;
        }
    }
}