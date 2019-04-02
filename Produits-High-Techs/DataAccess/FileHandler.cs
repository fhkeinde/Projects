using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Produits_High_Techs.Business;

namespace Produits_High_Techs.DataAccess
{
    public class FileHandler
    {
        // Chemin
        static string filePath = @"../../DataAccess/Produits.bin";
        // Ecrire
        public static void WriteToFile(List<Produit> list)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();
            foreach (Produit item in list)
            {
                bin.Serialize(fs, item);
            }
            fs.Close();
        }
        //lire
        public static List<Produit> ReadFromFile()
        {
            List<Produit> list = new List<Produit>();
            if (File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Produit unProduit = new Produit();
                    unProduit = (Produit)bin.Deserialize(fs);
                    list.Add(unProduit);
                }
                fs.Close();
            }
            return list;
        }
    }
}
