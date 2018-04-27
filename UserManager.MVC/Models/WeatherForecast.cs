namespace UserManager.MVC.Models
{
    public class WeatherForecast
    {
        public string DateFormatted { get; set; }
        public int TemperatureC { get; set; }
        public string Summary
        {
            get
            {
                if (TemperatureC < 0)
                    return "Freezing";
                else if (TemperatureC > 0 && TemperatureC < 10)
                    return "Cool";

                return "Warm";
            }
        }

        public int TemperatureF
        {
            get
            {
                return 32 + (int)(this.TemperatureC / 0.5556);
            }
        }
    }
}
