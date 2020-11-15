using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace commtaki
{
    static class Program
    {
        static Socket sender;

        [STAThread]
        static void Main()
        {
           
        }

        //joining a game
        static void JoinGame()
        {
            //  creating multiple disctionaries to send data to the server
            Dictionary<string, object> join_game_dic = new Dictionary<string, object>();
            Dictionary<string, string> args_dic = new Dictionary<string, string>();

            join_game_dic.Add("code", "join_game");

            args_dic.Add("game_id", "0");
            args_dic.Add("player_name", "");
            args_dic.Add("password", "");

            join_game_dic.Add("args", args_dic);

            //creating a json message to send to the server and sending it
            string json_message = JsonConvert.SerializeObject(join_game_dic);
            byte[] byData = Encoding.ASCII.GetBytes(json_message);
            sender.Send(byData);

            byte[] buffer = new byte[1024];

            // Receive the response from the server  
            int bytesRec = sender.Receive(buffer);
            string rcv_msg = Encoding.ASCII.GetString(buffer);

        }

        //creating a game
        static void CreateGame()
        {
            //  creating multiple disctionaries to send data to the server
            Dictionary<string, object> create_game_dic_1 = new Dictionary<string, object>();
            Dictionary<string, string> args_dic = new Dictionary<string, string>();

            create_game_dic_1.Add("code", "create_game");

            args_dic.Add("lobby_name", "");
            args_dic.Add("player_name", "");
            args_dic.Add("password", "");

            create_game_dic_1.Add("args", args_dic);

            //creating a json message to send to the server and sending it
            string json_message = JsonConvert.SerializeObject(create_game_dic_1);
            byte[] byData = Encoding.ASCII.GetBytes(json_message);
            sender.Send(byData);

            byte[] buffer = new byte[1024];

            // Receive the response from the server  
            int bytesRec = sender.Receive(buffer);
            string rcv_msg = Encoding.ASCII.GetString(buffer);

        }

        static void LeaveGame()
        {
            //  creating multiple disctionaries to send data to the server
            Dictionary<string, object> leave_game_dic_1 = new Dictionary<string, object>();
            Dictionary<string, string> args_dic = new Dictionary<string, string>();

            leave_game_dic_1.Add("code", "leave_game");
 
            args_dic.Add("jwt", "");

            leave_game_dic_1.Add("args", args_dic);

            //creating a json message to send to the server and sending it
            string json_message = JsonConvert.SerializeObject(leave_game_dic_1);
            byte[] byData = Encoding.ASCII.GetBytes(json_message);
            sender.Send(byData);

            byte[] buffer = new byte[1024];

            // Receive the response from the server  
            int bytesRec = sender.Receive(buffer);
            string rcv_msg = Encoding.ASCII.GetString(buffer);

        }

        static void StartGame()
        {
            //  creating multiple disctionaries to send data to the server
            Dictionary<string, object> start_game_dic_1 = new Dictionary<string, object>();
            Dictionary<string, string> args_dic = new Dictionary<string, string>();

            start_game_dic_1.Add("code", "start_game");

            args_dic.Add("jwt", "");

            start_game_dic_1.Add("args", args_dic);

            //creating a json message to send to the server and sending it
            string json_message = JsonConvert.SerializeObject(start_game_dic_1);
            byte[] byData = Encoding.ASCII.GetBytes(json_message);
            sender.Send(byData);

            byte[] buffer = new byte[1024];

            // Receive the response from the server  
            int bytesRec = sender.Receive(buffer);
            string rcv_msg = Encoding.ASCII.GetString(buffer);

        }

        static void PlaceCards(string[] chosen_cards)
        {
            //  creating multiple disctionaries to send data to the server
            Dictionary<string, object> place_cards_dic_1 = new Dictionary<string, object>();
            Dictionary<string, object> args_dic = new Dictionary<string, object> ();

            place_cards_dic_1.Add("code", "place_cards");

             
            args_dic.Add("jwt", "");
            args_dic.Add("cards", chosen_cards);

            place_cards_dic_1.Add("args", args_dic);

            //creating a json message to send to the server and sending it
            string json_message = JsonConvert.SerializeObject(place_cards_dic_1);
            byte[] byData = Encoding.ASCII.GetBytes(json_message);
            sender.Send(byData);

            byte[] buffer = new byte[1024];

            // Receive the response from the server  
            int bytesRec = sender.Receive(buffer);
            string rcv_msg = Encoding.ASCII.GetString(buffer);

        }

        static void TakeCards()
        {
            //  creating multiple disctionaries to send data to the server
            Dictionary<string, object> take_cards_dic_1 = new Dictionary<string, object>();
            Dictionary<string, string> args_dic = new Dictionary<string, string>();

            take_cards_dic_1.Add("code", "take_cards");

            args_dic.Add("jwt", "");
             
            take_cards_dic_1.Add("args", args_dic);

            //creating a json message to send to the server and sending it
            string json_message = JsonConvert.SerializeObject(take_cards_dic_1);
            byte[] byData = Encoding.ASCII.GetBytes(json_message);
            sender.Send(byData);

            byte[] buffer = new byte[1024];

            // Receive the response from the server  
            int bytesRec = sender.Receive(buffer);
            string rcv_msg = Encoding.ASCII.GetString(buffer);
        }


        //connecting to the server
        static void ExecuteClient()
        {

            try
            {

                // Establish the remote endpoint  
                // for the socket. 
                // uses port 8080 on the local  
                // computer. 
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = IPAddress.Parse("104.156.225.184");
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 8080);

                // Creation TCP/IP Socket using  
                // Socket Class Costructor 
                sender = new Socket(ipAddr.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);

                try
                {

                    // Connect Socket to the remote
                    sender.Connect(localEndPoint);

                    
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }

                // Manage of Socket's Exceptions 
                catch (ArgumentNullException ane)
                {

                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }

                catch (SocketException se)
                {

                    Console.WriteLine("SocketException : {0}", se.ToString());
                }

                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }
        
    }
} 

    

