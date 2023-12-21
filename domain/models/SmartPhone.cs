using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone.domain.models
{
    public abstract class SmartPhone
    {
        public string? Number { get; set; }
        private string? _model;
        private string? _imei;
        private int _memory;

        public SmartPhone() {}

        public SmartPhone(string number, string model, string imei, int memory) {
            this.Number = number;
            this._model = model;
            this._imei = imei;
            this._memory = memory;
        }

        public void SetModel(string model) 
        {
            this._model = model;
        }

        public string? GetModel()
        {
            return this._model;
        }

          public void SetImei(string imei) 
        {
            this._imei = imei;
        }

        public string? GetImei()
        {
            return this._imei
        }

          public void SetMemory(int memory) 
        {
            this._memory = memory;
        }

        public int GetMemory()
        {
            return _memory;
        }

    }
}