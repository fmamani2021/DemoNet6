namespace WebApp
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public int TemperatureF2 { 
            get {
                return 32 + (int)(TemperatureC / 0.5556);
            } 
        }

        public string? Summary { get; set; }


        public int GetValue(int dato) {
            return dato + 1;
        }

        public int GetValue2(int dato) => dato + 1;

    }
}