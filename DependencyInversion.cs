using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCharpBasic
{
    //Service Locator and Inversion of control is a way to impliment DI.
    public interface IService
    {
         void Serve();
    }

    class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service called");
        }
    }
    static class LocateService 
    {
        public static IService _Service { get; set; }
        public static IService GetService()
        {
            if (_Service == null)
                _Service = new Service();
            return _Service;
        }

    }
    public class Client
    {
        private IService _service;
        public Client()
        {
            this._service = LocateService.GetService();
        }
        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
        }
    }
    class DependencyInversion
    {

    }
  
}
