using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Midterm_Review
{
    class Member
    {

        string _firstName;
        string _lastName;
        string _userIdNumber;
        int _points = 0;

        public Member(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

            Random rand = new Random();
            _userIdNumber = rand.Next(1000000, 10000000).ToString();
        }

        public override string? ToString()
        {
            return $"{_firstName} {_lastName} - Id: {_userIdNumber} - Points: {_points}";
        }
    }
}
