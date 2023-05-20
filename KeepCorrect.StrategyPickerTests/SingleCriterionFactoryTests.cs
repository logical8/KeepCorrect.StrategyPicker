using KeepCorrect.StrategyPicker;
using KeepCorrect.StrategyPickerTests.ExampleImplementation.SingleCriterion;
using NUnit.Framework;

namespace KeepCorrect.StrategyPickerTests
{
    public class SingleCriterionFactoryTests
    {
        private IFactory<ITestStrategy, StrategyTypeEnum> _factory;
        private IFactoryWithDefault<ITestStrategy, StrategyTypeEnum> _factoryWithDefault;
        
        [SetUp]
        public void Setup()
        {
            var strategies = new ITestStrategy[]
            {
                new TestStrategy2(),
                new TestStrategy1()
            };
            
            var strategiesWithDefault = new ITestStrategy[]
            {
                new TestStrategy2(),
                new TestStrategy1(),
                new TestStrategyDefault()
            };
            _factory = new Factory<ITestStrategy, StrategyTypeEnum>(strategies);
            _factoryWithDefault = new FactoryWithDefault<ITestStrategy, StrategyTypeEnum>(strategiesWithDefault);
        }
        
        [TestCase(StrategyTypeEnum.First)]
        [TestCase(StrategyTypeEnum.Second)]
        public void Test(StrategyTypeEnum expectedStrategyType)
        {
            var result = _factory.GetStrategy(expectedStrategyType);
            Assert.That(result.StrategyType, Is.EqualTo(expectedStrategyType));
        }

        [TestCase(StrategyTypeEnum.First)]
        [TestCase(StrategyTypeEnum.Second)]
        [TestCase(StrategyTypeEnum.Default)]
        public void TestWithDefault(StrategyTypeEnum expectedStrategyType)
        {
            var result = _factoryWithDefault.GetStrategyWithDefault(expectedStrategyType);
            Assert.That(result.StrategyType, Is.EqualTo(expectedStrategyType));
        }
    }
}