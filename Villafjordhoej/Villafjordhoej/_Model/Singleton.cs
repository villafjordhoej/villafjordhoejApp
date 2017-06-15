using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Villafjordhoej.Annotations;
using Villafjordhoej.Persistency;

namespace Villafjordhoej._Model
{
    class Singleton
    {
        private static Singleton _instance;

        public ObservableCollection<M_Booking> Bookings { get; set; }
        public ObservableCollection<M_Vaerelse> Vaerelser { get; set; }
        public ObservableCollection<M_Behandling> Behandlings { get; set; }
        public ObservableCollection<M_Gaest> Gaests { get; set; }
        public ObservableCollection<M_Medarbejder> Medarbejders { get; set; }

        public ObservableCollection<Me_Behandling> Mellem_Behandlings { get; set; }
        public ObservableCollection<Me_Vaerelser> Mellem_Vaerelsers { get; set; }




        public int BookingsCurrentID { get; set; }
        public int VaerelserCurrentID { get; set; }
        public int BehandlingCurrentID { get; set; }
        public int GaestsCurrentID { get; set; }
        public int MedarbejderCurrentID { get; set; }
        public int Mellem_BeCurrentID { get; set; }
        public int Mellem_VaCurrentID { get; set; }




        public bool Succes { get; set; }

		public int Index { get; set; }


		public int LogInMedarbejderId { get; set; }

        public Singleton()
        {
            LogInMedarbejderId = 1;
        }


        #region Load

        //Henter den mellemligende tabel app_m_behandling
        public async void LoadMeBehandlings()
        {
            if (Mellem_Behandlings == null)
            {
                Mellem_Behandlings = new ObservableCollection<Me_Behandling>(await DB_Persistency.LoadMellemBehandlingsFromDB());
                if (Mellem_Behandlings.Count != 0)
                {
                    Mellem_BeCurrentID = Mellem_Behandlings.Last().m_behandling_id;
                }
                else
                {
                    Mellem_BeCurrentID = 0;
                }
            }
        }

        //Henter den mellemligende tabel app_m_vaerelser
        public async void LoadMeVaerelsers()
        {
            if (Mellem_Vaerelsers == null)
            {
                
                Mellem_Vaerelsers = new ObservableCollection<Me_Vaerelser>(await DB_Persistency.LoadMellemVaerelserFromDB());
                if (Mellem_Vaerelsers.Count != 0)
                {
                    Mellem_VaCurrentID = Mellem_Vaerelsers.Last().m_vaerelser_id;
                }
                else
                {
                    Mellem_VaCurrentID = 0;
                }
            }
        }
        
        //Henter medarbejdere fra DB
        public async void LoadMedarbejders()
        {
            if (Medarbejders == null)
            {
                
                Medarbejders = new ObservableCollection<M_Medarbejder>(await DB_Persistency.LoadMedarbejdersFromDB());
                if (Medarbejders.Count != 0)
                {
                    MedarbejderCurrentID = Medarbejders.Last().medarbejder_id;
                }
                else
                {
                    MedarbejderCurrentID = 0;
                }
            }
        }
        
        //Henter Behandlinger fra DB
        public async void LoadBehandlings()
        {
            if (Behandlings == null)
            {

                Behandlings = new ObservableCollection<M_Behandling>(await DB_Persistency.LoadBehandlingsFromDB());
                if (Behandlings.Count != 0)
                {
                    BehandlingCurrentID = Behandlings.Last().behandlinger_id;
                }
                else
                {
                    BehandlingCurrentID = 0;
                }
            }
        }

        //Henter Bookings fra DBs
        public async void LoadBookings()
        {
            if (Bookings == null)
            {
                Bookings = new ObservableCollection<M_Booking>(await DB_Persistency.LoadBookingsFromDB());
                if (Bookings.Count != 0)
                {
                    BookingsCurrentID = Bookings.Last().booking_id;
                }
                else
                {
                    BookingsCurrentID = 0;
                }
            }

        }
        
        //Henter Rooms fra DB
        public async void LoadVaerelser()
        {
            if (Vaerelser == null)
            {

                Vaerelser = new ObservableCollection<M_Vaerelse>(await DB_Persistency.LoadVaerelserFromDB());
                if (Vaerelser.Count != 0)
                {
                    VaerelserCurrentID = Vaerelser.Last().vaerelse_id;
                }
                else
                {
                    VaerelserCurrentID = 0;
                }
            }
        }

        //Henter Gæster fra DB
        public async void LoadGaests()
        {
            if (Gaests == null)
            {
                Gaests = new ObservableCollection<M_Gaest>(await DB_Persistency.LoadGaestsFromDB());
                if (Gaests.Count != 0)
                {
                    GaestsCurrentID = Gaests.Last().gaest_id;
                }
                else
                {
                    GaestsCurrentID = 0;
                }
            }
        }

        #endregion


        #region Save

        //Gemmer den mellemligende tabel app_m_behandling i DB og i Collectionen
        public async void SaveMeBehandlings(Me_Behandling o)
        {
            o.m_behandling_id = ++Mellem_BeCurrentID;
            Mellem_Behandlings.Add(o);
            Succes = await DB_Persistency.SaveMellemBehandlingToDB(o);

        }

        //Gemmer den mellemligende tabel app_m_vaerelser i DB og i Collectionen
        public async void SaveMeVaerelsers(Me_Vaerelser o)
        {
            o.m_vaerelser_id = ++Mellem_VaCurrentID;
            Mellem_Vaerelsers.Add(o);
            Succes = await DB_Persistency.SaveMellemVaerelseToDB(o);

        }

        //Gemmer medarbejdere i DB og i Collectionen
        public async void SaveMedarbejders(M_Medarbejder o)
        {
            o.medarbejder_id = ++MedarbejderCurrentID;
            Medarbejders.Add(o);
            Succes = await DB_Persistency.SaveMedarbejderToDB(o);

        }

        //Gemmer Behandlinger i DB og i Collectionen
        public async void SaveBehandlings(M_Behandling o)
        {
            o.behandlinger_id = ++BehandlingCurrentID;
            Behandlings.Add(o);
            Succes = await DB_Persistency.SaveBehandlingToDB(o);

        }

        //Gemmer Bookings i DB og i Collectionen
        public async void SaveBookings(M_Booking o)
        {
            o.booking_id = ++BookingsCurrentID;
            Bookings.Add(o);
            Succes = await DB_Persistency.SaveBookingToDB(o);

        }

        //Gememer Rooms i DB og i Collectionen
        public async void SaveVaerelsers(M_Vaerelse o)
        {
            o.vaerelse_id = ++VaerelserCurrentID;
            Vaerelser.Add(o);
            Succes = await DB_Persistency.SaveVaerelseToDB(o);

        }

        //Gemmer Gæster i DB og i Collectionen
        public async void SaveGaests(M_Gaest o)
        {
            o.gaest_id = ++GaestsCurrentID;
            Gaests.Add(o);
            Succes = await DB_Persistency.SaveGaestToDB(o);

        }

        #endregion

        public void DeleteBooking(M_Booking B)
        {
            Bookings.Remove(B);
            DB_Persistency.DeleteBookingFromDB(B);

        }

        public void DeleteMeVearelser(Me_Vaerelser V)
        {
            Mellem_Vaerelsers.Remove(V);
            DB_Persistency.DeleteMellemVaerelseFromDB(V);
        }




        public static Singleton GetInstance
        {
            get
            {
                return _instance ?? (_instance = new Singleton());
            }
        }

    }
}
