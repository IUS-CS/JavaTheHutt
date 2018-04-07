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
		public void indexOfTest()//array
		{
			String s = "CO2 + H2O = C6H12O6 + O2";
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			string[] s1 = { "Thing1", "thing2", "last" };
			string s2 = "last";
			int expected = 2;
			int result = cm.indexOf(s1, s2);
			Assert.AreEqual(expected, result);
		}

		public void indexOfTesta()//array
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
		public void indexOfTest1()//matrix
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
		public void indexOfTest1a()//matrix
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
			double[,] m = { { 1, 7, 9 }, { 0, 5, 8 } };
			ChemEqnMatrix cm = new ChemEqnMatrix(s);
			double[] expected = {0, 0,0,1};
			double[] result = cm.GetAdjunctCol();
			//Assert.AreEqual(expected[0], result[0]);
			//Assert.AreEqual(expected[1], result[1]);
			//Assert.AreEqual(expected[2], result[2]);
			//Assert.AreEqual(expected[3], result[3]);
			
			for(int i = 0; i < result.Length; i++)
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
		public void BalanceTest()
		{
			String s1 = "CO2 + H2O = C6H12O6 + O2";
			String expected = "6CO2 + 6H2O = C6H12O6 + 6O2";
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
			//fix
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