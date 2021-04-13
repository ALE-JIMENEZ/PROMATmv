using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promat.WAPI.Client
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }

        public ApiResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
        public ApiResponse(bool success, string message, string data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public static ApiResponse OK(string message, string data = null)
        {
            return new ApiResponse(true, message, data);
        }

        public static ApiResponse Fail(string message, string data = null)
        {
            return new ApiResponse(false, message, data);
        }
    }
}
