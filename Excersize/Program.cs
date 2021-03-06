﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Excersize
{ 
    public class Program
    {
        static bool CheckPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"\(?\d{3,4}([- ]?|(\)\()?)+\d{3}([- ]?|(\)\()?)+\d{4}\)?");
        }
        static void Main(string[] args)
        {

            /*   string PhoneNumber = "8183463164";
               Console.WriteLine(CheckPhoneNumber(PhoneNumber));
               Console.WriteLine(CheckPhoneNumber("818-646-4852"));
               Console.WriteLine(CheckPhoneNumber("818 -646-4852"));
               Console.WriteLine(CheckPhoneNumber("818-646-4852"));
               Console.WriteLine(CheckPhoneNumber("8186464852"));
               Console.WriteLine(CheckPhoneNumber("(818)(646)(4852)"));
              */
           // Console.WriteLine(Regex.IsMatch("(", @"\p{P}"));
            RegexTokenizer tokenizer = new RegexTokenizer();
            ReadOnlyMemory<char> x = MemoryExtensions.AsMemory(File.ReadAllText(@"text.txt"));
            tokenizer.Tokenize(x);
            Console.ReadKey();
        }
    }

}
