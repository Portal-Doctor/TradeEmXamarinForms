using RestSharp;
using System;

namespace TabSet
{
    internal class WebServiceDataFeed
    {

        internal string GetSampleData()
        {
            string json = string.Empty;

            try
            {
                // starting out with some placeholder code.
                RestClient client = new RestClient("https://jsonplaceholder.typicode.com/posts");
                RestRequest request = new RestRequest();

                /*
                string body = @"{
                                ""userid"": 1
                             }";
                */

                request.Method = Method.GET;
                //request.AddHeader("Accept", "application/json");
                request.Parameters.Clear();

                // If we are doing a post transaction, we can add items here.
                //request.AddParameter("application/json", body, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                json = response.Content; // raw content as string  
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("error in " + this.GetType().Name + ": " + ex.Message);
            }

            return json;

        }


    }
}