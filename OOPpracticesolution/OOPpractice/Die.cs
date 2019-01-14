using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice
{
    public class Die
    {
        //create a new instance of the math class Random
        //this object will be shared by each
        //  instance of the class Die
        //this instance will be created when the first instance
        //  of Die is created

        private static Random _Rnd = new Random();

        //this is the defination of a Object 
        //it is a conceptual view of the data
        //that will be held by a physical 
        //instance (Object) of this class

        //Data Members
        //is an internal private data storage item
        //private data members CANNOT be reached directly by the user 
        //public data members CAN be reached directly by the user
        private int _Side;
        private string _Colour;

        //Properties
        //a property is an external interface between the user
        // and a single piece of data within the instance(object)
        //a property has two abilities
        //  a)the ability to assign a value to the internal
        //    data member
        //  b) return a internal data member value to the user

        //Fully Implemented Property
        public int Side
        {
            get
            {
                //takes internal values and returns it to the user 
                return _Side;
            }
            private set
            {
                //takes the supplied user value and places it into
                //  the internal private data member
                // the incoming piece of data is placed into a special
                //  variable that is called: Value
                //  optionally you may place valdation on the incoming value
                if (value >= 6 && value <= 20)
                {
                    _Side = value;
                    //Roll(); // consider placing this method within the property if the set is public not private
                              // if private then the method SetSides solves this problem
                }
                else
                {
                    // throws error message to the user.
                    throw new Exception("Die cannot be spaced " + value.ToString() + "sides. Die must have between 6 and 20 sides");
                }
            }
        }
        public string Colour
        {
            get
            {
                return _Colour;
            }
            set
            {
                //(value == null) this will fail for an empty string 
                //(value == "") this will fail for a null value
                if (string.IsNullOrEmpty(value))
                {
                    _Colour = value;
                }
                else
                {
                    throw new Exception("Die must have a proper color value");
                }

            }
        }

        //another version of Sides using a private set and auto implemented property
        //  in this version you would need to code a method like SetSides()
        // public int Sides { get; private set; }

        //Auto Implemented Property 
        //is public
        //it has a data type 
        //it has a name 
        //IT DOES NOT have an internal data member that you can DIRECTLY access
        //the system will create, internally, a data storage area of the appropriate
        //  datatype and manage the area.
        //the only way to access the data of an Auto Implemented Property is via
        //  the property 
        //usually used when there is no need for any internal validation or other
        //  property logic.
        public int FaceValue { get; set; }

        //Constructors
        //  optional; if not supplied the system default constructor
        //  is used which willl asssing a systenm value to each datamember
        //  /auto implemented property accordin to its datatype

        // you can have any number of constructors within your class
        //  as soon as you code a constructor, your program is responsible
        //  for all constructors

        //syntax public className([list of parameters]){.....}

        //Typical constructors

        //Default constructor
        //  this is similiar to the system default constructor
        
        public Die()
        {

            //You could leave this constructor empty and the system would
            //  acces the normal default value to your data members amd
            //  auto implemented properties

            // you can directly access a private datamember any 
            //  place within your class.
            _Side = 6;

            // you can access any property any place within your class
            Colour = "White";
            // you could use a class method to generate a value for
            //  a datamember/auto property
            Roll();
        }

        //Greedy Constructor
        //  typically has a parameter for each datamember and auto implemented property
        //  within your class, param order is not important
        //  this constructor allows the outside user to create and assing their own
        //  values to the datamembers/ auto properties at the time of instantiating 


        // this.Var
        //  can be used outside class, as well as inside class.
        //  its used to clarify ownership inside class.
        //  this. clarifies datamembers. Outside class this. clarifies user
        public Die(int sides, string colour)
        {
            //since this data is coming from an outside source, it is best
            //  to use your properties to save the values; especially if 
            //  the property has validation.
            Side = sides;
            Colour = colour;
            Roll();
        }

        //Behaviours ( Methods )
        
        // these are actions which the class can perform
        //the actions may or may not alter data members/auto 
        //  property values
        //the actions could simply take value(s) from the user
        //  and perform some logic operations against the values


        //can be public or private
        //create a method that allows the user to change the number
        //  of sides on a die.

        public void SetSides(int sides)
        {
            if (sides  >= 6 && sides <= 20)
            {
                Side = sides;
            }
            else
            {
                //optionally 
                //a) throw a new exception or 
                throw new Exception("invalid value for sides");
                //b) set _Side to a default value
                //Side = 6;
            }
            Roll();
        }

        public void Roll()
        {
            //no parameters are required for this method since it will be
            //  using the internal dataValues to complete its functionality

            //randomely generate a value die depending on the maximum
            //  Sides

            FaceValue = _Rnd.Next(1, Side + 1);
        }

    }
}
