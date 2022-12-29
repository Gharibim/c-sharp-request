using System;
using System.Threading.Tasks;
using Amazon.Lambda.CloudWatchEvents;
using RestSharp;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloWorld
{

    public class Function
    {
        // private readonly RestClient _client;
        // private readonly RestRequest _request;

        // public Function()
        // {
        //     string url = "http://127.0.0.1:3000/drops/collection/{platform}/{address}/init";
        //     _client = new RestClient(url);
        //     _request = new RestRequest();
        // }
        public async Task FunctionHandler(CloudWatchEvent<Erc721Imported> input, ILambdaContext context)
        {
            Console.WriteLine($"The address is {input.Detail.Address}");

            // Start the request
            // string url = "http://127.0.0.1:3000/drops/collection/{platform}/{address}/init";
            // var _client = new RestClient(url);
            // var _request = new RestRequest();
            // _request.AddUrlSegment("platform", "ethereum");
            // _request.AddUrlSegment("address", input.Detail.Address);
            // var response = await _client.GetAsync(_request);
            // Console.WriteLine(response.Content.ToString());
            
            string url = "https://jsonplaceholder.typicode.com/todos/{something}";
            var _client = new RestClient(url);
            var _request = new RestRequest();
            _request.AddUrlSegment("something", "2");
            var response = await _client.GetAsync(_request);
            Console.WriteLine(response.Content.ToString());
        }
    }
    public class Erc721Imported
    {
        public string Abi { get; set; }
        public string Address { get; set; }
    }
}
