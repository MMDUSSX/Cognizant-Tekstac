using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopEnrollmentApp
{
    //Write your code here
    public class TraineeBL
    {
        public bool SaveTraineeDetails(TraineeBO objBO)
        {
            TraineeDA tDA = new TraineeDA();
            bool res = tDA.AddTraineeDetails(objBO);
            if (res)
                return true;
            else
                return false;
        }
    }
}