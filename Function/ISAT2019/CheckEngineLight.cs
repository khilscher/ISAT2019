using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ISAT2019
{

    public static class CheckEngineLight
    {
        static bool checkEngineLightEnabled = true; //Not a good way to store state in Functions. Quick and dirty hack.

       [FunctionName("CheckEngineLight")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            string name = req.Query["name"];

            if (req.Method == HttpMethods.Post)
            {
                try
                {

                    string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

                    VehicleCheckEngineLight checkLightEnabled = new VehicleCheckEngineLight();

                    VehicleCheckEngineLight data = JsonConvert.DeserializeObject<VehicleCheckEngineLight>(requestBody);

                    checkEngineLightEnabled = data.CheckEngineLight;

                    /*
                    dynamic data = JsonConvert.DeserializeObject(requestBody);

                    checkEngineLightEnabled = data.checkEngineLight;
                    */

                    var jsonResult = new
                    {
                        CheckEngineLight = checkEngineLightEnabled
                    };

                    log.LogInformation($"CheckEngineLight successfully reset by: {name}.");

                    return new OkObjectResult(jsonResult);

                }
                catch (Exception e)
                {
                    log.LogInformation($"CheckEngineLight function encountered an exception: {e.Message}");
                }

            }
            else if (req.Method == HttpMethods.Get)
            {
                log.LogInformation($"CheckEngineLight function successfully requested by: {name}.");

                var jsonResult = new
                {
                    CheckEngineLight = checkEngineLightEnabled
                };

                return new OkObjectResult(jsonResult);
            }

            log.LogInformation("CheckEngineLight function received an invalid request.");

            return new BadRequestResult();

        }
    }

    public class VehicleCheckEngineLight
    {
        public bool CheckEngineLight { get; set; }
    }

}
