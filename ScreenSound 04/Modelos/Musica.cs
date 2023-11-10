using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    public class Musica
    {
        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName("Key")]
        public int Key { get; set; }
        public string Tonalidade {
            get
            {
                return tonalidades[Key];
            }
        }
        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Musica: {Nome}");
            Console.WriteLine($"Duração em segundos: {Duracao/1000}");
            Console.WriteLine($"Gênero musical: {Genero}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");

        }

    }
}
