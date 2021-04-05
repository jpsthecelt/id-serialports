using System;
using System.IO.Ports;

namespace id_serialports {
    public class Program {
        public static void Main(string[] args) {
            String[] PortNames = SerialPort.GetPortNames();
            
            Console.WriteLine("Available Ports: [<CR> to exit]");
            foreach (string p in PortNames) {
                Console.WriteLine("   {0}", p);
            }
            string msg = Console.ReadLine();
        }
    }
}
