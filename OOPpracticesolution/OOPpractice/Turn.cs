using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice
{
    class Turn
    {
        private Die[,] _TrackTurn = new Die[,] { };


        private int _TurnTracker;

        public Die[,] TrackTurn
        {
            get { return _TrackTurn; }
            set
            {
                _TrackTurn = value;
            }
        }

        public Turn(Die playerOneTurn, Die playerTwoTurn)
        {

            TrackTurn[_TurnTracker, _TurnTracker] = playerOneTurn, playerTwoTurn;
            TrackTurn[_TurnTracker, _TurnTracker + 1] = playerTwoTurn;
            _TurnTracker++;
        }


        public void AddTurn(Die playerTurn)
        {
            TrackTurn[_TurnTracker, _TurnTracker] = playerTurn;

            _TurnTracker++;
        }
        public void DisplayTurns()
        {
            Console.WriteLine(TrackTurn.ToString());
        }
    }
    //class Turn1
    /*{
     * private int _Player1Roll;
     * 
     * public int Player1Roll
     *      {
     *         
     *      get
     *          {
     *              return _Player1Roll;
     *          }
     *      
     *      set
     *          {
     *              _Player1Roll = value;
     *          }          
     *      }
     *      
     *  public int Player2Roll {get; set; }
     *      
     */
    //
    // }
}
