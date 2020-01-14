using System;

namespace InRefOut
{
    class Program
    {

        /*
         * 
         * ref is used to state that the parameter passed may be modified by the method.

            in is used to state that the parameter passed cannot be modified by the method.

            out is used to state that the parameter passed must be modified by the method.
         * 
         * 
         * 
         */
        static void Main(string[] args)
        {
            //
            //string s=  inRefOut.ReadName();
            //inRefOut.SetValueRef(ref s);
            //inRefOut.IsHeActuallyPratikOUT(out bool truth);
            //Console.WriteLine("new value of s:" + s + "             truth value is: " + truth);
            InRefOut inRefOut = new InRefOut();
            TryingString tryingString = new TryingString();
            inRefOut.SetValueRef(ref tryingString.s);
            inRefOut.SetValueIn(tryingString);
            bool final = inRefOut.IsHeActuallyPratikOUT(out bool truth);
            if(final == true)
            {
                Console.WriteLine("Successfully implemented");
            }
            else
            {
                Console.WriteLine("Not done");
            }


        }
    }

    public class TryingString
    {
        public string s;
        public bool intern;
       
        public TryingString()
        {
            s = "PRATIK";
            intern = false;

        }

    }
    class InRefOut
    {
        
        TryingString tryingString = new TryingString(); //ctor called, fields initialized

        
        public void SetValueRef(ref string s)
        {
            if(s.Equals("PRATIK"))
            {
                s = "pratik is an intern";
            }
        }

        public void SetValueIn(TryingString tryingString)
        {
            tryingString.intern = true;
        }

        //public void SetValueIN(in string s)
        //{
        //    if (s.Equals("PRATIK"))
        //    {
        //        s = "pratik is an intern";
        //    }
        //}

        //in case of out, the parameter passed inside the method should be initialized inside the method.
        //ref does not need to be initialized inside the method, but out should be.

        public bool IsHeActuallyPratikOUT(out bool truth)
        {
            truth = false;
            if(tryingString.intern == true && tryingString.s.Equals("pratik is an intern"))
            {
                truth = true;
            }
            return truth;
        }





    }



}
