// Syacomms running various sytem commands using chasrp 

namespace sysacoms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run the command
            System.Diagnostics.Process.Start("cmd.exe", "/c ipconfig /all");
        }
    }
}