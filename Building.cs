using System;

namespace Planner
{
    // Define class here
    public class Building {
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int _Stories {get; set;}
        public double _Width {get; set;}
        public double _Depth {get; set;}

        public void Volume () { Console.WriteLine( _Width * _Depth * (3 * _Stories)); }

    
    }
}