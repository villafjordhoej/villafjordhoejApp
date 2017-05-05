using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

        public static async Task<IEnumerable<M_Vaerelse>> LoadVaerelserFromDB()
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
                        IEnumerable<M_Vaerelse> events = response.Content.ReadAsAsync<IEnumerable<M_Vaerelse>>().Result;
                        
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


        public static async Task<bool> SaveGaestToDB(M_Gaest o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PostAsJsonAsync("api/app_gaest", o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static async Task<bool> SaveBookingToDB(M_Booking o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PostAsJsonAsync("api/app_booking", o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static async Task<bool> SaveVaerelseToDB(M_Vaerelse o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PostAsJsonAsync("api/app_vaerelse", o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static async Task<bool> SaveBehandlingToDB(M_Behandling o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PostAsJsonAsync("api/app_behandling", o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static async Task<bool> SaveMedarbejderToDB(M_Medarbejder o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PostAsJsonAsync("api/app_medarbejder", o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static async Task<bool> SaveMellemBehandlingToDB(Me_Behandling o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PostAsJsonAsync("api/app_m_behandling", o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static async Task<bool> SaveMellemVaerelseToDB(Me_Vaerelser o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PostAsJsonAsync("api/app_m_vaerelse", o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }



    }
}
