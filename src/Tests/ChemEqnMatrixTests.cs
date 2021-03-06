﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChemEqnBalancer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemEqnBalancer.Tests
{
	[TestClass()]
	public class ChemEqnMatrixTests
	{
		[TestMethod()]
		public void ChemEqnMatrixTest()
		{
			double[,] m = { { 1, 0 }, { 0, 5 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			Assert.IsNotNull(cm);
		}

		[TestMethod()]
		public void ChemEqnMatrixTest1()//string
		{
			String s1 = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			Assert.IsNotNull(cm);
		}

		[TestMethod()]
		public void indexOfTesta()//array
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			string[] s1 = { "Thing1", "thing2", "last" };
			string s2 = "last";
			int expected = 2;
			int result = cm.indexOf(s1, s2);
			Assert.AreEqual(expected, result);
		}

		public void indexOfTesta1()//array
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			string[] s1 = { "Thing1", "thing2", "last" };
			string s2 = "Thing1";
			int expected = 0;
			int result = cm.indexOf(s1, s2);
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void indexOfTestm()//matrix
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			string[,] s1 = { { "Thing1", "thing2", "last" },{ "5", "3", "1" } };
			string s2 = "Thing1";
			int expected = 0;
			int result = cm.indexOf(s1, s2);
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void indexOfTestm1()//matrix
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			string[,] s1 = { { "Thing1", "thing2", "last" }, { "5", "3", "1" } };
			string s2 = "last";
			int expected = 2;
			int result = cm.indexOf(s1, s2);
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void GetAdjunctColTest()
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			double[] expected = {0, 0, 0, 1};
			double[] result = cm.GetAdjunctCol();
			
			for(int i = 0; i < result.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}

		[TestMethod()]
		public void GetAdjunctColTest1()
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			cm.Balance();
			double[] expected = { 1, 1, 1, 1 };
			double[] result = cm.GetAdjunctCol();

			for (int i = 0; i < result.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}

		[TestMethod()]
		public void GetDiagonalTest()
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			double[] expected = { 1, 1, -12, 0 };
			double[] result = cm.GetDiagonal();
			for (int i = 0; i < result.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}

		[TestMethod()]
		public void GetDiagonalTest1()
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			cm.Balance();
			double[] expected = { 1, 1, 6, 1 };
			double[] result = cm.GetDiagonal();
			for (int i = 0; i < result.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}

		[TestMethod()]
		public void GetLCMDiagonalTest()
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			cm.Balance();
			double expected = 6;
			double result = cm.GetLCMDiagonal();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void GetLCMDiagonalTest1()
		{
			String s = "CHCl3 + O2 = CO2 + H2O + Cl2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			cm.Balance();
			double expected = 4;
			double result = cm.GetLCMDiagonal();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void DetermineCoefficientsTest()
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			cm.Balance();
			int[] expected = { 6, 6, 1, 6 };
			int[] result = cm.DetermineCoefficients();
			for (int i = 0; i < result.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}

		[TestMethod()]
		public void DetermineCoefficientsTest1()
		{
			String s = "CHCl3 + O2 = CO2 + H2O + Cl2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			cm.Balance();
			int[] expected = { 4, 5, 4, 2, 6 };
			int[] result = cm.DetermineCoefficients();
			for (int i = 0; i < result.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}

		[TestMethod()]
		public void DetermineCoefficientsTest2()
		{
			String s = "C6HOF2Ne = C3HOFNe + C";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			cm.Balance();
			int[] expected = { 1, 1, 0 };
			int[] result = cm.DetermineCoefficients();
			for (int i = 0; i < result.Length; i++)
			{
				Assert.AreEqual(expected[i], result[i]);
			}
		}



		[TestMethod()]
		public void InsertCoeffTest()
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			int[] setup = { 6, 6, 1, 6 };
			string expected = "6CO2 + 6H2O = C6H12O6 + 6O2";
			string result = cm.InsertCoeff(setup);
			
			Assert.AreEqual(expected, result);
			
		}

		[TestMethod()]
		public void InsertCoeffTest1()
		{
			String s = "C6HOF2Ne = C3HOFNe + C";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			int[] setup = { 1, 1, 0 };
			string expected = "No solution";
			string result = cm.InsertCoeff(setup);

			Assert.AreEqual(expected, result);

		}

		[TestMethod()]
		public void BalanceTest()
		{
			String s1 = "CO2 + H2O = C6H12O6 + O2";
			String expected = "6CO2 + 6H2O = C6H12O6 + 6O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.Balance();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BalanceTest1()
		{
			String s1 = "CO2 + H2O2 = C6H12O6 + O2";
			String expected = "6CO2 + 6H2O2 = C6H12O6 + 9O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.Balance();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BalanceTest2()
		{
			String s1 = "C6H12O6 + O2 = CO2 + H2O";
			String expected = "C6H12O6 + 6O2 = 6CO2 + 6H2O";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.Balance();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BalanceTest3()
		{
			String s1 = "H2O6 = O2 + H2";
			String expected = "H2O6 = 3O2 + H2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.Balance();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BalanceTest4()
		{
			String s1 = "CHOFNe = CHOFNe";
			String expected = "CHOFNe = CHOFNe";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.Balance();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BalanceTest5()
		{
			String s1 = "C6HOF2Ne = C3HOFNe + C";
			String expected = "No solution";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.Balance();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BalanceTest6()
		{
			String s1 = "CHCl3 + O2 = CO2 + H2O + Cl2";
			String expected = "4CHCl3 + 5O2 = 4CO2 + 2H2O + 6Cl2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.Balance();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void BalanceTest7()
		{
			String s1 = "CuN2O6 + NO + H2O = Cu + HNO3";
			String expected = "3CuN2O6 + 2NO + 4H2O = 3Cu + 8HNO3";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.Balance();
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void SwapRowsTest()
		{
			//matrix property needs to be set to public for this
			double[,] m = { { 1, 7, 9 }, { 6, 4, 3 }, { 0, 5, 8 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double[,] expected = { { 0, 5, 8 }, { 6, 4, 3 }, { 1, 7, 9 } };
			cm.SwapRows(0, 2);
			for(int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i,j], cm.matrix[i,j]);
				}
			}


		}

		[TestMethod()]
		public void FindAndSwapTest()
		{
			//matrix property needs to be set to public for this
			double[,] m = { { 0, 5, 8 }, { 6, 4, 3 }, { 1, 7, 9 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double[,] expected = { { 1, 7, 9 }, { 6, 4, 3 }, { 0, 5, 8 } };
			cm.FindAndSwap(0);
			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i, j], cm.matrix[i, j]);
				}
			}
		}

		[TestMethod()]
		public void FindAndSwapTest1()
		{
			//matrix property needs to be set to public for this
			double[,] m = { { 6, 4, 3 }, { 0, 5, 8 }, { 1, 7, 9 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double[,] expected = { { 1, 7, 9 }, { 0, 5, 8 }, { 6, 4, 3 } };
			cm.FindAndSwap(0);
			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i, j], cm.matrix[i, j]);
				}
			}
		}

		[TestMethod()]
		public void FindAndSwapTest2()
		{
			//matrix property needs to be set to public for this
			double[,] m = { { 6, 4, 3 }, { 1, 7, 9 }, { 0, 5, 8 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double[,] expected = { { 1, 7, 9 }, { 6, 4, 3 }, { 0, 5, 8 } };
			cm.FindAndSwap(0);
			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i, j], cm.matrix[i, j]);
				}
			}
		}

		[TestMethod()]
		public void FindScalarsTest()
		{
			String s1 = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			double[] expected = { 1, 2 };
			double[] results = cm.FindScalars(0,1);
			for (int j = 0; j < 2; j++)
			{
				Assert.AreEqual(expected[ j], results[ j]);
			}
		}


		[TestMethod()]
		public void GCDofRowTest()
		{
			double[,] m = { { 0, 5, 8 }, { 6, 4, 3 }, { 1, 7, 9 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double expected = 1;
			double results = cm.GCDofRow(1);

			Assert.AreEqual(expected, results);
				
			
		}
		[TestMethod()]
		public void GCDofRowTest1()
		{
			double[,] m = { { 0, 5, 8 }, { 12, 9, 3 }, { 1, 7, 9 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double expected = 3;
			double results = cm.GCDofRow(1);
			Assert.AreEqual(expected, results);
		}

		[TestMethod()]
		public void ToLowestTermsRTest()
		{
			//matrix field needs to be public
			double[,] m = { { 12, 4, 8 }, { 12, 9, 3 }, { 1, 7, 9 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double[] expected = { 3, 1, 2 };
			cm.ToLowestTermsR(0);
			for (int j = 0; j < expected.Length; j++)
			{
				Assert.AreEqual(expected[j], cm.matrix[0,j]);
			}
		}

		[TestMethod()]
		public void GetSignsTest()
		{
			double[,] m = { { 12, 4, 8 }, { -12, 9, 3 }, { 1, 7, 9 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			int[] expected = { 1, -1, 1 };
			int[] results = cm.GetSigns();
			for (int j = 0; j < expected.Length; j++)
			{
				Assert.AreEqual(expected[j], results[ j]);
			}
		}

		[TestMethod()]
		public void ToPositiveTest()
		{
			double[,] m = { { 0, 5, 8 }, { -6, 4, -3 }, { 1, -7, 9 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double[,] expected = { { 0, 5, 8 }, { 6, -4, 3 }, { 1, -7, 9 } };
			cm.ToPositive();
			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i, j], cm.matrix[i, j]);
				}
			}
		}

		[TestMethod()]
		public void ToLowestTermsMTest()
		{
			double[,] m = { { 1, 5, 8 }, { 6, 12, 3 }, { 12, 14, 8 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(m);
			double[,] expected = { { 1, 5, 8 }, { 2, 4, 1 }, { 6, 7, 4 } };
			cm.ToLowestTermsM();
			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i, j], cm.matrix[i, j]);
				}
			}
		}

		[TestMethod()]
		public void SolveMatrixTest()
		{
			String s1 = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			cm.SolveMatrix();
			double[,] expected = { { 1, 0, 0, 0, 1 }, { 0, 1, 0, 0, 1 }, { 0, 0, 6, 0, 1 }, { 0, 0, 0, 1, 1 } };
			for (int i = 0; i < cm.matrix.GetLength(0); i++)
			{
				for (int j = 0; j < cm.matrix.GetLength(1); j++)
				{
					Assert.AreEqual(expected[i, j], cm.matrix[i, j]);
				}
			}
		}

		[TestMethod()]
		public void FindPositionalScalarsTest()
		{
			String s1 = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			double[] expected = { 1, 0 };
			double[] results = cm.FindPositionalScalars(1, 0);
			for (int j = 0; j < 2; j++)
			{
				Assert.AreEqual(expected[j], results[j]);
			}
		}

		[TestMethod()]
		public void ToStringArrangedTest()
		{
			String s1 = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.ToStringArranged();
			string expected = "1 0 -6 0 0 \n2 1 -6 -2 0 \n0 2 -12 0 0 \n1 0 0 0 1 \n";
			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void ToStringTest()
		{
			String s1 = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s1);
			string result = cm.ToString();
			string expected = "1 0 -6 0 0 2 1 -6 -2 0 0 2 -12 0 0 1 0 0 0 1 ";
			
			Assert.AreEqual(expected, result);
			
		}
	}
}