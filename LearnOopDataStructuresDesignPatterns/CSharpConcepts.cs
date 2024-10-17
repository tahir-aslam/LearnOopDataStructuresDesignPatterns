using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOopDataStructuresDesignPatterns
{
    public class CSharpConcepts
    {
    }

    public delegate void Notify();
    public class Process 
    {
        public event Notify ProcessCompleted;
        public void Start() 
        {
            //Process started
            //process completed
            ProcessCompleted?.Invoke(); // raise event
        }
    }

}
