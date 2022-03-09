using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using System;
using static TestImages.TC001_Rev1;

namespace TC001_Rev1
{
    [TestCase(1)]
    public class TryToPublishThis
    {
        [SetupTest]
        public bool Setup(ITester t)
        {
            return true;
        }

        [PreconditionStep]
        public void PreconditionStep(ITester t)
        {
            t.Report.FailStep("REPLACE_OR_DELETE_ME");
        }

        [TestStep(1,
            TestInput = "TestInput1",
            ExpectedResults = "Expected1")]
        public void Step1(ITester t)
        {
            t.Report.FailStep("REPLACE_ME");
        }

        [CleanupStep]
        public void Step2(ITester t)
        {
            t.Report.FailStep("REPLACE_OR_DELETE_ME");
        }

        [TearDownTest]
        public bool TearDown(ITester t)
        {
            return true;
        }
    }
}
