using System.ComponentModel;

namespace FormyPodstawy
{
    internal static class Program
    {
        public static BindingList<Kolarz> listaKolarzy = new BindingList<Kolarz>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Pliki.odczytajPlik();
            Application.Run(new Form1());
            Form1 form1 = new Form1();
            setSecurity(ref form1);
        }

        private static void setSecurity(ref Form1 frm)
        {
            foreach(var button in frm.Controls.OfType<Button>().Where(btn => btn.Tag.ToString()== "admin"))
            {
                button.Visible = true;
            }
        }
    }
}