using System;

namespace CNPM_FINAL.Context
{
    public class BuisinessException : Exception
    {
        public BuisinessException() : base() { }

        public BuisinessException(string message) : base(message) { }
    }
}
