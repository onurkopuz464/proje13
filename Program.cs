using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        islem instance= new islem();
        /*instance.Topla(4,3, out int cevap);
        Console.WriteLine(cevap);*/

        int value = 999;
        instance.write(value.ToString());
        instance.write(value);
    


    }
    class islem
    {
        public void Topla(int x, int y, out int cevap)
        {
            cevap = x+y;

        }

        public void write(string veri)
        {
            Console.WriteLine(veri);
        }
        public void write(int veri)
        {
            Console.WriteLine(veri);
        }



    }
        
}
