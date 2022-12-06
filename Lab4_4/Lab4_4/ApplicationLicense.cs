using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    internal class ApplicationLicense
    {
        private string key = "";
        private string keyp = "3EEDEA28ECC41F98387BB3212887D4E0B17ACFD692C0359828D2A8C6524464BA";
        private string keyt = "3EEDEA";
        private Control controlA = new Control();
        public string ControlA
        {
            get { return controlA.ToString(); }
        }
        private enum Control
        {
            Common,
            Pro,
            Trial
        }
        void AllowTrial()
        {
            Console.WriteLine("Пробний режим");
            controlA = Control.Trial;
        }
        void AllowPro()
        {
            Console.WriteLine("Платна версія");
            controlA = Control.Pro;
        }
        void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія");
        }
        public ApplicationLicense(string key)
        {
            Console.WriteLine(controlA);
            if (key == keyp)
            {
                this.key = keyp;
                AllowPro();
                Console.WriteLine(controlA);
            }
            else if (key == keyt)
            {
                this.key = keyt;
                AllowTrial();
                Console.WriteLine(controlA);
            }
            else
            {
                AllowCommon();
                Console.WriteLine(controlA);
            }
        }
    }
}