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




        public Singelton()
        {
            Load();
        }

        public async void Load()
        {
            
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
