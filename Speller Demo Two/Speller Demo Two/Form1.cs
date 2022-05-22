using System;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Xml;
/*

https://www.c-sharpcorner.com/UploadFile/1e050f/text-to-speech-converter-in-C-Sharp/
100 Most Commonly Misspelled Words
https://grammar.yourdictionary.com/spelling-and-word-lists/misspelled.html


*/

namespace Speller_Demo_Two
{
    public partial class Form1 : Form
    {
        
        
        
        public Form1()
        {
            InitializeComponent();
        }
        //SpeechSynthesizer Class Provides access to the functionality of an installed a speech synthesis engine.   
        SpeechSynthesizer speechSynthesizerObj;
        private void btn_Play_Click(object sender, EventArgs e)
        {
            
            
            
            string Say = " is spelled ";
            string Ask = " Can you spell ";
            string MyWord = txtMyWord.Text;
                // "acceptable";
            string MySpellWord = " ";

            

            for (int i = 0; i < MyWord.Length; i++)
            {
                MySpellWord += MyWord.ToArray()[i].ToString() + ", ";
            }


            string SayThis = MyWord + Say + MySpellWord + " " + txtAddedWords.Text+ " " + Ask + MyWord + "?";
            lblWord.Text = MyWord;
            lblSaying.Text = SayThis;  
            speechSynthesizerObj = new SpeechSynthesizer();
            speechSynthesizerObj.SpeakAsync(SayThis);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();



        }


        private void btmXML_Click(object sender, EventArgs e)
        {

        }
    }
}