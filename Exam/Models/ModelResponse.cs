using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Business
{
    public class ModelResponse
    {
        public ModelResponse()
        {
            Success = false;
        }

    
        public String Message { get; set; }
        public bool Success { get; set; }
        public dynamic Value {  get; set; }
    }
}