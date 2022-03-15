namespace fgv.ordenacao.dominio.Util
{
    public class ParametroOrdenacao
    {
        public enum ParametrosOrdenacao
        {
            Autor,
            Titulo,
            Edicao,
            AutorTitulo,
            EdicaoAutorTitulo,
        }
        public enum MetodoOrdenacao
        {
            Ascendente,
            Descendente,
            AscendenteDescendente,
            DescendenteAscendente
        }
    }
}
