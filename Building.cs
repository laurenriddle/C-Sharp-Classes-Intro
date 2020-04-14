using System;

namespace Planner
{
    // Define class here
    public class Building {
        /* 
        Private Fields
        _designer of type string. It will hold your name.
        _dateConstructed of type DateTime. This will hold the exact time the building was created.
        _address of type string.
        _owner of type string. This will store the same of the person who owns the building.
        */
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;


        /* 
        Public Properties
        Stories typed as an integer.
        Width typed as a double.
        Depth typed as a double.
        Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
        */
        public int _Stories {get; set;}
        public double _Width {get; set;}
        public double _Depth {get; set;}
        public void Volume () { Console.WriteLine( _Width * _Depth * (3 * _Stories)); }

        /*
        Constructor

        Define a constructor method that accepts a single string argument - address - so that you can send as a parameter when you create each instance with new Building("800 8th Street");.
        The constructor's logic should set the _address field's value to the argument value
        */
        public Building(string address) {
            _address = address;
        }

        /*
        Public Methods
        Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
        Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private _owner field.
        Neither of these methods will return a value.
        */
        public void Construct() { _dateConstructed = DateTime.Now; }

        public void Purchased(string purchaser_name) { _owner = purchaser_name; }

    }
}