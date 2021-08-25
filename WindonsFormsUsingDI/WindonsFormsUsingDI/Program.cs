using System;
using WindonsFormsUsingDI.Application;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindonsFormsUsingDI.Application.Helpers;

namespace WindonsFormsUsingDI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            //https://pt.stackoverflow.com/questions/184157/d%C3%BAvida-sobre-como-implementar-uma-inje%C3%A7%C3%A3o-de-depend%C3%AAncia-no-c-utilizando-o-ninj
            //solução para injetar a dependencia no form1 (frmCadastroDono)
            FormResolve.Wire(FormModule.Create());
            System.Windows.Forms.Application.Run(FormResolve.Resolve<frmCadastroDono>());
        }
    }
}
