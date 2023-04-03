using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_NetCore2023.Models
{
    public class Banque
    {
        private Dictionary<string, Courant> _comptes;//besoin d etre instancié si solution 2
        
        public string Name { get; set; }
        public Dictionary<string, Courant> Comptes 
        { 
            get {  return _comptes = _comptes ?? new Dictionary<string, Courant>(); } 
        }
        //soluce 2 keyvaluepair
        //public KeyValuePair<string, Courant>[] Comptes 
        //{ 
        //    get { return _comptes.ToArray(); } 
        //}

        public Courant this[string numero]
        {
            get
            {
                Comptes.TryGetValue(numero, out Courant c);
                return c;
            }
        }

        public void Ajouter(Courant c)
        {
            if (Comptes.ContainsKey(c.Numero))
                return;
            Comptes.Add(c.Numero, c);
        }

        public void Supprimer(string numero)
        {
            Comptes.Remove(numero);
        }

        public decimal AvoirDesCompte(Personne p)
        {
            decimal avoir = 0;
            foreach(KeyValuePair<string, Courant> kvp in Comptes)
            {
                if(kvp.Value.Titulaire == p)
                {
                    avoir += kvp.Value;
                }
            }
            return avoir;
        }
    }
}
