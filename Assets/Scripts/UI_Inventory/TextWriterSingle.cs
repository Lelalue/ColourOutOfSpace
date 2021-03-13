using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class TextWriterSingle : MonoBehaviour
    {
        private TextMeshProUGUI text;
        private string textToWrite;
        private int characterIndex;
        private float timePerCharacter;
        private float timer;
        private bool invisibleCharacters;
        private bool removeWriter;
        private TextWriterSingle textWriterSingle;
        public float time = 6f;
        public float fadeOutTime= 6f;

        public TextWriterSingle(TextMeshProUGUI text, string textToWrite, float timePerCharacter, bool invisibleCharacters, bool removeWriter)
        {
            this.text = text;
            this.textToWrite = textToWrite;
            this.timePerCharacter = timePerCharacter;
            characterIndex = 0;
            this.invisibleCharacters = invisibleCharacters;
            this.removeWriter = removeWriter;

        }

        private void Awake()
        {
             textWriterSingle = this;
        }

     

        public bool WriteText()
        {
            text.enabled = true;

            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                timer += timePerCharacter;
                characterIndex++;
                string t = textToWrite.Substring(0, characterIndex);

                if (invisibleCharacters)
                {
                    t += "<color=#00000000>" + textToWrite.Substring(characterIndex) + "</color>";
                }
                text.text = t;

                if (characterIndex >= textToWrite.Length)
                {

                    return true;
                }
            }
           
           
            return false;
        }

        public TextMeshProUGUI GetText()
        {
            return text;
        }

        public bool IsActive()
        {
            return characterIndex < textToWrite.Length;
        }

        
        public void writeAndDestroy()
        {
            text.text = textToWrite;
            characterIndex = textToWrite.Length;
            Textwriter.RemoveWriter_Static(text);
        }
    }
}