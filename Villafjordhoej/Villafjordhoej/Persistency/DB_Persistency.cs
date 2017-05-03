using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej._Model;

namespace Villafjordhoej.Persistency
{
    class DB_Persistency
    {
        const string SERVER_URL = "http://localhost:5000";
        private static HttpClientHandler Handler = new HttpClientHandler() { UseDefaultCredentials = true};

        


        public DB_Persistency()
        {
            
        }


        public static async Task<IEnumerable<M_Gaest>> LoadGaestsFromDB()
        {
            using (var client = new HttpClient(Handler, false))
            {

                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/app_gaest").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<M_Gaest> events = response.Content.ReadAsAsync<IEnumerable<M_Gaest>>().Result;

                        return events;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }



        public static async Task<IEnumerable<M_Booking>> LoadBookingsFromDB()
        {
            using (var client = new HttpClient(Handler, false))
            {

                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/app_booking").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<M_Booking> events = response.Content.ReadAsAsync<IEnumerable<M_Booking>>().Result;

                        return events;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static async Task<IEnumerable<M_Room>> LoadRoomsFromDB()
        {
            using (var client = new HttpClient(Handler, false))
            {

                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/app_vaerelse").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<M_Room> events = response.Content.ReadAsAsync<IEnumerable<M_Room>>().Result;

                        return events;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static async Task<IEnumerable<M_Behandling>> LoadBehandlingsFromDB()
        {
            using (var client = new HttpClient(Handler, false))
            {

                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/app_behandlinger").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<M_Behandling> events = response.Content.ReadAsAsync<IEnumerable<M_Behandling>>().Result;

                        return events;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static async Task<IEnumerable<M_Medarbejder>> LoadMedarbejdersFromDB()
        {
            using (var client = new HttpClient(Handler, false))
            {

                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/app_medarbejder").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<M_Medarbejder> events = response.Content.ReadAsAsync<IEnumerable<M_Medarbejder>>().Result;

                        return events;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static async Task<IEnumerable<Me_Behandling>> LoadMellemBehandlingsFromDB()
        {
            using (var client = new HttpClient(Handler, false))
            {

                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/app_m_behandling").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<Me_Behandling> events = response.Content.ReadAsAsync<IEnumerable<Me_Behandling>>().Result;

                        return events;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        public static async Task<IEnumerable<Me_Vaerelser>> LoadMellemVaerelserFromDB()
        {
            using (var client = new HttpClient(Handler, false))
            {

                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.GetAsync("api/app_m_vaerelser").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<Me_Vaerelser> events = response.Content.ReadAsAsync<IEnumerable<Me_Vaerelser>>().Result;

                        return events;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


    }
}
