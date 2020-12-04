using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int key  = int.Parse(Console.ReadLine());
            string regexPatern = @"(@(?<kidsName>[A-Za-z][a-z]+)([^@|-|!|:|>]|[^A-Za-z])(\w?)+)!(?<behavior>[G])!";
          string input = string.Empty;
            List<string> goodKidsName = new List<string>();
            while ( (input = Console.ReadLine( )) != "end" )
            {
                var resultedMessage = string.Empty;
                for ( int i = 0; i < input.Length; i++ )
                {
                    resultedMessage += ( char ) (input [ i ] - key);
                }
                
                if ( Regex.Match( resultedMessage, regexPatern ).Success )
                {
                    Match nameAndBehavior = Regex.Match(resultedMessage,regexPatern);
                    goodKidsName.Add( nameAndBehavior.Groups [ "kidsName" ].Value);
                }
            }
            Console.WriteLine( string.Join( Environment.NewLine, goodKidsName ) );
        }
    }
}
