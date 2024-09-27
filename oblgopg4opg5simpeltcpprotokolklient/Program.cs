using oblgopg4opg5simpeltcpprotokolklient;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;



#region with json
//string serverIP = "127.0.0.1";  // IP address of the server
//int serverPort = 7;             // Port the server is listening on

//using (TcpClient client = new TcpClient())
//{
//    try
//    {
//        // Connect to the server
//        await client.ConnectAsync(serverIP, serverPort);
//        Console.WriteLine($"Connected to server at {serverIP}:{serverPort}");

//        using (NetworkStream stream = client.GetStream())
//        using (StreamReader reader = new StreamReader(stream))
//        using (StreamWriter writer = new StreamWriter(stream))
//        {
//            writer.AutoFlush = true;  // Automatically flush data

//            Console.Write("Enter command (add, subtract or random, followed by:<number> <number>, or quit to exit): ");
//            while (true)
//            {
//                int num1;
//                int num2;
//                string message = Console.ReadLine();

//                // Exit the loop if the user types "quit"
//                if (message.Trim().ToLower() == "quit")
//                {
//                    await writer.WriteLineAsync("quit");
//                    Console.WriteLine("Disconnecting from the server...");
//                    break;
//                }

//                string[]? commandmessage = message.Split(" ", 2);
//                string[]? numbers;

//                if (commandmessage.Length < 2)
//                {
//                    await writer.WriteLineAsync(message); // send to server

//                    string serverResponse = await reader.ReadLineAsync(); // await response to avoid delay,
//                                                                          // can only accept 1 server response at a time,
//                                                                          // multiple server responses at a time would cause a delay
//                    Console.WriteLine($"Server: {serverResponse}");
//                    continue; // ensure that next iteration starts
//                }
//                else
//                {
//                    numbers = commandmessage[1].Split(" ");

//                    if ((commandmessage[0].Trim().ToLower() == "add" ||
//                        commandmessage[0].Trim().ToLower() == "subtract" ||
//                        commandmessage[0].Trim().ToLower() == "random") &&
//                        int.TryParse(numbers[0], out num1) &&
//                        int.TryParse(numbers[1], out num2) &&
//                        numbers.Length == 2)
//                    {
//                        Console.WriteLine("Succesful input, sending data");

//                        int[] nums = [num1, num2]; // Make int array if numbers are actually ints

//                        Data data = new Data();
//                        data.Method = commandmessage[0];
//                        data.Numbers = nums;

//                        if (data != null && data.Numbers == nums && data.Method == commandmessage[0])
//                        {

//                            string serializedData = JsonSerializer.Serialize(data);// serialize the data into a json file
//                            Console.WriteLine(serializedData); // log the data to console
//                            await writer.WriteLineAsync(serializedData); // send it

//                            string serverResponse = await reader.ReadLineAsync();
//                            Console.WriteLine($"Server: {serverResponse}");
//                        }
//                        else
//                        {
//                            writer.WriteLine("internal error, data could not be formatted correctly");

//                            string serverResponse = await reader.ReadLineAsync();
//                            Console.WriteLine($"Server: {serverResponse}");
//                        }

//                    }
//                    else
//                    {
//                        await writer.WriteLineAsync(message);

//                        string serverResponse = await reader.ReadLineAsync();
//                        Console.WriteLine($"Server: {serverResponse}");
//                        continue; // ensure that next iteration starts
//                    }
//                }
//            }
//        }
//    }
//    catch (SocketException ex)
//    {
//        Console.WriteLine("SocketException: " + ex.Message);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Exception: " + ex.Message);
//    }
//    finally
//    {
//        client.Close(); // ensure client is closed
//    }
//}
#endregion

#region without json
//string serverIP = "127.0.0.1";  // IP address of the server
//int serverPort = 7;             // Port the server is listening on

//using (TcpClient client = new TcpClient())
//{
//    try
//    {
//        // Connect to the server
//        await client.ConnectAsync(serverIP, serverPort);
//        Console.WriteLine($"Connected to server at {serverIP}:{serverPort}");

//        using (NetworkStream stream = client.GetStream())
//        using (StreamReader reader = new StreamReader(stream))
//        using (StreamWriter writer = new StreamWriter(stream))
//        {
//            writer.AutoFlush = true;  // Automatically flush data

//            Console.Write("Enter command (add, subtract, random, or quit to exit): ");
//            while (true)
//            {
//                string message = Console.ReadLine();

//                // Exit the loop if the user types "quit"
//                if (message.Trim().ToLower() == "quit")
//                {
//                    await writer.WriteLineAsync("quit");
//                    Console.WriteLine("Disconnecting from the server...");
//                    break;
//                }

//                // Send the command to the server
//                await writer.WriteLineAsync(message);

//                // Wait for the server's response
//                string serverResponse = await reader.ReadLineAsync();
//                Console.WriteLine("Server: " + serverResponse);

//                // If the server prompts for two numbers
//                if (serverResponse.StartsWith("Input 2 Numbers"))
//                {
//                    string numbersMessage;

//                    while (true)
//                    {
//                        numbersMessage = Console.ReadLine();
//                        string[] numbers = numbersMessage.Split(' ');

//                        if (numbers.Length == 2 &&
//                            int.TryParse(numbers[0], out int num1) &&
//                            int.TryParse(numbers[1], out int num2))
//                        {
//                            // Send the numbers to the server
//                            await writer.WriteLineAsync(numbersMessage);

//                            // Wait for the result from the server
//                            string result = await reader.ReadLineAsync();
//                            Console.WriteLine("Server: " + result);
//                            break;
//                        }
//                        else
//                        {
//                            Console.WriteLine("Invalid input. Please enter 2 numbers in the format: <number> <number>");
//                        }
//                    }
//                }
//            }
//        }
//    }
//    catch (SocketException ex)
//    {
//        Console.WriteLine("SocketException: " + ex.Message);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Exception: " + ex.Message);
//    }
//    finally
//    {
//        client.Close();
//    }
//}
#endregion

