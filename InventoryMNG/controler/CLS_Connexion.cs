using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMNG.BL
{
    internal class CLS_Connexion
    {
        // fonction pour vérifier la connexion
        public bool ConnexionValide(Model.DbStockContext db, string Nom, string Mot_De_Passe)
        {
            Model.admin add = new Model.admin(); // table utilisateur
            add.name = Nom;
            add.password = Mot_De_Passe;
            if (db.admins.SingleOrDefault(s => s.name == Nom && s.password == Mot_De_Passe) != null) //si le nom d'utilisateur et le mot de passe existe dans la base de données
            {
                return true;
            }
            else // si n'existe pas
            {
                return false;
            }
        
        }
    }

}
