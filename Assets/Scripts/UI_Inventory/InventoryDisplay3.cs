using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using AlienColour.Assets.Scripts.Interactables;
using AlienColour.Assets.Scripts.Sound;
using AlienColour.Assets.Scripts.FirstPersonCamera;
using AlienColour.Assets.Scripts.UI_Inventory;
using TMPro;

namespace AlienColour.Assets.Scripts.Inventorygrey
{
    public class InventoryDisplay3 : MonoBehaviour, IDisplay
    {
        TextMeshProUGUI displayText;
        [SerializeField] public Collector coll;
        private TextWriterSingle textwriterSingle;
        public CharacterControl control;

        private void Start()
        {
            displayText = GetComponent<TextMeshProUGUI>();
            SoundManager.Initialize();

            Scene();
        }


        public void SetText(string name)
        {
            if (textwriterSingle != null && textwriterSingle.IsActive())
            {
                textwriterSingle.writeAndDestroy();
            }
            else
            {
                switch (name)
                {
                    case "key":
                        Key();
                        break;
                    case "blume":
                        Something();
                        break;
                    case "letter":
                        Letter();
                        break;
                    case "diary":
                        Diary();
                        break;
                    case "apple":
                        Apple();
                        break;
                    case "water":
                        Water();
                        break;
                    case "scene":
                        Scene();
                        break;
                    case "tulip":
                        Tulip();
                        break;
                    case "pear":
                        Pear();
                        break;
                    case "crocus":
                        Crocus();
                        break;
                    case "well":
                        Well();
                        break;
                    case "cemetery":
                        Cemetery();
                        break;
                    case "cup":
                        Cup();
                        break;
                    case "bucket":
                        Bucket();
                        break;
                    case "grey":
                        Change();
                        break;
                    case "last":
                        Last();
                        break;
                }
            }
        }

        public void Key()
        {

            string[] messageArray = new string[]
            {
                "Nobody needs this anymore. No one should enter the house.",
            };

            SoundManager.PlaySound(SoundManager.Sound.pickup, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.key3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);

        }

        public void Something()
        {
            string[] messageArray = new string[]
           {
                "Everything is grey and dry. Spooky.",
           };

            SoundManager.PlaySound(SoundManager.Sound.pickup, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.flower3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Apple()
        {
            string[] messageArray = new string[]
            {
                "The apple looks rotten and grey. Oh my... it looks like life got sucked out of it.",
            };

            SoundManager.PlaySound(SoundManager.Sound.apple3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Letter()
        {

            string[] messageArray = new string[]
            {
                "This meteorite is the reason for all of it.",
            };
            SoundManager.PlaySound(SoundManager.Sound.book, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.letterpickup3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Diary()
        {


            string[] messageArray = new string[]
            {
                "I think I finally understand. They were haunted by this color. It creeped into them and made them go crazy. It nurtured from them like a parasite.",
            };
            SoundManager.PlaySound(SoundManager.Sound.book, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.diarypickup3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Water()
        {
            string[] messageArray = new string[]
            {
                "Never again. It creeps inside you.",
            };


            SoundManager.PlaySound(SoundManager.Sound.water3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Well()
        {
            string[] messageArray = new string[]
            {

               "Maybe there is still something down there...I should probably leave it alone or it will haunt me too",

            };
            SoundManager.PlaySound(SoundManager.Sound.well3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);

        }
        public void Scene()
        {
            string[] messageArray = new string[]
            {
                "Oh my... things are getting serious. What the hell? How did I get into this. The colour... it looks like it sucked the life out of everything like a vampire.",
            };

            SoundManager.PlaySound(SoundManager.Sound.szene3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }
        public void Tulip()
        {
            string[] messageArray = new string[]
            {
                "Black and rotten, like everything else around here. Everything is affected...I am scared. "
            };

            SoundManager.PlaySound(SoundManager.Sound.tulip3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Pear()
        {
            string[] messageArray = new string[]
            {
                "Did the same that happened to the plants also happen to the family?"
            };

            SoundManager.PlaySound(SoundManager.Sound.pear3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        
        public void Crocus()
        {
            string[] messageArray = new string[]
            {
                "Ugh... no! This is way too creepy... "
            };

            SoundManager.PlaySound(SoundManager.Sound.crocus3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Cemetery()
        {
            string[] messageArray = new string[]
            {
                "Well, if this whole valley is haunted I should definitley stay away from the cemetery. What if the family is buried right here next to me.. I need to get out of here!"
            };

            SoundManager.PlaySound(SoundManager.Sound.cemetery3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Cup()
        {
            string[] messageArray = new string[]
            {
                "There must have been something wrong with this water as well. I have been hallucinating since I had a sip."
            };

            SoundManager.PlaySound(SoundManager.Sound.cup3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }
        public void Bucket()
        {
            string[] messageArray = new string[]
            {
                "This broken bucket saved my life! Thank goodness I never got water out of the well."
            };

            SoundManager.PlaySound(SoundManager.Sound.bucket3, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Change()
        {
            string[] messageArray = new string[]
            {
                "This area is haunted for sure. I have never seen anything like this. Are the plants grey? I HAVE to leave now."
            };

            SoundManager.PlaySound(SoundManager.Sound.grey, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Last()
        {
            string[] messageArray = new string[]
            {
                "There must be a way out of this valley. I will try the same spot I came from, I have no other chance."
            };

            SoundManager.PlaySound(SoundManager.Sound.last, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }



    }

}