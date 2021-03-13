using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using AlienColour.Assets.Scripts.Interactables;
using AlienColour.Assets.Scripts.Sound;
using AlienColour.Assets.Scripts.FirstPersonCamera;
using AlienColour.Assets.Scripts.UI_Inventory;
using TMPro;

namespace AlienColour.Assets.Scripts.Inventorycolor

{
    public class InventoryDisplay2 : MonoBehaviour, IDisplay
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
                    case "well":
                        Well();
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
                    case "cemetery":
                        Cemetery();
                        break;
                    case "trees":
                        Trees();
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
                "Now I get why they left the key... they just wanted to get away as fast as they could... "
            };

            SoundManager.PlaySound(SoundManager.Sound.pickup, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.key2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);

        }

        public void Something()
        {
            string[] messageArray = new string[]
           {
                
                "The whole flora seems to be affected by this mysterious hue. It looks like a whirlwind of color, it gives me the chills.",
           };

            SoundManager.PlaySound(SoundManager.Sound.pickup, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.flower2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Apple()
        {
            string[] messageArray = new string[]
            {
                "Now it looks as disgusting as it tastes. How did it change so quickly? ",
            };


            SoundManager.PlaySound(SoundManager.Sound.apple2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Letter()
        {

            string[] messageArray = new string[]
            {
                "I wonder if the meteorite has something to do with the absurd situation here. So many abnormal things are happening. But how could a meteorite affect nature like this? ",

            };

            SoundManager.PlaySound(SoundManager.Sound.book, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.letterpickup2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Diary()
        {


            string[] messageArray = new string[]
            {

                "I bet they suffered from the same illusions - am I hallucinating? Am I getting crazy just like them?",

            };

            SoundManager.PlaySound(SoundManager.Sound.book, control.GetPosition());
            SoundManager.PlaySound(SoundManager.Sound.diarypickup2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Water()
        {
            string[] messageArray = new string[]
            {
                 "Since I drank this water, something is definitely different. There must be something in the well!",
            };


            SoundManager.PlaySound(SoundManager.Sound.water2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Well()
        {
            string[] messageArray = new string[]
            {
                "Sparkles are coming out of the well now. Oh my ... this must be connected to the meteorite. Did it fall into the water?",


            };
            SoundManager.PlaySound(SoundManager.Sound.well2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);

        }
        public void Scene()
        {
            string[] messageArray = new string[]
            {
               "What is going on now? Everything is so colorful! It's sparkling and dancing. It looks beautiful but totally wrong. Is there radiation around here? Is that what the family was affected by? ",  };

            SoundManager.PlaySound(SoundManager.Sound.szene2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Tulip()
        {
            string[] messageArray = new string[]
            {
                "Such extraordinary colors! But it freaks me out...this area seems to be contaminated."   
            };

            SoundManager.PlaySound(SoundManager.Sound.tulip2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Pear()
        {
            string[] messageArray = new string[]
            {
                 "These pears look as strange and disgusting as the apples... I cannot believe I ate one of these earlier.. wuaaah."

            };

            SoundManager.PlaySound(SoundManager.Sound.pear2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }
        public void Crocus()
        {
            string[] messageArray = new string[]
            {
                "Ok, the flora around the house is going crazy.. I wonder... "
            };

            SoundManager.PlaySound(SoundManager.Sound.crocus2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Cemetery()
        {
            string[] messageArray = new string[]
            {
                "I feel like I saw something move. Wait, are the trees in the cemetery moving? I wonder who is buried there, but I am too scared to walk up to the gravestones!"
            };

            SoundManager.PlaySound(SoundManager.Sound.cemetery2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Trees()
        {
            string[] messageArray = new string[]
            {
                "What has happened out here? The trees are moving... but I cannot feel any wind! Wait! - Did the colours around me change? Maybe a thunderstorm is coming."
            };

            SoundManager.PlaySound(SoundManager.Sound.trees, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.05f, true, true);
        }

        public void Cup()
        {
            string[] messageArray = new string[]
            {
                "Is this water making me feel strange? I hope it is not from the well…. No, the bottle was closed when I got here"
            };

            SoundManager.PlaySound(SoundManager.Sound.cup2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }
        public void Bucket()
        {
            string[] messageArray = new string[]
            {
                "How did I not see that it is broken. I’m an idiot."
            };

            SoundManager.PlaySound(SoundManager.Sound.bucket2, control.GetPosition());
            string message = messageArray[Random.Range(0, messageArray.Length)];
            textwriterSingle = Textwriter.AddWriter_Static(displayText, message, 0.03f, true, true);
        }


    }

}