using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    //add all properties of images together
    private Bitmap [] hangImages = {   };
    //assing private int to wring guesses
    private int wrongGuesses = 0;
    //private int rightGuesses = 0;
    private string current = "";
    private string copyCurrent = "";
    private string[] words;
    //private string lblword;





    protected void ButtonWord_Click (object sender, EventArgs e)
    {
        SetupWordChoice();
        Test2.Text = "";
        //Enable Alphabet buttons with the press of New Button
        foreach (Control control in Controls)
        {
            Button letter = control as Button;
            if (letter != null)
            {
                letter.Enabled = true;
            }

        }
    }


    protected void loadwords()
    {
        char[] delimiterChars = { ',' };
        string[] readText = System.IO.File.ReadAllLines(@"C:\Users\PC\Desktop\Hangman Project\words.txt");
        words = new string[readText.Length];
        int index = 0;
        foreach (string s in readText)
        {
            string[] line = s.Split(delimiterChars);
            words[index++] = line[0];
        }

    }

    protected void SetupWordChoice()
    {
        //making a guess
        wrongGuesses = 0;
        // hangImage1.Image = hangImages[wrongGuesses];
        int guessIndex = (new Random()).Next(words.Length); //generates random number for the words 
        current = words[guessIndex];

        TestWord.Text = current;

        //make a copy of a guess
        copyCurrent = "";
        for (int index = 0; index < current.Length; index++)
        {
            copyCurrent += "_";
        }
        displayCopy();

    }
    //display to the label above function
    protected void displayCopy()
    {
        WordResult.Text = "";

        for (int index = 0; index < copyCurrent.Length; index++)
        {
            WordResult.Text += copyCurrent.Substring(index, 1);
            WordResult.Text += " ";
            //return lblword.Text(words[Math.Floor(Math.random() * words.Length)]);


        }
    }

    private void updateCopy(char guess)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Button choice = sender as Button;
        choice.Enabled = false;

        if (current.Contains(choice.Text))
        {
            char[] temp = copyCurrent.ToCharArray();
            char[] find = current.ToCharArray();
            char guessChar = choice.Text.ElementAt(0);

            for (int index = 0; index < find.Length; index++)
            {
                if (find[index] == guessChar)
                {
                    temp[index] = guessChar;
                }
                copyCurrent = new string(temp);


                //change it up to find and display the found letter otherwise 

            }
            displayCopy();
        }
    


        else
        {
            wrongGuesses++;
        }


        if (wrongGuesses <= 7)
        {
           // hangImage1.Image = hangImages[wrongGuesses];
        }

        else
        {
            Test2.Text = "You Lost!";
        }
        if (copyCurrent.Equals(current))
        {
            Test2.Text = "Yay, you won!!!";
        }

        TestWord.Text = choice.Text;
    }

    //Form application
    protected void form1_Load(object sender, EventArgs e)
    {
        loadwords();
        SetupWordChoice();
    }

    //Exit button
    protected void Buttonexit_Click (object sender, EventArgs e)
    {
         //Application.Exit();
    }

}


