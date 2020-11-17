using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

/// CONTRIBUTION:
/// Name:   Rishti Gupta
/// ASUID:  1217211814
/// Email:  rgupta75@asu.edu
/// Class:  CSE-445 (#96279)

///AND

/// Name:   Arun Deepak Chandrasekar
/// ASUID:  1217200647
/// Email:  achand66@asu.edu
/// Class:  CSE-445 (#96279)

namespace Project2_CSE445
{
    public class MultiCellBuffer
    {
        // Size of the Multi-Cell Buffer
        private const int N = 3;
        private const int WRITE_RESOURCES = 3;
        private const int READ_RESOURCES = 2;

        // tracking the buffer 
        int head = 0;
        int tail = 0;
        int nElements = 0;

        // Buffer for communication between threads
        string[] buffer = new string[N];

        // Semaphores to control read/write access
        Semaphore write = new Semaphore(WRITE_RESOURCES, WRITE_RESOURCES);
        Semaphore read = new Semaphore(READ_RESOURCES, READ_RESOURCES);


        // travel agency sets the cell of a multi-cell buffer
        public void setOneCell(string order)
        {
            write.WaitOne();
            Console.ResetColor();
            Console.WriteLine(Thread.CurrentThread.Name + " Entered Write");
            lock (this)
            {
                // Wait till there is a slot available in the Multi-Cell Buffer
                while (nElements == N)
                {
                    if (Program.DEBUG)
                    {
                        Console.ResetColor();
                        Console.WriteLine("MONITOR: Waiting For Write By {0}", Thread.CurrentThread.Name);
                    }
                    Monitor.Wait(this);
                }

                buffer[tail] = order;
                tail = (tail + 1) % N;

                Console.ResetColor();
                Console.WriteLine("WRITE IN MULTI CELL BUFFER: ({0}) \n\n{1}\n{2}, Elements: {3}\n",
                    Thread.CurrentThread.Name,
                    order,
                    DateTime.Now,
                    nElements
                );

                nElements++; // Increment the amount of elements
                Console.ResetColor();
                Console.WriteLine("({0}) Leaving Write", Thread.CurrentThread.Name);
                write.Release(); 
                Monitor.Pulse(this);
            }
        }

        // park reads the cell of a multi-cell buffer
        public string getOneCell()
        {
            read.WaitOne();
            Console.ResetColor();
            Console.WriteLine(Thread.CurrentThread.Name + " Entered Read");
            lock (this)
            {
                string element;
                XmlDocument doc = new XmlDocument();

                // Wait till there is an element in the Multi-Cell Buffer
                while (nElements == 0)
                {
                    if (Program.DEBUG)
                    {
                        Console.ResetColor();
                        Console.WriteLine("MONITOR: Waiting For Read By {0}", Thread.CurrentThread.Name);
                    }
                    Monitor.Wait(this);
                }

                element = buffer[head];

                // get ReceiverId from the XML
                doc.LoadXml(element);
                XmlElement node = doc.GetElementById("ReceiverId");

                // Make sure the ReceiverId is equivalent to the Park Thread Name
                if (node == null || Thread.CurrentThread.Name == node.InnerText)
                {
                    // Read and process order for the park
                    head = (head + 1) % N;
                    nElements--;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("READING FROM MULTI-CELL BUFFER: ({0})\n\n{1}\n{2}, Elements: {3}\n",
                        Thread.CurrentThread.Name,
                        element,
                        DateTime.Now,
                        nElements
                    );
                }
                else
                {
                    Console.ResetColor();
                    // Do not process the order if ReceiverId does not match the Park 
                    Console.WriteLine("SKIPPING: Order not for Park ({0})", Thread.CurrentThread.Name);
                }

                Console.ResetColor();
                Console.WriteLine("{0} Leaving Read", Thread.CurrentThread.Name);
                read.Release();
                Monitor.Pulse(this); 
                return element;
            }
        }
    }
}
