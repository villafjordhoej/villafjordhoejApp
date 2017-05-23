using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Villafjordhoej.Handler;
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


        #region Load

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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                        throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                        throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                        throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        #endregion

        #region Save

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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
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
                    var test = await client.PostAsJsonAsync("api/app_m_vaerelser", o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        #endregion

        #region Edit

        public static async Task<bool> EditGaestToDB(M_Gaest o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PutAsJsonAsync("api/app_gaest/" + o.gaest_id, o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> EditBookingToDB(M_Booking o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PutAsJsonAsync("api/app_booking/" + o.booking_id, o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> EditVaerelseToDB(M_Vaerelse o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PutAsJsonAsync("api/app_vaerelse/" + o.vaerelse_id, o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> EditBehandlingToDB(M_Behandling o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PutAsJsonAsync("api/app_behandling/" + o.behandlinger_id, o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> EditMedarbejderToDB(M_Medarbejder o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PutAsJsonAsync("api/app_medarbejder/" + o.medarbejder_id, o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> EditMellemBehandlingToDB(Me_Behandling o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PutAsJsonAsync("api/app_m_behandling/" + o.m_behandling_id, o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> EditmellemVaerelseToDB(Me_Vaerelser o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.PutAsJsonAsync("api/app_m_vaerelser/" + o.m_vaerelser_id, o);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        #endregion

        #region Delete

        public static async Task<bool> DeleteGaestFromDB(M_Gaest o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.DeleteAsync("api/app_gaest/" + o.gaest_id);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> DeleteBookingFromDB(M_Booking o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.DeleteAsync("api/app_booking/" + o.booking_id);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> DeleteVaerelseFromDB(M_Vaerelse o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.DeleteAsync("api/app_vaerelse/" + o.vaerelse_id);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> DeleteBehandlingFromDB(M_Behandling o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.DeleteAsync("api/app_behandlinger/" + o.behandlinger_id);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> DeleteMedarbejderFromDB(M_Medarbejder o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.DeleteAsync("api/app_medarbejder/" + o.medarbejder_id);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> DeleteMellemBehandlingFromDB(Me_Behandling o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.DeleteAsync("api/app_m_behandling/" + o.m_behandling_id);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        }

        public static async Task<bool> DeleteMellemVaerelseFromDB(Me_Vaerelser o)
        {
            string jsonDBString = JsonConvert.SerializeObject(o);


            using (var client = new HttpClient(Handler, false))
            {
                client.BaseAddress = new Uri(SERVER_URL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    var test = await client.DeleteAsync("api/app_m_vaerelse/" + o.m_vaerelser_id);
                    return test.IsSuccessStatusCode;
                }
                catch (Exception)
                {
                    throw new DatabaseException("Der opstod fejl på netværket \n \nTjæk at du har netværk.\nKontakt evt. Administrator.");
                }
            }
        } 

        #endregion

    }
}
