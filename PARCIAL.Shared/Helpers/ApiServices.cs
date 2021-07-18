using Newtonsoft.Json;
using PARCIAL.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace PARCIAL.Helpers
{
    public class ApiServices
    {
        public static async Task<Response> RecoverAsync(LoginRequest model)
        {
            try
            {


                string request = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                HttpClientHandler handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };


                HttpClient client = new HttpClient()
                {
                    BaseAddress = new Uri("https://fpd2021uno.azurewebsites.net")
                };

                HttpResponseMessage response = await client.PostAsync("api/Account/RecoverPassword", content);
                string result = await response.Content.ReadAsStringAsync();

                return new Response
                {
                    IsSuccess = response.IsSuccessStatusCode,
                    Message = result,
                };


            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }


        public static async Task<Response> LoginAsync(LoginRequest model)
        {

            try
            {
                string request = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                HttpClientHandler handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };


                HttpClient client = new HttpClient()
                {
                    BaseAddress = new Uri("https://fpd2021uno.azurewebsites.net")
                };

                HttpResponseMessage response = await client.PostAsync("api/Account/CreateToken", content);
                string result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                ResponseLogin responseLogin = JsonConvert.DeserializeObject<ResponseLogin>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = responseLogin,
                };

            }

            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }


        }


        public static async Task<Response> QuestionAsync(string token)
        {
            try { 

            string request = JsonConvert.SerializeObject(token);
            StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };


            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://fpd2021uno.azurewebsites.net")
            };

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);
            HttpResponseMessage response = await client.GetAsync("api/Questions");
            string result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };

                }

                Question responseQuestion = JsonConvert.DeserializeObject<Question>(result);

                return new Response
            {
                IsSuccess = true,
                Result = responseQuestion,
            };


        }
              catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }



        }


        public static async Task<Response> SendVoteAsync(string token,Vote model)
        {
            string request = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };


            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://fpd2021uno.azurewebsites.net")
            };


            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);
            HttpResponseMessage response = await client.PostAsync("api/Questions", content);
            string result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = result,
                };

            }


            return new Response
            {
                IsSuccess = true,
            };
        }


        public static async Task<Response> CancelAsync(string token)
        {
            try
            {
                HttpClientHandler handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };

       
                HttpClient client = new HttpClient(handler)
                {
                    BaseAddress = new Uri("https://fpd2021uno.azurewebsites.net")
                };

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);
                HttpResponseMessage response = await client.DeleteAsync("api/Answers");
                string result = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                return new Response
                {
                    IsSuccess = true,
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }


    }
}