using System;

namespace fgv.ordenacao.dominio.Util
{
    public class OrdenacaoException : Exception
    {
        public OrdenacaoException()
        {
        }

        public OrdenacaoException(string message)
            : base(message)
        {
        }

        public OrdenacaoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
