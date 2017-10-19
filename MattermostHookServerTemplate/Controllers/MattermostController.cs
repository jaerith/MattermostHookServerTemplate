using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MattermostHookServerTemplate.Models;

namespace MattermostHookServerTemplate.Controllers
{
    public class MattermostController : ApiController
    {
        /*
        // GET: api/Mattermost
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        */

        /*
        // GET: api/Mattermost/5
        public string Get(int id)
        {
            return "value";
        }
        */

        // POST: api/Mattermost
        public MattermostReturnPayload PostData(System.Net.Http.Formatting.FormDataCollection formData)
        {
            string Command = "";
            if (formData != null)
                Command = formData.Get("command");

            MattermostReturnPayload response = new MattermostReturnPayload();

            if (!String.IsNullOrEmpty(Command) && Command.Contains("sample"))
            {
                response.text = "| Component  | Tests Run   | Tests Failed                                   |\n" +
                                "|:-----------|:------------|:-----------------------------------------------|\n" +
                                "| Server     | 948         | :white_check_mark: 0                           |\n" +
                                "| Web Client | 123         | :warning: [2(see details)]                     |\n" +
                                "| iOS Client | 78          | :warning: [3(see details)](http://linktologs)  |\n";

            }
            
            // MORE SAMPLE CODE WILL BE WRITTEN HERE

            return response;
        }

        /*
        // PUT: api/Mattermost/5
        public void Put(int id, [FromBody]string value)
        {
        }
        */

        /*
        // DELETE: api/Mattermost/5
        public void Delete(int id)
        {
        }
        */
    }
}
