using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Game
{
    public partial class btn_welcome : Form
    {
        InstructionForm ins_obj = new InstructionForm();
        SimpleGame game_obj = new SimpleGame();

        public btn_welcome()
        {
            InitializeComponent();
        }

        private void Btn_display_Click(object sender, EventArgs e)
        {
            object p = ins_obj.Show();
        }

        private void Btn_Startgame_Click(object sender, EventArgs e)
        {
            this.Hide();
            ins_obj.Close();
            game_obj.ShowDialog();
                
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
