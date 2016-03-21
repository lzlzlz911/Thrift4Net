namespace Thrigt4Net.Case
{
    public class HellowWordBusiness : HelloWorldService.Iface
    {
        public string sayHello(string username)
        {
            return username + "HellowWordBusiness";
        }
    }
}