using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace UniMindProject
{
    public partial class insights : Form
    {
        public insights()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Your API key from OpenAI
            string apiKey = "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";

            // The prompt text from the rich text box control
            string prompt = richTextBox1.Text;

            // The API endpoint URL
            string apiUrl = "https://api.openai.com/v1/engines/davinci/completions";

            // The request payload in JSON format
            string jsonPayload = @"{
        ""model"": ""davinci"",
        ""prompt"": """ + prompt + @""",
        ""temperature"": 0.5,
        ""max_tokens"": 200
    }";

            // Create a new HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Set the authorization header with your API key
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                // Set the content type to JSON
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Create the request content with the JSON payload
                StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // Send the HTTP POST request to the API endpoint
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Read the response content
                string responseContent = await response.Content.ReadAsStringAsync();

                // Display the response content in the result label control
                label2.Text = responseContent;


            }
        }
    }
}
