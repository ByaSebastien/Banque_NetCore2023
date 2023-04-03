using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque_NetCore2023.Models
{
    public class Courant
    {
        private decimal _ligneDeCredit;

        #region Props
        public string Numero { get; set; }
        public decimal Solde { get; private set; }
        public decimal LigneDeCredit 
        {
            get
            {
                return _ligneDeCredit;
            }
            set
            {
                if (value < 0)
                    return;
                _ligneDeCredit = value;
            }
        }
        #endregion
        public Personne Titulaire { get; set; }

        #region Methodes
        /// <summary>
        /// Retire un montant au Solde du compe
        /// </summary>
        /// <param name="montant">le montant à retirer au solde</param>
        public void Retrait(decimal montant)
        {
            if (montant < 0)
                return;
            if (Solde - montant < -LigneDeCredit)
                return;
            Solde -= montant;
        }

        /// <summary>
        /// Ajoute un montant au Solde du compe
        /// </summary>
        /// <param name="montant">le montant à ajouter au solde</param>
        public void Depot(decimal montant)
        {
            if(montant < 0)
                return;
            Solde += montant;
        }
        #endregion
    }
}
