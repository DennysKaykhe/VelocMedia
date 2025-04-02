double distancia;
double tempo;
double media;

Console.Clear();

Console.Write("Distância percorrida (m): ");
distancia = Convert.ToDouble(Console.ReadLine());

Console.Write("Tempo gasto (s).........: ");
tempo = Convert.ToDouble(Console.ReadLine());

media = distancia / tempo;

Console.WriteLine(@$"
Velocidade média: {media} m/s");