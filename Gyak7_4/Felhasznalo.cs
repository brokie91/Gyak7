using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak7_4
{
    class Felhasznalo
    {
        #region Tulajdonságok
        public string UserID
        {
            get; private set;
        }

        public string Password
        {
            get; private set;
        }

        public string VezetekNev
        {
            get; private set;
        }

        public string KeresztNev
        {
            get; private set;
        }

        public bool isAdmin
        {
            get; private set;
        }

        public bool canLogIn
        {
            get; private set;
        }

        public bool isBlocked
        {
            get; private set;
        }

        public int Probalkozasok
        {
            get; private set;
        }
        #endregion

        const int PROBALKOZASOK_SZAMA = 3;
        public Felhasznalo(string felhasznalonev, string jelszo, string vezeteknev, string keresztnev, bool admine)
        {
            this.UserID = felhasznalonev;
            this.Password = jelszo;
            this.VezetekNev = vezeteknev;
            this.KeresztNev = keresztnev;
            this.canLogIn = false;
            this.isBlocked = false;
            this.isAdmin = admine;
            this.Probalkozasok = 0;
        }

        public bool Probalkozik(string id, string pw)
        {
            if (id.Equals(this.UserID) && pw.Equals(this.Password))
            {
                return true;
                this.canLogIn = true;
            }
            else
            {
                this.Probalkozasok++;
                if (this.Probalkozasok == PROBALKOZASOK_SZAMA)
                {
                    this.isBlocked = true;
                }
                return false;                
            }
        }

        public void Felszabadit()
        {
            this.isBlocked = false;
            this.Probalkozasok = 0;
        }

        public void UjProba()
        {
            this.canLogIn = false;
        }
    }
}
