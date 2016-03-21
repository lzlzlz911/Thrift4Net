namespace Thrift4Net.Server
{
    #region Using

    using System;

    using Thrift.Server;
    using Thrift.Transport;

    using Thrigt4Net.Case;

    #endregion

    internal class Program
    {
        private static void Main(string[] args)
        {
            TServerSocket serverTransport = new TServerSocket(7911, 0, false);
            HelloWorldService.Processor processor = new HelloWorldService.Processor(new HellowWordBusiness());
            TServer server = new TSimpleServer(processor, serverTransport);
            Console.WriteLine("Starting server on port 7911 ...");
            server.Serve();

            Console.Read();
        }
    }
}