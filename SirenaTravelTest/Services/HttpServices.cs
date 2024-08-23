namespace SirenaTravelTest.Services
{
    public class HttpServices
    {
        HttpClient httpClient = null!;

        public HttpServices()
        {


            httpClient = new HttpClient();
        }
        public async Task<Airport> GetAirportAsync(string cityIata, CancellationToken ct = default)
        {

            try
            {

                var uri = new Uri($"https://places-dev.cteleport.com/airports/{cityIata}");
                var airport = await httpClient.GetFromJsonAsync<Airport>(uri, ct);
                return airport ?? new Airport();


            }
            catch (Exception e)
            {

                throw;
            }


        }


        ////public async Task SendMessageToBot(MessageForSend sendMessage, CancellationToken ct = default)
        ////{
        ////    RestResponse response = new();

        ////    var json = JsonSerializer.Serialize(sendMessage);
        ////    var options = new RestClientOptions("https://95.216.29.24:443")
        ////    {
        ////        RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
        ////    };
        ////    var client = new RestClient(options);
        ////    var request = new RestRequest("https://api.telegram.org/bot6735323380:AAHKHtMIrJRCAI2ycWz_vifYTw139Alcim0/sendMessage");
        ////    request.Method = Method.Post;
        ////    request.AddHeader("Accept", "*/*");
        ////    request.AddHeader("Content-Type", "application/json");

        ////    request.AddJsonBody(json);
        ////    try
        ////    {

        ////        response = await client.ExecuteAsync(request);

        ////    }
        ////    catch (Exception e)
        ////    {
        ////        throw;
        ////    }

        ////}
    }
}
