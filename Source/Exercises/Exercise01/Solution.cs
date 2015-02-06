using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise01
{
    /*
        1. Given the Danish bill system of 1000, 500, 100, 50 
           And coin system of 20, 10, 5, 2, 1
           And dueAmount of 354
           And customerPay of 500
        2. Then totalChange = customerPay - dueAmount
        3. Set remainingChange = totalChange
        4. If remainingChange > 0
        5.   typeOfChange = find the largest bill or coin just below remainingChange
        6.   numberOfTypeOfChange = remainingChange / typeOfChange rounded down
        7.   Output "numberOfTypeOfChange x typeOfChange"
        8.   Reset remainingChange = remainingChange - typeOfChange * numberOfTypeOfChange
        9.   Goto step 4
        10. Done     
    */

    class Solution
    {
    }
}
