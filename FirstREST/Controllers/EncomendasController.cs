using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstREST.Lib_Primavera.Model;

namespace FirstREST.Controllers
{
    public class EncomendasController : ApiController
    {

        // GET /api/Encomendas?CodigoCliente={CodigoCliente}
        public IEnumerable<Lib_Primavera.Model.Encomenda> GetByClient([FromUri]string CodigoCliente)
        {
            return Lib_Primavera.PriIntegration.GetEncomendasCliente(CodigoCliente);
        }



        // GET api/Encomendas/{id}
        public Lib_Primavera.Model.Encomenda Get(string id)
        {
            Lib_Primavera.Model.Encomenda enc = Lib_Primavera.PriIntegration.GetEncomenda(id);
            
            if (enc == null)
            {
                throw new HttpResponseException(
                        Request.CreateResponse(HttpStatusCode.NotFound));

            }
            else
            {
                return enc;
            }
        }


        // PUT api/encomendas
        public HttpResponseMessage Put(Lib_Primavera.Model.Encomenda encomenda)
        {
            Lib_Primavera.Model.RespostaErro resposta = new Lib_Primavera.Model.RespostaErro();

            resposta = Lib_Primavera.PriIntegration.InsereEncomenda(encomenda);

            if (resposta.Erro == 0)
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

    }
}
