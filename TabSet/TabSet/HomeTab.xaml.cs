using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TabSet.DataModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabSet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeTab : ContentPage
	{
		public HomeTab ()
		{
			InitializeComponent ();
            

            try
            {

                // This is an asyncronous task to fetch the results of a REST API call.
                Task<string> task = HandleFileAsync();

                task.Wait();
                string json = task.Result;

                List<DataPosts> myposts = DataPosts.FromJson(json);

                /* DEBUG: print out the results
                
                Console.WriteLine("my posts: ");
                foreach (var post in myposts)
                {
                    Console.WriteLine("userId: {0} title: {1}", post.UserId, post.Title);
                }

                */

            }
            catch (Exception ex)
            {
                Console.WriteLine("error in " + this.GetType().Name + ": " + ex.Message);
            }

        }

        private async Task<string> HandleFileAsync()
            {

            WebServiceDataFeed df = new WebServiceDataFeed();

            return df.GetSampleData();

        }



	}
}