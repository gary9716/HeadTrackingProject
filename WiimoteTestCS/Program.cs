using System;
using System.Windows.Forms;
using System.Diagnostics;
using Alchemy;
using Alchemy.Classes;
using Newtonsoft.Json;
using System.Net;

namespace WiimoteTest
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
        /// 

        public static UDPPacketIO udpManager;
        public static Osc oscManager;
        public static string dstIP = "127.0.0.1";
        public static int sendToPort = 13000;
        public static int listenToPort = 13560;

		[STAThread]
        static void Main(string[] args)
		{
            for (int i = 0; i < args.Length && i < 3; i++)
            {
                if (i == 0)
                {
                    dstIP = args[i];
                }
                else if (i == 1)
                {
                    sendToPort = int.Parse(args[i]);
                }
                else if (i == 2)
                {
                    listenToPort = int.Parse(args[i]);
                }
            }

            Console.WriteLine("current IP is " + dstIP + ",sendToPort:" + sendToPort + ",listenToPort:" + listenToPort);

            udpManager = new UDPPacketIO();
            udpManager.init(dstIP, sendToPort, listenToPort);
            oscManager = new Osc();
            oscManager.init(udpManager);

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MultipleWiimoteForm());

		}

	}
}