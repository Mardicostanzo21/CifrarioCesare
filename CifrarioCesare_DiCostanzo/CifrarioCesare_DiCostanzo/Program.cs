﻿using CesarChiperLibrary;
using System;

namespace CifrarioCesare_DiCostanzo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una parola: ");
            string plaintext = Console.ReadLine();
            int key;
            CaesarCode ml;
            try
            {
                do
                {
                    Console.WriteLine("Inserisci la chiave (ATTENZIONE! I caratteri dell'alfabeto italiano sono 21)");
                    key = int.Parse(Console.ReadLine());
                } 
                while (key < 0 || key > 25);

                ml = new CaesarCode(plaintext, key);
                Console.WriteLine($"Il testo cifrato è: {ml.CipherText}");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
