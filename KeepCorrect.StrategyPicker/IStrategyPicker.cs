﻿using System;

 namespace KeepCorrect.StrategyPicker
{
    /// <summary>
    /// Picker that khows by what criterions strategy can be picked 
    /// </summary>
    /// <typeparam name="TStrategy"></typeparam>
    public interface IStrategyPicker<in TStrategy>
    {
        /// <summary>
        /// Conditions for choosing the required instance of the strategy
        /// </summary>
        /// <returns></returns>
        Func<TStrategy, bool> GetConditionsPredicate();
    }
    
    //Example implimentation:
    
    /*public interface IPicker : IStrategyPicker<ITestStrategy>
    {
    }
    
    public class Picker : IPicker
    {
        public Picker(Criterion1Enum criterion1, Criterion2Enum criterion2, Criterion3Enum criterion3)
        {
            Criterion1 = criterion1;
            Criterion2 = criterion2;
            Criterion3 = criterion3;
        }
    
        private Criterion1Enum? Criterion1 { get; }
        private Criterion2Enum? Criterion2 { get; }
        private Criterion3Enum? Criterion3 { get; }
    
        public Func<ITestStrategy, bool> GetPredicate()
        {
            return f =>
                    f.Criterion1 == Criterion1 && f.Criterion2 == Criterion2 && f.Criterion3 == Criterion3
                    ||
                    f.Criterion1 == Criterion1 && f.Criterion2 == Criterion2 && f.Criterion3 == null
                    ||
                    f.Criterion1 == null && f.Criterion2 == Criterion2 && f.Criterion3 == null
                ;
        }
    }*/
}