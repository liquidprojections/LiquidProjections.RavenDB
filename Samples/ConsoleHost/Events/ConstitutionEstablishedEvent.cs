using System;

namespace ConsoleHost.Events
{
    internal class ConstitutionEstablishedEvent
    {
        public string Number { get; set; }
        public string Kind { get; set; }
        public Guid Country { get; set; }
        public string InitialState { get; set; }
    }
}