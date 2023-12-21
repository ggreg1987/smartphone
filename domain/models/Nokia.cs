using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone.domain.models
{
    public class Nokia : SmartPhone
    {

        public Nokia() {}

        public Nokia(string number, string model, string imei, int memory) 
        : base(number, model, imei, memory) {}
        

        public override string? AppInstall(string name)
        {
            return $"Installing a Nokia App {name}";
        }
    }
}