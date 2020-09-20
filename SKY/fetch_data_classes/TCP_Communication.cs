using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SKY
{
    class TCP_Communication
    {
        public string sendMessage(byte[] messageBytes,int port)
        {
            const int bytesize = 1024 * 1024;
            try // Try connecting and send the message bytes  
            {
                TcpClient client = new TcpClient("127.0.0.1", port); // Create a new connection  3333
                NetworkStream stream = client.GetStream();

                stream.Write(messageBytes, 0, messageBytes.Length); // Write the bytes  
                /*Console.WriteLine("================================");
                Console.WriteLine("=   Connected to the server    =");
                Console.WriteLine("================================");
                Console.WriteLine("Waiting for response...");*/

                messageBytes = new byte[bytesize]; // Clear the message   

                // Receive the stream of bytes  
                stream.Read(messageBytes, 0, messageBytes.Length);

                // Clean up  
                stream.Dispose();
                client.Close();
            }
            catch (Exception e) // Catch exceptions  
            {
                Console.WriteLine(e.Message);
            }

            char delimiter = '\n';
            string output = Encoding.Default.GetString(messageBytes);
            String[] substrings = output.Split(delimiter);
            return substrings[0]; // Return response  
        }

    }
}
