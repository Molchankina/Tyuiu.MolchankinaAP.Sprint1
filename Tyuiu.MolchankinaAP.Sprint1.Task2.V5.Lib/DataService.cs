﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MolchankinaAP.Sprint1.Task2.V5.Lib
{
    public class DataService : ISprint1Task2V5
    {
        public int CalculateSideSquare(int value)
        {
            int y = 6;
            return (value * value)* y;
        }
    }
}
