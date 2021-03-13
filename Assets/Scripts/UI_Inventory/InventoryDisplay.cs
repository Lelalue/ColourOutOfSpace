using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using AlienColour.Assets.Scripts.Interactables;
using AlienColour.Assets.Scripts.Sound;
using AlienColour.Assets.Scripts.FirstPersonCamera;
using TMPro;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class InventoryDisplay : MonoBehaviour, IDisplay
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
                    case "texttrigger":
                        Texttrigger();
                        break;
                    case "well":
                        Well();
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
                    case "cemetery":
                        Cemetery();
                        break;
                    case "cup":
                        Cup();
                        break;
                    case "bucket":
                        Bucket();
                        break;
                   
                }
            }
        }

        public void Key()
        {

            string[] messageArray = new string[]
            {

                "Seems like this key hasn't been used in a while. Maybe we'll find the right lock for it.",
            };

            SoundManager.PlaySound(SoundManager.Sound.pickup, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.key1, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);

        }

        public void Something()
        {
            string[] messageArray = new string[]
           {
                "This flower looks pretty but somewhat off, just like some other things around here... I can't put my finger on it.",

           };

            SoundManager.PlaySound(SoundManager.Sound.pickup, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.flower, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Apple()
        {
            string[] messageArray = new string[]
            {
                "What a gigantic apple, how did it become this big? It tastes terrible though, I need a drink to get rid of the taste.",

            };

            SoundManager.PlaySound(SoundManager.Sound.apple, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.applebite, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Letter()
        {
            
            string[] messageArray = new string[]
            {
                "A Letter from scientists. Looks pretty old. Maybe it reveals what has happened here.",
            };

            SoundManager.PlaySound(SoundManager.Sound.book, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.letterpickup, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Diary()
        {
            

            string[] messageArray = new string[]
            {

                "This diary shocked me. The boy seems distraught. I can't just walk away without knwoing what happened to him and his family.",

            };

            SoundManager.PlaySound(SoundManager.Sound.book, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.diarypickup, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Water()
        {
            string[] messageArray = new string[]
            {

                "How refreshing, water from a well on a hot summer day. But do I taste something odd? Probably not, I must be dehydrated from the sun.",
            };

            SoundManager.PlaySound(SoundManager.Sound.drink, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.water, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Scene()
        {
            string[] messageArray = new string[]
            {
                "This is a steep descent. Hopefully there is another way out of this valley... I have no idea where I am.",
            };

            SoundManager.PlaySound(SoundManager.Sound.szene1, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Well()
        {
            string[] messageArray = new string[]
            {

               "Looks like I could get some refreshing water to drink here. But I see no bucket...",

            };

            SoundManager.PlaySound(SoundManager.Sound.well, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);

        }

        public void Texttrigger()
        {
            string[] messageArray = new string[]
            {
            "There is a house! I hope there are people there. I am starving.",
            };

            SoundManager.PlaySound(SoundManager.Sound.ausblick, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Tulip()
        {
            string[] messageArray = new string[]
            {
                "What a beautiful tulip. It is gigantic, someone must have used a lot of fertilizer.",
            };

            SoundManager.PlaySound(SoundManager.Sound.tulip, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }
        public void Pear()
        {
            string[] messageArray = new string[]
            {
                "I won't try these pears. They are as big as the apples... they'll probably taste just as terrible!"
            };

            SoundManager.PlaySound(SoundManager.Sound.pear, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Crocus()
        {
            string[] messageArray = new string[]
            {
                "I wonder how these flowers got so big and shiny!"
            };

            SoundManager.PlaySound(SoundManager.Sound.crocus, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Cemetery()
        {
            string[] messageArray = new string[]
            {
                "A cemetery next to an abandoned house. Well, that's a little scary, I wouldn't want to be here alone at night!"
            };

            SoundManager.PlaySound(SoundManager.Sound.cemetery, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        public void Cup()
        {
            string[] messageArray = new string[]
            {
                "At least I found a cup and a bottle of water. I'm soo thirsty!"
            };

            SoundManager.PlaySound(SoundManager.Sound.cup, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }
        public void Bucket()
        {
            string[] messageArray = new string[]
            {
                "Oh! A bucket! My dream of fresh water might come true!"
            };

            SoundManager.PlaySound(SoundManager.Sound.bucket, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }

        



    }

}