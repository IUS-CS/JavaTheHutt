using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChemEqnBalancer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemEqnBalancer.Tests
{
	[TestClass()]
	public class EquationTests
	{
		[TestMethod()]
		public void EquationTest()
		{
			string s = "CO2 + H2O = C6H12O6 + O2";
			Equation e = new Equation(s);
			Assert.IsNotNull(e);
		}

		[TestMethod()]
		public void GetRightTest()
		{
			string s = "CO2 + H2O = C6H12O6 + O2";
			Equation e = new Equation(s);
			string[] expected = { "C6H12O6", "O2" };
			string[] result = e.GetRight();
			for(int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}

		[TestMethod()]
		public void GetLeftTest()
		{
			string s = "CO2 + H2O = C6H12O6 + O2";
			Equation e = new Equation(s);
			string[] expected = { "CO2", "H2O" };
			string[] result = e.GetLeft();
			for (int i = 0; i < expected.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}

		[TestMethod()]
		public void NumOccTest()
		{
			string s = "C C";
			string c = "C";
			Equation e = new Equation(s);
			int expected = 4;
			int result = e.NumOcc(s,c);
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void ParseTest()
		{
			string s = "CO2 + H2O = C6H12O6 + O2";
			Equation e = new Equation(s);
			string[,] expected = { {"C","O" },{"1","2" } };
			string[,] result = e.Parse("CO2");
			for (int i = 0; i < expected.GetLength(0); i++)
			{
				for (int j = 0; j < expected.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i,j], result[i,j]);
				}
			}
		}
	}
}