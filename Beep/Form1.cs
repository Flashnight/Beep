using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Beep
{
    public partial class Form1 : Form
    {
        private enum NotesFrequences : int
        {
            Do = 262,
            Re = 294,
            Mi = 330,
            Fa = 349,
            Sol = 392,
            La = 440,
            Si = 494
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            var ev = e as MouseEventArgs;

            Sound.StartSound((int)NotesFrequences.Do);
        }

        private void reButton_Click(object sender, EventArgs e)
        {
            Sound.StartSound((int)NotesFrequences.Re);
        }

        private void miButton_Click(object sender, EventArgs e)
        {
            Sound.StartSound((int)NotesFrequences.Mi);
        }

        private void faButton_Click(object sender, EventArgs e)
        {
            Sound.StartSound((int)NotesFrequences.Fa);
        }

        private void solButton_Click(object sender, EventArgs e)
        {
            Sound.StartSound((int)NotesFrequences.Sol);
        }

        private void laButton_Click(object sender, EventArgs e)
        {
            Sound.StartSound((int)NotesFrequences.La);
        }

        private void si_button_Click(object sender, EventArgs e)
        {
            Sound.StartSound((int)NotesFrequences.Si);
        }

        private void button_Up(object sender, EventArgs e)
        {
            try
            {
                var keyEvent = e as KeyEventArgs;
                var keysConverter = new KeysConverter();
                var key = keysConverter.ConvertToString(keyEvent.KeyData);

                if (key != "1" || key != "2" || key != "3" || key != "4" || key != "5" || key != "6" || key != "7")
                {
                    Sound.StopSound();
                }
            }
            catch (Exception)
            {
                Sound.StopSound();
            }
        }

        private void pressKey(object sender, EventArgs e)
        {
            var keyboardEvent = e as KeyEventArgs;
            var key = keyboardEvent.KeyData;

            switch (key)
            {
                case (Keys.D1):
                    Sound.StartSound((int)NotesFrequences.Do);
                    break;
                case (Keys.D2):
                    Sound.StartSound((int)NotesFrequences.Re);
                    break;
                case (Keys.D3):
                    Sound.StartSound((int)NotesFrequences.Mi);
                    break;
                case (Keys.D4):
                    Sound.StartSound((int)NotesFrequences.Fa);
                    break;
                case (Keys.D5):
                    Sound.StartSound((int)NotesFrequences.Sol);
                    break;
                case (Keys.D6):
                    Sound.StartSound((int)NotesFrequences.La);
                    break;
                case (Keys.D7):
                    Sound.StartSound((int)NotesFrequences.Si);
                    break;
            }
        }
    }
}
