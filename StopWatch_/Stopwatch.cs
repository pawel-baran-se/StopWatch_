using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch_
{
    internal class Stopwatch
    {
        //Fields

        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _interval;
        private bool _isRunning;

        //Properties

        internal void Start()
        {
            Console.Clear();
            try
            {
                if (!_isRunning)
                {
                    _isRunning = true;
                    _startTime = DateTime.Now;

                    Console.WriteLine($"Started timer  :{_startTime:T}");
                }
                else
                {
                    throw new Exception("Timer is already running, please reset first!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        internal void Stop()
        {
            Console.Clear();
            if(_startTime == default)
            {
                Console.WriteLine("Please start the timer first!");
            }
            else
            {
                _endTime = DateTime.Now;
                _interval = _endTime - _startTime;

                //Console.WriteLine($"Started at: {_startTime}");
                Console.WriteLine($"Ended at :{_endTime:T}");
                Console.WriteLine($"Interval :{_interval.Minutes}:{_interval.Seconds}.{_interval.Milliseconds}");
            }
            
        }

        internal void Reset()
        {
            Console.Clear();
            _isRunning = false;
            _startTime = default;
            _endTime = default;
        }

    }
}
