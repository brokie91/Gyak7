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

namespace Gyak7_4
{
    public partial class Form1 : Form
    {
        List<Felhasznalo> users = new List<Felhasznalo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Beolvasas(string filenev, List<Felhasznalo> lista)
        {
            StreamReader be = new StreamReader(filenev);
            while (!be.EndOfStream)
            {
                String[] splitArray = be.ReadLine().Split(';');
                if (splitArray[4].Equals("nem"))
                {
                    lista.Add(new Felhasznalo(splitArray[0], splitArray[1], splitArray[2], splitArray[3], false));
                }
                else if(splitArray[4].Equals("igen"))
                {
                    lista.Add(new Felhasznalo(splitArray[0], splitArray[1], splitArray[2], splitArray[3], true));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Beolvasas("felhasznalok.txt",users);

            this.Text = "Bejelentkezés";
            lbUserId.Text = "Felhasználó név:";
            lbPassword.Text = "Jelszó:";

            txtPassword.PasswordChar = '\u2022';

            btnLogin.Text = "Belép";
            btnCancel.Text = "Mégse";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool talalt = false;
            //Ellenőrzés, hogy van-e ilyen felhasználó
            foreach(Felhasznalo item in users)
            {
                if (txtUserId.Text.Equals(item.UserID))
                {
                    talalt = true;
                }
            }

            if (talalt) 
            {
                Felhasznalo kliens = users.Find(x => x.UserID.Equals(txtUserId.Text));
                if (kliens.Probalkozik(kliens.UserID, txtPassword.Text) && !kliens.isBlocked)
                {
                    MessageBox.Show(String.Format("{0} {1} sikeresen bejelentkezett", kliens.VezetekNev, kliens.KeresztNev), "Sikeres belépés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (kliens.isAdmin)
                    {
                        foreach (Felhasznalo user in users)
                        {
                            user.Felszabadit();
                        }
                        MessageBox.Show("Mindenki felszabadítva!","Felszabadítás",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    kliens.UjProba();
                    formReset();
                }
                else
                {
                    //MessageBox.Show("A felhasználó blokkolt.", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (kliens.isBlocked)
                    {
                        MessageBox.Show("A felhasználó blokkolt.", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtPassword.Text != kliens.Password)
                    {
                        MessageBox.Show("Hibás jelszó.", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    formReset();
                }
            }
            else //Ha nem létezik a felhasználónév, akkor kiírom a hibaüzenetet
            {
                MessageBox.Show("Hibás felhasználó név.", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                formReset();
            }
        }

        private void formReset()
        {
            txtUserId.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtUserId.Focus();
        }
    }
}
