using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone.domain.models
{
    public class Iphone : SmartPhone
    {

        public Iphone() {}

        public Iphone(string number, string model, string imei, int memory) 
        : base(number, model, imei, memory){}
        
        public override string? AppInstall(string name)
        {
           return $"Stalling an Iphone App {name}";
        }
    }
}