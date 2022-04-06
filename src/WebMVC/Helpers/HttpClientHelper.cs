using System.Net;

namespace WebMVC.Helpers;

public static class HttpClientHelper
{
    public static  bool IsResponse(string? url)
    {
        try
        {
            using var client = new HttpClient();
            var response =  client.GetAsync(url).Result;
            return true;
        }
        catch
        {
            return false;
        }
    }
}