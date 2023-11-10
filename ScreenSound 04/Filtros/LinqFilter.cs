using ScreenSound_04.Modelos; 

namespace ScreenSound_04.Filtros
{
    public class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach( var generos in todosOsGenerosMusicais)
            {
                Console.WriteLine($" - {generos}");
            }
        }
        public static void FiltratArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo os artistas por gênero musical : {genero}");
            foreach( var artist in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artist}");
            }

        }
        public static void FiltratMusicasPorArtistasMusical(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
            Console.WriteLine($"Exibindo os musicas por nome artista : {nomeDoArtista}");
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }

        }
        public static void FiltrarMusicasEmCSharp(List<Musica> musicas)
        {
            var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C")).Select(musica => musica.Nome).ToList();
            Console.WriteLine("Músicas em C#:");
            foreach (var musica in musicasEmCSharp)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}
