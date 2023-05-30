using BikeRentApp.Models;

namespace BikeRentApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static Catalogue form_catalogue = new Catalogue();
        public static Form1 form_mainmenu = new Form1();
        public static UploadBike form_upload = new UploadBike();


        [STAThread]
        static void Main()
        {
            User user1 = new User("brandon.zeier@gmail.com", "12345", "brandonzeier", 100.0f);
            User user2 = new User("donaldtrump@gmail.com", "12345", "dtrump", 130.0f);
            User user3 = new User("brook@gmail.com", "12345", "brook123", 312.0f);

            Bike bike1 = new Bike("Aprilia", "Good for long distances", user1, 12.0f, "bike.png");
            Bike bike2 = new Bike("Pegeut 331", "Good for short distances", user2, 5.1f, "scooter.png");
            Bike bike3 = new Bike("Yamaha 212x", "Fast and reliable", user3, 10.0f, "yamha.png");
            Manager.Catalogue.Add(bike1);
            Manager.Catalogue.Add(bike2);
            Manager.Catalogue.Add(bike3);



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(form_mainmenu);
           // Application.Run(form_catalogue);
            //Application.Run(form_upload);
            //form_mainmenu.Show();
            //form_upload.Hide();
            //form_catalogue.Hide();
        }
    }
}