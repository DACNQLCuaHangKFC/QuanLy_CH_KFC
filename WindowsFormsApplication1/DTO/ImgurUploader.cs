using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class ImgurUploader
    {
        private static readonly string clientId = "20230fb4d72eddb"; // Thay bằng Client ID của bạn

        public string UploadImageToImgur(string imagePath)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Client-ID", clientId);

                using (MultipartFormDataContent content = new MultipartFormDataContent())
                {
                    content.Add(new ByteArrayContent(File.ReadAllBytes(imagePath)), "image", Path.GetFileName(imagePath));

                    HttpResponseMessage response = client.PostAsync("https://api.imgur.com/3/image", content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string resultJson = response.Content.ReadAsStringAsync().Result;
                        dynamic resultData = JsonConvert.DeserializeObject(resultJson);

                        return resultData.data.link.ToString(); // Trả về URL ảnh
                    }
                    else
                    {
                        throw new Exception("Failed to upload image. " + response.ReasonPhrase);
                    }
                }
            }
        }

    }
}
