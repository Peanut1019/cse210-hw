using System;
 public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _jobTitle = "Meteor";
        public string _company = "Milky Way Galaxy";
        public int _startYear = 0;
        public int _endYear = 10000;

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }