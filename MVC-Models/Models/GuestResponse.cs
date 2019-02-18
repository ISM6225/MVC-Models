using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
    The model (M in MVC) is the representation of real-world objects,
    processes, and rules that define the subject, known as the domain
    of the application. 
    This model is used to define the process and data collected in this
    application. This application collects information needed for people
    to RSVP to an event. 
*/
namespace MVC_Models.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // This is a null bool data type so that it can be true, false, or null
        public bool? WillAttend { get; set; }
    }
}
