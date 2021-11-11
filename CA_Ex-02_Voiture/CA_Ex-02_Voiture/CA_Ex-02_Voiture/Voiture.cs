using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Ex_02_Voiture
{
    class Voiture
    {
        private DateTime _datefabrication;
        private string _marque;
        private string _model;
        private string _couleur;
        private bool _etatmoteur;
        private int _vitesse;
        private string _klaxon;
        private int _numeroSerie;

        /// <summary>
        /// Constructeur ...
        /// </summary>
        /// <param name="marque">marque du véhicule</param>
        /// <param name="model"></param>
        /// <param name="couleur"></param>
        public Voiture(string marque, string model, string couleur)
            :this(marque, model, couleur, new Random().Next(1, 10000))
        {      
        }

        public Voiture(string marque, string model, string couleur, int numeroSerie)
        {
            _datefabrication = DateTime.Now;
            _marque = marque;
            _model = model;
            _couleur = couleur;
            _numeroSerie = numeroSerie;
        }

        public Voiture(string marque, string model):this(marque,model,"Rose Bonbon")
        {
        }

        public int NumeroSerie
        {
            get { return _numeroSerie; }
            private set { _numeroSerie = value; }
        }


        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public string Klaxoner()
        {
            return "BIP BIP BIP BIP BIP BOUGE TA CAISSE";
        }

        public string DemarrerMoteur()
        {
            if (_etatmoteur == false)
            {
                _etatmoteur = true;
                return "Vrooooum";
            }
            else
            {
                return "Grrrrr";
            }
        }

        public int Accelerer()
        {
            if (_etatmoteur == true)
            {
                return _vitesse += 10;
            }
            return _vitesse;
        }
        public int Freiner()
        {
            if (_vitesse <= 20)
            {
                return _vitesse = 0;
            }
            else
            {
                return _vitesse -= 20;
            }
                
        }

        public string ArretMoteur()
        {
            if (_etatmoteur != false)
            {
                _etatmoteur = false;
                return "Moteur éteint";
            }
            else
            {
                return "Moteur déjà éteint";
            } 
        }

        public override string ToString()
        {
            return _marque + ", " + _model + ", " + _couleur;
        }
    }
}
