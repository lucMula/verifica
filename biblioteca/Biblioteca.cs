using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Biblioteca
    {
        public string nome;
        public string indirizzo;
        public int oraApretura;
        public int oraChiusura;
        public List<Libro> libriTotalli;
        public Biblioteca(string nome, string indirizzo,int oraApertura, int oraChiusura)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;     
            this.oraApretura = oraApertura;
            this.oraChiusura = oraChiusura;
            libriTotalli = new List<Libro>();
        }
        public void addLibro(Libro libro)
        {
            libriTotalli.Add(libro);
        }
        public string ricercaTitolo(string titolo)
        {
            for(int i = 0; i < libriTotalli.LongCount(); i++)
            {
                if(libriTotalli[i].getTitolo() == titolo)
                {
                    return libriTotalli[i].toString();
                }
            }
            return ("Libro non trovato");
        }
        public string ricercaLibriAutore(string autore)
        {
            for (int i = 0; i < libriTotalli.LongCount(); i++)
            {
                if (libriTotalli[i].getAutore() == autore)
                {
                    return libriTotalli[i].toString();
                }
            }
            return ("Non è stato trovato nessun libro di "+ autore);
        }

        public int numeroDilibriTotali()
        {
            return libriTotalli.Count();
        }
            
    }
}
