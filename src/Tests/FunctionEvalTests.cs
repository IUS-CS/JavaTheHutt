using Microsoft.VisualStudio.TestTools.UnitTesting;
using Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser.Tests
{
    [TestClass()]
    public class FunctionEvalTests
    {
        [TestMethod()]
        public void EvaluateTest()
        {
            FunctionEval fe = new FunctionEval();

            String s1 = "2*3*x";
            double result = fe.Evaluate(s1, 3);
            Assert.AreEqual(18, result);
        }

        [TestMethod()]
        public void EvaluateTest1()
        {
            FunctionEval fe = new FunctionEval();

            String s1 = "2*3*x^0";
            double result = fe.Evaluate(s1, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod()]
        public void EvaluateTest2()
        {
            FunctionEval fe = new FunctionEval();

            String s1 = "5*x^0";
            double result = fe.Evaluate(s1, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod()]
        public void EvaluateTest3()
        {
            FunctionEval fe = new FunctionEval();

            String s1 = "2*3+7-1";
            double result = fe.Evaluate(s1);
            Assert.AreEqual(12, result);
        }

        [TestMethod()]
        public void EvaluateTest4()
        {
            FunctionEval fe = new FunctionEval();

            String s1 = "2*3+7-1*1";
            double result = fe.Evaluate(s1);
            Assert.AreEqual(2 * 3 + 7 - 1 * 1, result);
        }

        [TestMethod()]
        public void EulerTest()
        {
            double epsilon = .01;
            double expected = 4.0;
            FunctionEval fe = new FunctionEval();

            double result = fe.Euler("2*x", 0, 0, 2);
            Boolean accurate = Math.Abs(result - expected) < epsilon;
            Assert.IsTrue(accurate);
        }

        [TestMethod()]
        public void EulerTest2()
        {
            double epsilon = .001;
            double expected = 8.0;
            FunctionEval fe = new FunctionEval();

            double result = fe.Euler("3*x^2", 0, 0, 2);
            Boolean accurate = Math.Abs(result - expected) < epsilon;
            Assert.IsTrue(accurate);
        }

        [TestMethod()]
        public void HeunTest()
        {
            double epsilon = .001;
            double expected = 4.0;
            FunctionEval fe = new FunctionEval();

            double result = fe.Euler("2*x", 0, 0, 2);
            Boolean accurate = Math.Abs(result - expected) < epsilon;
            Assert.IsTrue(accurate);
        }

        [TestMethod()]
        public void HeunTest2()
        {
            double epsilon = .001;
            double expected = 8.0;
            FunctionEval fe = new FunctionEval();

            double result = fe.Euler("3*x^2", 0, 0, 2);
            Boolean accurate = Math.Abs(result - expected) < epsilon;
            Assert.IsTrue(accurate);
        }

        [TestMethod()]
        public void HeunTest3()
        {
            double epsilon = .001;
            double expected = 2.0;
            FunctionEval fe = new FunctionEval();

            double result = fe.Euler("x", 0, 0, 2);
            Boolean accurate = Math.Abs(result - expected) < epsilon;
            Assert.IsTrue(accurate);
        }
    }
}