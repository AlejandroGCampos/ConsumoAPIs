using System.Text.Json;
using System.Text.Json.Serialization;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Consumo_de_APIs.FormAPI;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;

namespace Consumo_de_APIs
{
    public partial class FormAPI : Form
    {
        // HttpClient separados para cada API
        private readonly HttpClient _httpClientPokemon = new HttpClient();
        private readonly HttpClient _httpClientCat = new HttpClient();

        public FormAPI()
        {
            InitializeComponent();
        }

        private void GuardarPokemonEnArchivo(PokemonResponse pokemon) //Guaradado de pokemon en archivo .txt
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pokemon.txt");

            var sb = new StringBuilder();
            sb.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {pokemon.Name.ToUpper()}");
            sb.AppendLine("Estadísticas:");
            foreach (var stat in pokemon.Stats)
            {
                sb.AppendLine($"{stat.Stat.Name}: {stat.BaseStat}");
            }
            sb.AppendLine();

            File.AppendAllText(ruta, sb.ToString());
        }


        private async void btnBuscar_Click(object sender, EventArgs e) //Botón de búsqueda 
        {
            string nombre = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingresar el nombre del Pokémon.");
                return;
            }

            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{nombre}";
                string respuesta = await _httpClientPokemon.GetStringAsync(url);

                var pokemon = JsonSerializer.Deserialize<PokemonResponse>(respuesta);

                lblNombre.Text = $"Nombre: {pokemon.Name.ToUpper()}";
                lblStats.Text = "Estadísticas:\n";

                foreach (var stat in pokemon.Stats)
                {
                    lblStats.Text += $"{stat.Stat.Name}: {stat.BaseStat}\n";
                }

                picPokemon.Load(pokemon.Sprites.FrontDefault);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Error al conectar con la API Pokémon");
            }
            catch (JsonException)
            {
                MessageBox.Show("Error al interpretar los datos del Pokémon");
            }
            catch (Exception)
            {
                MessageBox.Show("El Pokémon no fue encontrado");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty; // Limpia el cuadro de texto
            lblNombre.Text = string.Empty; // Limpia el label del nombre
            lblStats.Text = string.Empty;  // Limpia el label de estadísticas
            picPokemon.Image = null; //Limpiz lz imagen del pokémon
        }

        private async void btnGenerarGato_Click_1(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = "https://api.thecatapi.com/v1/images/search";
                var response = await _httpClientCat.GetStringAsync(apiUrl);
                var jsonArray = JArray.Parse(response);
                string imageUrl = jsonArray[0]["url"].ToString();

                // Mostrar la imagen en el PictureBox
                picGato.Load(imageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la imagen: " + ex.Message);
            }
        }

        private void FormAPI_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarGato_Click(object sender, EventArgs e)
        {
            picGato.Image = null; // Limpia la imagen del gato
        }
    }


    public class PokemonResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }

        [JsonPropertyName("stats")]
        public StatEntry[] Stats { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class StatEntry
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }

        [JsonPropertyName("stat")]
        public StatName Stat { get; set; }
    }

    public class StatName
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
