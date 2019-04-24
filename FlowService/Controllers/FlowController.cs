using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace FlowService.Controllers
{
    public class FlowController : ApiController
    {
        [HttpPost]
        [Route("api/flow/{id}")]
        public string GetFlow(string id) {
            //CREA EL FLOW DE TRABAJO
            Core.MainCore _ = new Core.MainCore();

            _.addFlow(id);


            return "";
        }

        [HttpPost]
        [Route("api/addToFlow/{id}")]
        public string AddGetFlow(string id, FormDataCollection value)
        {
            //CREA EL FLOW DE TRABAJO
            FlowService.Core.DB.Models.Timeline timeline = new Core.DB.Models.Timeline();

            timeline.fecha = value.Get("fecha"); ;
            timeline.tipo = value.Get("tipo");
            timeline.idTipo = value.Get("idTipo") == null ? ObjectId.Empty :  ObjectId.Parse(value.Get("idTipo"));
            timeline.titulo = value.Get("titulo");
            timeline.mensaje = value.Get("mensaje");
            timeline.ticket = value.Get("ticket");
            timeline.visto = value.Get("visto") == "true" ? true : false;
            timeline.terminado = value.Get("terminado") == "true" ? true : false;

            Core.MainCore _ = new Core.MainCore();

            _.addToFlow(id, timeline);


            return "";
        }
    }
}
