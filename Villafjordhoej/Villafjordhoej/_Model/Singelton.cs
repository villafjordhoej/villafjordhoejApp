using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej._Model
{
    class Singelton
    {
        private static Singelton _instance = new Singelton();

        public ObservableCollection<M_Booking> Bookings { get; set; }
        public ObservableCollection<M_Room> Rooms { get; set; }
        public ObservableCollection<M_Behandling> Behandlings { get; set; }
        public ObservableCollection<M_Gaest> Gaests { get; set; }
        public ObservableCollection<M_Medarbejder> Medarbejders { get; set; }

        public ObservableCollection<Me_Behandling> Mellem_Behandlings { get; set; }
        public ObservableCollection<Me_Vaerelser> Mellem_Vaerelsers { get; set; }



        public Singelton()
        {
        }

        //Henter den mellemligende tabel app_m_behandling
        public async void LoadMeBehandlings()
        {
            Mellem_Behandlings = new ObservableCollection<Me_Behandling>(await Persistency.DB_Persistency.LoadMellemBehandlingsFromDB());
        }

        //Henter den mellemligende tabel app_m_vaerelser
        public async void LoadMeVaerelsers()
        {
            Mellem_Vaerelsers = new ObservableCollection<Me_Vaerelser>(await Persistency.DB_Persistency.LoadMellemVaerelserFromDB());
        }
        
        //Henter medarbejdere fra DB
        public async void LoadMedarbejders()
        {
            Medarbejders = new ObservableCollection<M_Medarbejder>(await Persistency.DB_Persistency.LoadMedarbejdersFromDB());
        }
        
        //Henter Behandlinger fra DB
        public async void LoadBehandlings()
        {
            Behandlings = new ObservableCollection<M_Behandling>(await Persistency.DB_Persistency.LoadBehandlingsFromDB());
        }

        //Henter Bookings fra DB
        public async void LoadBookings()
        {
            Bookings = new ObservableCollection<M_Booking>(await Persistency.DB_Persistency.LoadBookingsFromDB());
        }
        
        //Henter Rooms fra DB
        public async void LoadRooms()
        {
            Rooms = new ObservableCollection<M_Room>(await Persistency.DB_Persistency.LoadRoomsFromDB());
        }

        //Henter Gæster fra DB
        public async void LoadGaests()
        {
            Gaests = new ObservableCollection<M_Gaest>(await Persistency.DB_Persistency.LoadGaestsFromDB());
        }

    


        public static Singelton GetInstance
        {
            get
            {
                return _instance ?? (_instance = new Singelton()); 
            }
        }

    }
}
