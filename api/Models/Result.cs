﻿namespace api.Models
{
    public class Result
    {
        public bool success { get; set; }
        public int errorCode { get; set; }
        public string errorMessage { get; set; }
        public string data { get; set; }

        public Result() {
            success = false;
            errorCode = 0;
            errorMessage = string.Empty;
            data = string.Empty;
        }
    }
}
