using System.Collections.Generic;
using NUnit.Framework;
using StrategyPicker;
using StrategyPickerTests.ExampleImplementation;

namespace StrategyPickerTests
{
    public class FactoryTests
    {
        private IFactory<ITestStrategy, IPicker> _factory;
        private IFactoryWithDefault<ITestStrategy, IPicker> _factoryWithDefault;
        
        [SetUp]
        public void Setup()
        {
            var strategies = new ITestStrategy[]
            {
                new TestStrategy2(),
                new TestStrategy1(),
                new TestStrategy4(),
                new TestStrategy3()
            };
            
            var strategiesWithDefault = new ITestStrategy[]
            {
                new TestStrategyDefault(),
                new TestStrategy2(),
                new TestStrategy1(),
                new TestStrategy4(),
                new TestStrategy3()
            };
            _factory = new Factory<ITestStrategy, IPicker>(strategies);
            _factoryWithDefault = new FactoryWithDefault<ITestStrategy, IPicker>(strategiesWithDefault);
        }
        
        private static IEnumerable<TestCaseData> Cases
        {
            get
            {
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.First, Criterion3Enum.First, StrategyTypeEnum.All);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Third, Criterion3Enum.Default, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.Third, Criterion3Enum.Default, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Third, Criterion3Enum.Default, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Third, Criterion3Enum.Default, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Third, Criterion3Enum.First, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.Third, Criterion3Enum.First, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Third, Criterion3Enum.First, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Third, Criterion3Enum.First, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Third, Criterion3Enum.Second, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.Third, Criterion3Enum.Second, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Third, Criterion3Enum.Second, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Third, Criterion3Enum.Second, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Third, Criterion3Enum.Third, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.Third, Criterion3Enum.Third, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Third, Criterion3Enum.Third, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Third, Criterion3Enum.Third, StrategyTypeEnum.OnlySecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Second, Criterion3Enum.Default, StrategyTypeEnum.FirstAndSecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Second, Criterion3Enum.First, StrategyTypeEnum.FirstAndSecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Second, Criterion3Enum.Second, StrategyTypeEnum.FirstAndSecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Second, Criterion3Enum.Third, StrategyTypeEnum.FirstAndSecond);
            }
        }
        
        private static IEnumerable<TestCaseData> CasesWithDefault
        {
            get
            {
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.First, Criterion3Enum.First, StrategyTypeEnum.All);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Default, Criterion3Enum.Third, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Default, Criterion3Enum.Default, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Second, Criterion3Enum.Second, StrategyTypeEnum.OnlyFirst);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Third, Criterion3Enum.Default, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.Third, Criterion3Enum.Default, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Third, Criterion3Enum.Default, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Third, Criterion3Enum.Default, StrategyTypeEnum.OnlyFirst);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Third, Criterion3Enum.First, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.Third, Criterion3Enum.First, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Third, Criterion3Enum.First, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Third, Criterion3Enum.First, StrategyTypeEnum.OnlyFirst);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Third, Criterion3Enum.Second, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.Third, Criterion3Enum.Second, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Third, Criterion3Enum.Second, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Third, Criterion3Enum.Second, StrategyTypeEnum.OnlyFirst);
                yield return new TestCaseData(Criterion1Enum.Default, Criterion2Enum.Third, Criterion3Enum.Third, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.First, Criterion2Enum.Third, Criterion3Enum.Third, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Third, Criterion3Enum.Third, StrategyTypeEnum.Default);
                yield return new TestCaseData(Criterion1Enum.Third, Criterion2Enum.Third, Criterion3Enum.Third, StrategyTypeEnum.OnlyFirst);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Second, Criterion3Enum.Default, StrategyTypeEnum.FirstAndSecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Second, Criterion3Enum.First, StrategyTypeEnum.FirstAndSecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Second, Criterion3Enum.Second, StrategyTypeEnum.FirstAndSecond);
                yield return new TestCaseData(Criterion1Enum.Second, Criterion2Enum.Second, Criterion3Enum.Third, StrategyTypeEnum.FirstAndSecond);
            }
        }
        
        [TestCaseSource(nameof(Cases))]
        public void Test1(Criterion1Enum criterion1, Criterion2Enum criterion2, Criterion3Enum criterion3, StrategyTypeEnum expectedStrategyType)
        {
            var result = _factory.GetStrategy(new Picker(criterion1, criterion2, criterion3));
            Assert.That(result.StrategyType, Is.EqualTo(expectedStrategyType));
        }

        [TestCaseSource(nameof(CasesWithDefault))]
        public void Test2(Criterion1Enum criterion1, Criterion2Enum criterion2, Criterion3Enum criterion3, StrategyTypeEnum expectedStrategyType)
        {
            var result = _factoryWithDefault.GetStrategyWithDefault(new Picker2(criterion1, criterion2, criterion3));
            Assert.That(result.StrategyType, Is.EqualTo(expectedStrategyType));
        }
    }
}