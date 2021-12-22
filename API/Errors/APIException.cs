using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class APIException
    {
        public APIException(int statusCode, string messgae = null, string details = null)
        {
            StatusCode = statusCode;
            Messgae = messgae;
            Details = details;
        }

        public int StatusCode { get; set; }

        public string Messgae { get; set; }

        public string Details { get; set; }
    }
}