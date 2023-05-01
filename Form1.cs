using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace TTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer reader = new SpeechSynthesizer();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync("Yes");
                reader.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Please Write Some Text!!");
            }
        }
        public void KeyOnOff()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync("Caps Lock is On");
            }
            else
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync("Caps Lock is Off");
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.CapsLock)
            {
                KeyOnOff();
            }
        }
    }
}
