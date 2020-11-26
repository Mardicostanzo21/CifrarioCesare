using CaesarChiperLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CesarChiperLibrary
{
    public class CaesarCode: CaesarBase
    {
        public string ChiperText { get; set; }
        public CaesarCode(string message,int key)
        {
            key = key;
            ChiperText = DoWork(message);
        }

    }
}
