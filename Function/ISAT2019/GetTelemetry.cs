using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace ISAT2019
{
    public static class RestEndpoint
    {
        [FunctionName("GetTelemetry")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {

            try
            {
                VehicleModel cardata = new VehicleModel();

                Random random = new Random();

                cardata.TimeStamp = DateTime.UtcNow;
                cardata.VehicleVIN = "3C6JR6AT4DG572476";
                cardata.DeviceName = "ECM";
                cardata.SensorName = "Crankshaft Position Sensor";
                cardata.Value = random.Next(1000, 5000);
                cardata.EngineeringUnit = "RPM";

                string name = req.Query["name"];

                log.LogInformation($"GetTelemetry successfully requested by: {name}");

                return (ActionResult)new OkObjectResult(cardata);
            }
            catch (Exception e)
            {
                log.LogInformation($"GetTelemetry exception {e.Message}");
                return (ActionResult)new BadRequestObjectResult(e.Message);
            }

        }
    }

    public class VehicleModel
    {
        public DateTime TimeStamp { get; set; }
        public string VehicleVIN { get; set; }
        public string DeviceName { get; set; }
        public string SensorName { get; set; }
        public string EngineeringUnit { get; set; }
        public double Value { get; set; }
    }
    
}
