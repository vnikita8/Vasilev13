using System;
using System.Windows.Forms;
using CustomBank;
using CustomBuild;

namespace Vasilev13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int NewAccointNumber = BankAccountCreator.CreateAccount(AccountType.текущий, 2000); //Dll кастомБанк
            Build build = BuildCreator.CreateBuld(); //Dll кастомБуилд
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /* Получаеца код */
        }
    }
}
