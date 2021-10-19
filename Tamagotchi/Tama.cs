/* Projet   : Tamagotchi
 * Version  : 1.0
 * Date     : 14.10.2021
 * 
 * Desc.    : Permet de créer un Tama (Tamagotchi) et simule une existance
 */
using System;
using System.Collections.Generic;
using System.Timers;

namespace Tamagotchi
{
    class Tama
    {
        private List<string> _lstExpressions = new List<string>();
        private string _nom;
        private int _calorie;
        private int _liquide;
        private int _fatigue;
        private int _virus;
        private int _secondeEnVie;
        private int _vitesseJeu;
        private static Timer _timerVie;
        private int compteur;
        private int compteurLapin = 0;

        //Détermine quand le jeu devient plus complexe et que les statistique du Tama sont critiques
        const int PLAGE = 20;
        

        public string Nom
        {
            get
            {
                return _nom;
            }
        }
        public int Calorie
        {
            get
            {
                return _calorie;
            }
        }

        public int Liquide
        {
            get
            {
                return _liquide;
            }
        }

        public int Fatigue
        {
            get
            {
                return _fatigue;
            }
        }

        public int Virus
        {
            get
            {
                return _virus;
            }
        }

        public int SECONDEENVIE
        {
            get
            {
                return _secondeEnVie;
            }
        }
        /// <summary>
        /// Permet de créer un Tama (Tamagotchi)
        /// </summary>
        /// <param name="nom">Le nom du Tama</param>
        /// <param name="calories">Les calories de départ</param>
        /// <param name="liquide">Le liquide de départ</param>
        /// <param name="fatigue">La fatigue de départ</param>
        /// <param name="virus">Le virus de départ</param>
        /// <param name="vitesseJeu">La vitesse du jeu (jeu lent env. 100, jeu rapide env. 10)</param>
        public Tama(string nom, int calories, int liquide, int fatigue, int virus, int vitesseJeu)
        {
            _nom = nom;
            _calorie = calories;
            _liquide = liquide;
            _fatigue = fatigue;
            _virus = virus;
            _vitesseJeu = vitesseJeu;
            //On lance le timer pour connaîte la durée de vie du tama
            SetTimer();
        }

        /// <summary>
        /// Permet de vérifier l'état de santé
        /// </summary>
        /// <returns>Si le Tama n'est pas en critique, il affiche "rien à signaler". Sinon il affiche son état</returns>
        public string Vivre()
        {
            compteur++;
            string etat = "rien à signaler";
            Console.WriteLine(compteur.ToString());
            //On effectue une action à vitesse que l'utlisateur a souhaité
            if(compteur >=_vitesseJeu && !EstMort())
            {
                Decay(true);
                compteur = 0;
            }
            
            
            if(_calorie < PLAGE)
            {
                etat = "J'ai faim";
            }
            if (_liquide < PLAGE)
            {
                etat = "J'ai soif";
            }
            if (_fatigue > 100 - PLAGE)
            {
                etat = "Je suis fatigué";
            }
            if (_virus > 100 - PLAGE)
            {
                etat = "Je suis malade";
            }

            if (EstMort())
            {
                etat = "Il est mort";
            }

            return etat;
        }

        /// <summary>
        /// Permet de déterminer si le Tama est mort
        /// </summary>
        /// <returns>retourne si il est mort</returns>
        public bool EstMort()
        {
            bool mort;

            if(_calorie == 0 || _liquide == 0 || _fatigue == 100 || _virus == 100)
            {
                mort = true;
                _timerVie.Enabled = false;
            }
            else
            {
                mort = false;
            }

            return mort;
        }

        //Groupe de méthodes qui permettent de s'occuper du tamagotchi
        public void Manger(int valeur)
        {
            _calorie += valeur;
            _calorie = NoOutOfBounds(_calorie);

        }

        public void Boire(int valeur)
        {
            _liquide += valeur;
            _liquide = NoOutOfBounds(_liquide);
            
        }

        public void Dormir(int valeur)
        {
            _fatigue -= valeur;
            _fatigue = NoOutOfBounds(_fatigue);
        }

        public void Soigner(int valeur)
        {
            _virus -= valeur;
            _virus = NoOutOfBounds(_virus);
        }

        /// <summary>
        /// Permet d'éviter les erreurs en cas de sortie des valeurs comprises entre 0 et 100
        /// </summary>
        /// <param name="valeur">Valeur à vérifier</param>
        /// <returns>La valeur vérifiée</returns>
        private int NoOutOfBounds(int valeur)
        {
            if (valeur < 0)
            {
                valeur = 0;
            }
            if (valeur > 100)
            {
                valeur = 100;
            }
            return valeur;
            
        }

        /// <summary>
        /// Permet de gérer le déclin de l'état de santé du Tamagotchi
        /// </summary>
        /// <param name="actif">Active ou Désactive le Decay</param>
        private void Decay(bool actif)
        {
            if (actif)
            {
                Random rnd = new Random();

                //Perte continue déterminée dans une plage aléatoire
                int perteCal = rnd.Next(5, 10) / 8;
                _calorie -= perteCal;


                int perteLiquide = rnd.Next(5, 10) / 7;
                _liquide -= perteLiquide;


                int gagneFatigue = rnd.Next(5, 10) / 7;
                _fatigue += gagneFatigue;


                int gagneVirus = rnd.Next(5, 10) / 7;
                _virus += gagneVirus;

                //Ajoute des malus en cas d'état de santé critique
                if (_virus > 100 - PLAGE)
                {
                    _fatigue += 2;
                }

                if (_fatigue > 100 - PLAGE)
                {
                    _virus += 2;
                }

                if (_liquide < PLAGE)
                {
                    _virus += 2;
                }

                if (_calorie < PLAGE)
                {
                    _liquide -= 1;
                    _virus += 1;
                    _fatigue += 1;
                }

                //On vérifie si les élement ne sortent pas des plages
                _calorie = NoOutOfBounds(_calorie);
                _liquide = NoOutOfBounds(_liquide);
                _fatigue = NoOutOfBounds(_fatigue);
                _virus = NoOutOfBounds(_virus);
            }
            
        }

        /// <summary>
        /// Permet de créer une nouvelle partie
        /// </summary>
        public void NewGame(string nom, int calorie, int liquide, int fatigue, int virus, int vitesseJeu)
        {
            _nom = nom;
            _calorie = calorie;
            _liquide = liquide;
            _fatigue = fatigue;
            _virus = virus;
            _vitesseJeu = vitesseJeu;
            _secondeEnVie = 0;
            _timerVie.Enabled = true;
            EstMort();
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            _timerVie = new Timer(1000);
            // Hook up the Elapsed event for the timer. 
            _timerVie.Elapsed += OnTimedEvent;
            _timerVie.AutoReset = true;
            _timerVie.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _secondeEnVie += 1;
        }
        /// <summary>
        /// Permet de générer une suite de qui à afficher
        /// </summary>
        /// <returns></returns>
        public string ImageLapin()
        {

            if (EstMort())
            {
                return " ( )( ) " + Environment.NewLine + " (x_x) " + Environment.NewLine + " (___)0";
            }
            else
            {
                if(_calorie < PLAGE || _liquide < PLAGE)
                {
                    return " ( )( ) " + Environment.NewLine + " (o0o) " + Environment.NewLine + " (___)0";
                }
                if (_fatigue > 100 - PLAGE)
                {
                    return " ( )( ) " + Environment.NewLine + " (z.z) " + Environment.NewLine + " (___)0";
                }

                if (compteurLapin < PLAGE)
                {
                    compteurLapin++;
                    return " ( )( ) " + Environment.NewLine + " (o.o) " + Environment.NewLine + " (___)0";
                }
                else if(compteurLapin < PLAGE * 2)
                {
                    compteurLapin++;
                    return "( )( ) " + Environment.NewLine + " ( o.o) " + Environment.NewLine + "(#)(#)";
                }
                else if (compteurLapin < PLAGE * 3)
                {
                    compteurLapin++;
                    return "  ( )( ) " + Environment.NewLine + " (o.o ) " + Environment.NewLine + "  (#)(#)";
                }
                else
                {
                    compteurLapin = 0;
                    return "  ( )( ) " + Environment.NewLine + " (o.o ) " + Environment.NewLine + "  (#)(#)";

                }
                
            }
            
        }
    }
}

