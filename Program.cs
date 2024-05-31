Console.Clear();

double tempoDecorrido;

Console.WriteLine("--- Raio e trovão ---");

DigitarTempo();
double distancia = Distancia();
Exibicao();

void DigitarTempo()
{
Console.Write("\nDigite o tempo decorrido entre o raio e o trovão, em segundos: ");
tempoDecorrido = Convert.ToInt32(Console.ReadLine());
}

double Distancia()
{
    double distancia = tempoDecorrido * 340.29;
    return distancia;
}

void Exibicao()
{
    Console.Write("\nSua distância em relação à queda do raio é de");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($" {distancia / 1000:N5}km");
    Console.ResetColor();
}