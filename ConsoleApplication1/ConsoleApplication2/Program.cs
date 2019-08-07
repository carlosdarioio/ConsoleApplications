using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static int isPrimeHappy(int num)
        {
            int a = 0, Result = 0;
            for (int i = 1; i <= num; i++)
            {
                a = i % 2;
                if (a != 0)
                {
                    Result += i;                    
                }

            }


            if ((num*10 % Result) != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        static void Main(string[] args)
        {
            int n = 2;
            Console.WriteLine(isPrimeHappy(n));
            

            byte[] hash = Md5Sum_Raw("a");
            for (int i = 0; i < hash.Length; i++)
                System.Console.Out.Write(hash[i] + " ");
            System.Console.Out.WriteLine();



            string txt = "response=1&responsetext=SUCCESS&authcode=123456&transactionid=3979982584&avsresponse=&cvvresponse=&orderid=CredomaticTest&type=sale&response_code=100";
            string resi = txt.Split('&')[0];
            resi = resi.Split('=')[1];

            System.Console.Out.Write(resi);
            System.Console.Out.Write("alola");
            System.Console.Out.WriteLine(long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss")));

            //----------------------------

            string alola = "$20";
            string a2 = "";
            int num1 = 0;
            try
            {
                a2 = alola.Split('.')[1];
            }
            catch (Exception e)
            {
                a2 = alola.Split('$')[1];
                num1 = Convert.ToInt32(a2) + 5;
            }
            Console.WriteLine("num1: ");
            Console.WriteLine(num1);
            
            
            Console.WriteLine("HERE ");
            Console.WriteLine(Base64Encode("37091"));



            //{ "GetEntregaResult":{ "cadName":"c999999","cardCode":"consumidor final","docEntry":"987456","docNum":"10405060","message":"message txt ver ok","postEntrega":[{"dscription":"India","itemCode":"10550","quantity":"781","u_DevAvailableQty":"India"}],"status":0}}
            Console.WriteLine("String To byte ");
            Console.WriteLine(Base64Encode("{\"GetEntregaResult\":{\"cadName\":\"c999999\",\"cardCode\":\"consumidor final\",\"docEntry\":\"987456\",\"docNum\":\"10405060\",\"message\":\"message txt ver ok\",\"postEntrega\":[{\"dscription\":\"India\",\"itemCode\":\"10550\",\"quantity\":\"781\",\"u_DevAvailableQty\":\"India\"}],\"status\":0}}"));


            //
            Console.WriteLine("byte To String");
            Console.WriteLine(Base64Decode("eyJHZXRFbnRyZWdhUmVzdWx0Ijp7ImNhZE5hbWUiOiJjOTk5OTk5IiwiY2FyZENvZGUiOiJjb25zdW1pZG9yIGZpbmFsIiwiZG9jRW50cnkiOiI5ODc0NTYiLCJkb2NOdW0iOiIxMDQwNTA2MCIsIm1lc3NhZ2UiOiJtZXNzYWdlIHR4dCB2ZXIgb2siLCJwb3N0RW50cmVnYSI6W3siZHNjcmlwdGlvbiI6IkluZGlhIiwiaXRlbUNvZGUiOiIxMDU1MCIsInF1YW50aXR5IjoiNzgxIiwidV9EZXZBdmFpbGFibGVRdHkiOiJJbmRpYSJ9XSwic3RhdHVzIjowfX0="));

            Console.ReadLine();
        }

        public static byte[] Md5Sum_Raw(string strToEncrypt)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            byte[] bytes = ue.GetBytes(strToEncrypt);

            // encrypt bytes
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return md5.ComputeHash(bytes);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}


