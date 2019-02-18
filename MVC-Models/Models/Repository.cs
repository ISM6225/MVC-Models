using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Models.Models
{
    /*
        This class and it members are static, which will make it easy to
        store and retrieve data from different places in the application. 
     */
    public static class Repository
    {
        // This List object will be used to keep track of my responses that
        // are collected in-memory
        private static List<GuestResponse> responses = new List<GuestResponse>();
        // Get the values from the GuestResponse Model
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        // Add the vaues from GuestResponse and Add them to the List
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
