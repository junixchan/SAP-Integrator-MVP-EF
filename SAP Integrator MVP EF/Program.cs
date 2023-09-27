using SAP_Integrator_MVP_EF.Presenters;
using SAP_Integrator_MVP_EF.Views.MainView;
using System.Configuration;

namespace SAP_Integrator_MVP_EF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);

            Application.Run((Form)view);
        }
    }
}