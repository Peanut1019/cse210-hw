using System;
 public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _jobTitle = "";
        public string _company = "";
        public int _startYear;
        public int _endYear;

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        
        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowJob()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
        
    }