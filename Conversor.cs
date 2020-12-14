namespace Static
{
    public static class Conversor
    {
        private static float contacaoEuro = 6.22f;
        public static float valorUsuario;

        public static float ConverterEuroParaReal(){
            return valorUsuario * contacaoEuro;
        }

        public static float ConverterRealParaEuro(){
            return valorUsuario / contacaoEuro;
        }
    }
}