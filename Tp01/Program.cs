using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Tp01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("abril2017.txt");
            Ponto umponto = new Ponto();
            String buffer;
            List<Ponto> ponto = new List<Ponto>();
            int i = 0;

            buffer = file.ReadLine();
            while (buffer != null)
            {
                umponto.setMatricula(buffer.Substring(0, 15));
                umponto.setData(buffer.Substring(15, 6));
                umponto.setHora(buffer.Substring(21, 4));
                umponto.setPersonalizado(buffer.Substring(25));
                ponto.Add(new Ponto());
                ponto[i] = umponto;
                i++;

                buffer = file.ReadLine();
            }
            TextWriter arquivo = new StreamWriter("ponto.xml");
            XmlSerializer obj = new XmlSerializer(ponto.GetType());

            obj.Serialize(arquivo, ponto);
            arquivo.Close();
            Console.ReadKey();
        }
    }
}
