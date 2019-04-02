using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produits_High_Techs.Business
{
   [Serializable]
   public class Produit
    {
        //champs
        private int numero;
        private int quantite;
        private double prix;
        private DateTime dateFab;
        private EnumTypeProduit type;

        //Get&Set

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public DateTime DateFab
        {
            get { return dateFab; }
            set { dateFab = value; }
        }
        public EnumTypeProduit Type
        {
            get { return type; }
            set { type = value; }
        }

        //Constructeurs

        public Produit()
        {
            this.numero = 0000;
            this.quantite = 00;
            this.prix = 00;
            this.type = EnumTypeProduit.unknown;
        }

        public Produit(int numero, int quantite, double prix, DateTime date, EnumTypeProduit type)
        {
            this.numero = numero;
            this.quantite = quantite;
            this.prix = prix;
            this.type = type;
            this.dateFab = date;
        }

        // Fonction
        override
        public string ToString()
        {
            string state;
            return state = this.numero + "\t\t" + this.quantite + "\t\t" + this.prix + "$\t\t" + this.type + "\t\t" + this.dateFab + "\t\n";
        }

    }
}
