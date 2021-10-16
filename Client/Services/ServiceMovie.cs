using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ProySprintIII.Shared.Entity;

namespace ProySprintIII.Client.Services
{
    public class ServiceMovie: IServiceMovie
    {
        private readonly HttpClient httpClient;

        public ServiceMovie(HttpClient httpClient){
            this.httpClient = httpClient;
        }

        public async Task<HttpResponseWrapper<object>> Post<T> (string url, T send){
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode,responseHttp);
        }
         public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8,
            "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null,
            !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null,
            !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }

        // public async Task<HttpResponseWrapper<object>> Get<T>(string url)
        // {
        //     var responseHTTP = await httpClient.GetAsync(url);
        //     return new HttpResponseWrapper<object>(null,
        //     !responseHTTP.IsSuccessStatusCode, responseHTTP);
        // }

        public List<Movie>GetMovies(){
            return new List<Movie>(){
                new Movie(){ MovieName="Jujutsu Kaisen 0", EnCartelera=true, Poster="/images/pelicula1.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Shang-Chi", EnCartelera=true, Poster="/images/pelicula2.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Black Widow", EnCartelera=true, Poster="/images/pelicula3.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Spiderman", EnCartelera=true, Poster="/images/pelicula4.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Avengers Endgame", EnCartelera=true, Poster="/images/pelicula5.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Buscando a Nemo", EnCartelera=true, Poster="/images/pelicula6.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Encantada", EnCartelera=true, Poster="/images/pelicula7.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Mulan", EnCartelera=true, Poster="/images/pelicula8.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Parasite", EnCartelera=true, Poster="/images/pelicula9.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Dragon Ball", EnCartelera=true, Poster="/images/pelicula10.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)},
                new Movie(){ MovieName="Demon Slayer", EnCartelera=true, Poster="/images/pelicula11.jpg", Trailer="Trailer", Sinopsis="Sinopsis", Score=10, Premier=new DateTime(2021,09,24)}
            };
        }
    }
}