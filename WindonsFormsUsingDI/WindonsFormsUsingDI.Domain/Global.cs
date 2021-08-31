using System;
using System.Collections.Generic;
using System.Text;

namespace WindonsFormsUsingDI.Domain
{
    public static class Global
    {
        private static int _IDdoDonoFromfrmCadastroDono;
        public static int IDdoDonoFromfrmCadastroDono  // read-write instance property
        {
            get => _IDdoDonoFromfrmCadastroDono;
            set => _IDdoDonoFromfrmCadastroDono = value;
        }

        private static string _NomeDoDonoFromfrmCadastroDono;
        public static string NomeDoDonoFromfrmCadastroDono  // read-write instance property
        {
            get => _NomeDoDonoFromfrmCadastroDono;
            set => _NomeDoDonoFromfrmCadastroDono = value;
        }
    }
}
