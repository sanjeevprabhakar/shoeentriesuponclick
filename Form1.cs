using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Assignment6
{
    public partial class Form1 : Form
    {

        
        
        List< HockeyPlayer> hockeyPlayers = new List <HockeyPlayer>();

        public Form1()
        {
            
            InitializeComponent();
            listBox1.Items.Add("Player name" + "  " + "Jersey no" + "  " + "No of goals" + "\n");
           
           
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HockeyPlayer Player = new HockeyPlayer(playerNameBox.Text, Convert.ToInt32(jerseyNumberBox.Text), Convert.ToInt32(numberofgoalsbox.Text));
            
           

            

            hockeyPlayers.Add(Player);
            listBox1.Items.Add(Player.getPlayerName() + "             " + Player.getJerseyNumber() + "             " + Player.getnoofgoals() + "\n");
           
        }

        

        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HockeyPlayer.whichradiobutton = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            HockeyPlayer.whichradiobutton = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            HockeyPlayer.whichradiobutton = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hockeyPlayers.Sort();
            listBox1.Items.Clear();
            

            listBox1.Items.Add("Player name" + "  " + "Jersey no" + "  " + "No of goals" + "\n");
            if (checkBox1.Checked)
            {
                for (int i = hockeyPlayers.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Add(hockeyPlayers[i].getPlayerName() + "             " + hockeyPlayers[i].getJerseyNumber() + "             " + hockeyPlayers[i].getnoofgoals() + "\n");
                }

                
                    
            }
            else
            {
                for (int i = 0; i < hockeyPlayers.Count; i++)
                {
                    listBox1.Items.Add(hockeyPlayers[i].getPlayerName() + "             " + hockeyPlayers[i].getJerseyNumber() + "             " + hockeyPlayers[i].getnoofgoals() + "\n");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void saveItem1_Click(object sender, EventArgs e)
        {
            string FileName = "raw.txt";
            // File.WriteAllText("sanjeev.txt", listBox1.Items.ToString());
            File.WriteAllLines(FileName, listBox1.Items.Cast<string>());
            MessageBox.Show("File saved successfully with name "+ FileName);

        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           this.Close();
           
           
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string contents = File.ReadAllText("output.txt");
            listBox1.Items.Clear();
           

            string line="";

            for(int i = 0; i < contents.Length; i++)
            {
                 line += contents[i]; 
                if(contents[i] == '\n')

                {
                   // HockeyPlayer h = new HockeyPlayer(line.Split(' ')[0].ToString(), Convert.ToInt32(line.Split(' ')[1]), Convert.ToInt32(line.Split(' ')[2]));

                    //listBox1.Items.Add(h.getPlayerName() + "             " + h.getJerseyNumber() + "             " + h.getnoofgoals() + "\n");

                   listBox1.Items.Add(line);
                    
                    line = "";
                }
            }

        }



        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            int b;

           b= listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(b);
            string str;
           str =Interaction.InputBox("please enter in space seprated format","Enter new hockey player data");
            HockeyPlayer h = new HockeyPlayer(str.Split(' ')[0],Convert.ToInt32(str.Split(' ')[1]), Convert.ToInt32(str.Split(' ')[2]));
            listBox1.Items.Add(h.getPlayerName() + "             " + h.getJerseyNumber() + "             " + h.getnoofgoals() + "\n");

        }
    }

    public class HockeyPlayer : IComparable<HockeyPlayer> {

        String PlayerName;
        int JerseyNumber;
        int noofgoals;
        public static int whichradiobutton = 0;

        override
        public  string ToString()
        {
            return "abc";
        }

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

        public int CompareTo(HockeyPlayer obj)
        {
            if (whichradiobutton == 3)
            {
                return this.noofgoals.CompareTo(obj.noofgoals);
            }
            if (whichradiobutton == 1)
            {
                return this.PlayerName.CompareTo(obj.PlayerName);
            }
            if(whichradiobutton == 2)
            {
                return this.JerseyNumber.CompareTo(obj.JerseyNumber);

            }
            return -1;
        }
    }

    






}
