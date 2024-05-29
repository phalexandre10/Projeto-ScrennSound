namespace ScreenSound.Modelos;

internal class Avaliacao
{
    //Criei a classe avaliação para encapslular o conceito nota
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    //Usando método estático
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
