using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierPasAvecEntity
{
    class Program
    {
        static void Main(string[] args)
        {

            //connexio a la base de données avec "using" qui pointe vers la BDD
            using (var entities = new MaPremierBDDEntities())
            {
                //creation d'un nouveau clent dans la base
                var clientAjouter = new Client()
                {
                    Nom = "Yvette",
                    Prenom = "louisette",
                    Age = 35,
                    Sexe = "F"
                };

                //ajout du client
                entities.Clients.Add(clientAjouter);

                //sauvegade des changements de la base
                entities.SaveChanges();


                //enumerer les client de la base de sexe Masculin
                foreach(var client in entities.Clients.Where((client)=>client.Sexe=="M"))
                {
                    Console.WriteLine($"Nom : { client.Nom},Prenom : {client.Prenom}, Age : {client.Age}, Sexe : {client.Sexe}");
                }

            }

            Console.ReadLine();
        }
    }
}
