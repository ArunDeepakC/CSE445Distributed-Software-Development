using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


/// CONTRIBUTION:
/// Name:   Rishti Gupta
/// ASUID:  1217211814
/// Email:  rgupta75@asu.edu
/// Class:  CSE-445 (#96279)
/// 
namespace Project2_CSE445
{
    public class Program
    {
        public const bool DEBUG = false;

        private const int K = 2; // Number of Parks
        private const int N = 5; // Number of Travel Agencies

        private static Thread[] parkThreads = new Thread[K]; 
        private static Thread[] agencyThreads = new Thread[N]; 
        private static Park[] parks = new Park[K];
        private static TravelAgency travelAgency;

        public static MultiCellBuffer mcb = new MultiCellBuffer(); // Initializing Multi-Cell Buffer

        // confirmation callback delegate
        public delegate void orderProcessedEvent(OrderClass order, double final_price); 
        static void Main(string[] args)
        {
            //Initializing the park threads
            for (int i = 0; i < K; ++i)
            {
                Park park = new Park(); // new object of Park created
                parks[i] = park;
                parkThreads[i] = new Thread(park.Run);
                parkThreads[i].Name = "Park_" + i;
                parkThreads[i].Start();
                while (!parkThreads[i].IsAlive) ;
            }

            // Initialize the Travel Agencies
            for (int i = 0; i < N; ++i)
            {
                travelAgency = new TravelAgency(); // new object of travel agency created

                // Subscribe each Travel Agency to Price Cut Events by looping through each park
                for (int j = 0; j < K; ++j)
                {
                    travelAgency.Subscribe(parks[j]);
                }

                agencyThreads[i] = new Thread(travelAgency.Run);
                agencyThreads[i].Name = "TravelAgency_" + i;
                agencyThreads[i].Start();
                while (!agencyThreads[i].IsAlive) ;
            }

            OrderProcessing.orderProcessed += new orderProcessedEvent(travelAgency.orderProcessed);

            // Wait for the Parks to perform P_MAX (=20) price cuts
            for (int i = 0; i < K; ++i)
            {
                while (parkThreads[i].IsAlive) ;
            }

            // Inform the Travel Agencies that the Park Threads are no longer active
            for (int i = 0; i < N; ++i)
            {
                TravelAgency.ParksActive = false;
            }

            // Waiting for the Travel Agency to close
            for (int i = 0; i < N; ++i)
            {
                while (agencyThreads[i].IsAlive) ;
            }

            Console.WriteLine("\n\n--------------------------END OF PROGRAM--------------------------");

            // Wait for the user to hit enter
            Console.WriteLine("PRESS ENTER TO EXIT !!!");
            Console.ReadLine();

        }
    }
}
