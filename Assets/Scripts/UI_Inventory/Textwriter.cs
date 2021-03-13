using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

namespace AlienColour.Assets.Scripts.UI_Inventory
{
    public class Textwriter : MonoBehaviour
    {
        private static Textwriter instance;

        private List<TextWriterSingle> textWriterSingleList;

        private Color originalColor = Color.white;
        private Color textColor =Color.white;

        public void Awake()
        {
            instance = this;
            textWriterSingleList = new List<TextWriterSingle>();
        }

        public static TextWriterSingle AddWriter_Static(TextMeshProUGUI text, string textToWrite, float timePerCharacter, bool invisibleCharacters, bool removeWriter)
        {
            if (removeWriter)
            {
                instance.RemoveWriter(text);
            }
            return instance.AddWriter(text, textToWrite, timePerCharacter, invisibleCharacters, removeWriter);
        }

        private TextWriterSingle AddWriter(TextMeshProUGUI text, string textToWrite, float timePerCharacter, bool invisibleCharacters, bool removeWriter)
        {
            TextWriterSingle textWriterSingle = new TextWriterSingle(text, textToWrite, timePerCharacter, invisibleCharacters, removeWriter);
            
            textWriterSingleList.Add(textWriterSingle);
            return textWriterSingle;
        }

        public static void RemoveWriter_Static(TextMeshProUGUI text)
        {
            instance.RemoveWriter(text);
        }

        private void RemoveWriter(TextMeshProUGUI text)
        {
            for (int i = 0; i < textWriterSingleList.Count; i++)
            {
                if (textWriterSingleList[i].GetText() == text)
                {
                    textWriterSingleList.RemoveAt(i);
                    i--;
                }
            }
        }

        private void Update()
        {
            for( int i= 0; i<textWriterSingleList.Count; i++)
            {
               
               //textWriterSingleList[i].GetText().enabled = true;
               textWriterSingleList[i].GetText().color = textColor;
               bool destroyInstance =  textWriterSingleList[i].WriteText();
                if (destroyInstance)
                {
                    TextWriterSingle tws = textWriterSingleList[i];
                    FadeOut(tws);
                    originalColor = Color.white;                   
                    Debug.Log("Jetzt bin ich weg");
                    textWriterSingleList.Remove(tws);                     
                    i--;
                }
                
            }
           
                
        }

        public void FadeOut(TextWriterSingle tws)
        {
            StartCoroutine(FadeOutRoutine(tws));
        }

        private IEnumerator FadeOutRoutine(TextWriterSingle tws)
        {
            TextMeshProUGUI text = tws.GetText();
            Debug.Log("Ich verschwinde");
            for (float t = 0.01f; t < 3f; t += Time.deltaTime)
            {
                text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / 3f));
                Debug.Log("verschwinde....");
                yield return null;
            }
            text.enabled = false;
        }

        
    }

}
