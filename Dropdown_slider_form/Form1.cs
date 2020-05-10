using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dropdown_slider_form
{
    public partial class Form1 : Form
    {
        List<string> listofcolors = new List<string>() {"boy", "girl", "man", "woman"};
        public Form1()
        {
            InitializeComponent();
            hidesubmenupanel();
        }
        #region Default Start Action
        void hidesubmenupanel()
        {
            firsttabpanel1.Visible = false;
            sencondtabpanel4.Visible = false;
            third_panel1.Visible = false;
        }
        #endregion

        #region Hide closed Tab method
        void showhidepanel()
        {
            if (firsttabpanel1.Visible == true)
            {
                firsttabpanel1.Visible = false;
            }
            if(sencondtabpanel4.Visible == true)
            {
                sencondtabpanel4.Visible = false;
            }
            if(third_panel1.Visible == true)
            {
                third_panel1.Visible = false;
            }
        }

        void closedopenpanel(Panel abouttoopenpanel)
        {
            if (abouttoopenpanel.Visible == false)
            {
                showhidepanel();
                abouttoopenpanel.Visible = true;
            }
            else
                abouttoopenpanel.Visible = false;
        }
        #endregion

        #region First Tab Panel
        private void first_tab_but_Click(object sender, EventArgs e)
        {
            closedopenpanel(firsttabpanel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // *******The code goes in here*********
            showhidepanel();
            callformtoopen(new Form2());
        }
        #endregion

        #region Second Tab Panel
        private void second_tab_but_Click(object sender, EventArgs e)
        {
            closedopenpanel(sencondtabpanel4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // *******The code goes in here*********
            showhidepanel();
        }
        #endregion

        #region Third Tab Panel
        private void third_panel_button10_Click(object sender, EventArgs e)
        {
            closedopenpanel(third_panel1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // *******The code goes in here*********
            showhidepanel();
            callformtoopen(new Form3());
        }
        #endregion
       
        private Form openform = null;
        void callformtoopen(Form argumentform)
        {
            if (openform != null)
                openform.Close();
            openform = argumentform;
            argumentform.TopLevel = false;
            argumentform.Dock = DockStyle.Fill;
            container_panel4.Controls.Add(argumentform);
            container_panel4.Tag = argumentform;
            argumentform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            side_bar_panel2.Visible = false;
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            if (side_bar_panel2.Visible == false)
                side_bar_panel2.Visible = true;
            else
                side_bar_panel2.Visible = false;
        }
    }
}
