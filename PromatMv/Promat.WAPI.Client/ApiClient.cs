using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Promat.WAPI.Shared;

namespace Promat.WAPI.Client
{
    public class ApiClient
    {
        public ApiResponse Run(ClientCfg CC, string MethodName, string Data)
        {
            var PL = new Payload() { MethodId = MethodName, 
                                     DataType = PayloadDataType.JSON, 
                                     Data = Utiles.EncodeStrToBase64(Data) };
            var PLJS = Utiles.JSONSerialize(PL);
     
            using(var client = new HttpClient()) {
                try {
                    client.BaseAddress = new Uri(CC.BaseUri);
                    client.DefaultRequestHeaders.Add("Authorization", "Basic " + CC.Token);
                    
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/data/execute");
                    request.Content = new StringContent(PLJS, Encoding.UTF8, "application/json");

                    var response = (client.SendAsync(request)).Result;
                    if (response.StatusCode == HttpStatusCode.OK) {
                        var contents = response.Content.ReadAsStringAsync().Result;
                        return ApiResponse.OK(contents); ;
                    }
                    else {
                        var contents = response.Content.ReadAsStringAsync().Result;
                        return ApiResponse.Fail(contents);
                    }
                }
                catch(Exception Ex) {
                    return ApiResponse.Fail(Ex.Message);
                }
            }
        }
    }
}
