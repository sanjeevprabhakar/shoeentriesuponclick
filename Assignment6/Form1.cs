using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {

        int i = 0;
        HockeyPlayer[] hockeyPlayers;
        public Form1()
        {
            InitializeComponent();
            int[] arr = new int[10];
             hockeyPlayers = new HockeyPlayer[30];
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HockeyPlayer Player1 = new HockeyPlayer(playerNameBox.Text, Convert.ToInt32(jerseyNumberBox.Text), Convert.ToInt32(numberofgoalsbox.Text));
            
            

            
            
                hockeyPlayers[i] = new HockeyPlayer(playerNameBox.Text, Convert.ToInt32(jerseyNumberBox.Text), Convert.ToInt32(numberofgoalsbox.Text));
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answerBox.Text = "Player name" + "  " + "Jersey no" + "  " + "No of goals"+ "\n";
            for(int j = 0; j < i; j++)
            { 
                answerBox.Text= answerBox.Text+hockeyPlayers[j].getPlayerName()+"             "+ hockeyPlayers[j].getJerseyNumber()+ "             " + hockeyPlayers[j].getnoofgoals()+"\n";
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class HockeyPlayer {

        String PlayerName;
        int JerseyNumber;
        int noofgoals;

        public HockeyPlayer(string pName, int jNumber, int goals)
        {
            PlayerName = pName;
            JerseyNumber = jNumber;
            noofgoals = goals;


        }

        public string getPlayerName()
        {
            return PlayerName;
        }

        public int getJerseyNumber()
        {
            return JerseyNumber;
        }

      public int getnoofgoals()
        {
            return noofgoals;
        }

         
        void setnooggoals(int x)
        {
            noofgoals = x;
        }

       





    }

    






}
