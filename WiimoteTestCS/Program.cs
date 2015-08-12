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

		[STAThread]
		static void Main()
		{
            udpManager = new UDPPacketIO();
            udpManager.init("127.0.0.1", 13000, 13560);
            oscManager = new Osc();
            oscManager.init(udpManager);

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MultipleWiimoteForm());

		}

	}
}