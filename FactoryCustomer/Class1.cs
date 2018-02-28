using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiddleLayer;

namespace FactoryCustomer
{
    public  static class Factory // design patten (SIMPLE FACTORY PATTERN)
    {
        private static Dictionary<string, CustomerBase> _custs = new Dictionary<string, CustomerBase>();

        //will remove contructor since its loading libraries which we may not want to instiate both libraries
        //  static Factory() 
        // {
        //whether we want these libraries or not they are still loaded
        //   _custs.Add("Customer", new Customer());   /// move to CustomerBase
        //    _custs.Add("Lead", new Lead());           /// move to CustomerBase
        // }
        public static CustomerBase Create (string TypeOfCustomer)
        {
            //design pattern (LAZY LOADING) - Load objects on demand
            //if custs is called then the cust librarys are loaded. else not. since 0
            if (_custs.Count == 0)
            {
                _custs.Add("Customer", new Customer());
                _custs.Add("Lead", new Lead());
            }
            //disign pattern (RIP - Replace IF with Polymophism )
            return _custs[TypeOfCustomer];
        }
    }
}
