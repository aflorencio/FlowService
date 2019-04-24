using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowService.Core
{
    public class MainCore
    {
        public void addFlow(string id) {

            FlowService.Core.DB.Query.FlowQuery qCreate = new FlowService.Core.DB.Query.FlowQuery("mongodb://51.83.73.69:27017");

            qCreate.createNewFlow(id);

        }
        public void addToFlow(string id, FlowService.Core.DB.Models.Timeline data) {

            FlowService.Core.DB.Query.FlowQuery _ = new FlowService.Core.DB.Query.FlowQuery("mongodb://51.83.73.69:27017");

            _.addToFlow(id, data);

        }
    }
}