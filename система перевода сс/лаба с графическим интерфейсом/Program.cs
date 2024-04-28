
//Program.cs определяет точку входа в приложение
//Метод Main снабжен атрибутом [STAThread].
//Этот атрибут, грубо говоря, необходим для корректной работы компонентов Windows. 


namespace приложение
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}