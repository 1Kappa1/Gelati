using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace capanna.alessandro._4H.gelati.Models
{
    public class Gelato
    {
        public string Tipo { get; set; }
        public string Size { get; set; }

        public string Gusto { get; set; }

        public Gelato(string str) 
        {
            string [] colonne = str.Split(";");
            this.Tipo= colonne[0];
            this.Size = colonne[1];
            this.Gusto= colonne[2];
        }
    }

    public class Gelati:List<Gelato> 
    { 
        public Gelati() 
        { 
        }

        public Gelati(string File_Name)
        {
            using(StreamReader fin= new StreamReader(File_Name))
            { 
                while(!fin.EndOfStream)
                {
                    string str=fin.ReadLine();
                    Gelato g=new Gelato(str);
                    Add(g);
                }    
            }
        }
    }
}
