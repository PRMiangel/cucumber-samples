namespace Calculator.Spec.Support
{
    using TechTalk.SpecFlow;

    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
        }

        [BeforeStep]
        public void BeforeStep()
        {
        }

        [AfterStep]
        public void AfterStep()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
        }

        [AfterFeature]
        public static void AfterFeature()
        {
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
        }
    }
}
