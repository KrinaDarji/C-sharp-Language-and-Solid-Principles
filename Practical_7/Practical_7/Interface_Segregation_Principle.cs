using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_7
{
    /*  its an example of Interface Segregation Principle which says that no clients should
        be forced to implement methods which it does not use and the contracts 
        should be broken down to thin ones,here in this example there are two interface 
        for each type of work and its implemented by classes which are using specific Functionality */
    interface Backend_Developer
    {
        public void HandleBackend();
    }
    interface Frontend_Developer
    {
        public void HandleFrontend();
    }
    //class Fullstack will have both developers backend as well as frontend
    class Fullstackdeveloper: Backend_Developer, Frontend_Developer
    {
        public void HandleBackend()
        {
            Console.WriteLine("Handle Backend");
        }
        public void HandleFrontend()
        {
            Console.WriteLine("Handle Frontend");
        }
    }
    //class React will implement only frontend as it will not contain backend functionality
    class ReactDeveloper: Frontend_Developer
    {
        public void HandleFrontend()
        {
            Console.WriteLine("Handle only Frontend");
        }
    }
    //class Node will implement only Backend as it will not contain frontend functionality
    class NodeDeveloper : Backend_Developer
    {
        public void HandleBackend()
        {
            Console.WriteLine("Handle only Backend");
        }
    }
}
