namespace Thrift4Net.Client
{
    #region Using

    using System;

    using Thrift.Protocol;
    using Thrift.Transport;

    #endregion

    public class Program
    {
        private static void Main(string[] args)
        {
            TTransport transport = new TSocket("localhost", 7911);
            TProtocol protocol = new TBinaryProtocol(transport);
            HelloWorldService.Client client = new HelloWorldService.Client(protocol);
            transport.Open();

            Console.WriteLine("Client calls .....");

            string result = client.sayHello("say hello.");

            Console.WriteLine(result);

            transport.Close();

            Console.Read();
        }
    }
}