using CaesarChiperLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CesarChiperLibrary
{
    public class CaesarCode: CaesarBase
    {
        public string CipherText { get; set; }
        public CaesarCode(string message,int key)
        {

            key = key;
            CipherText = DoWork(message);

        }

    }
}
