using Lab1;
using System.Diagnostics;
using System.Xml.Linq;

namespace Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() { //Sprawdzenie, czy jeœli co najmniej jeden przedmiot spe³nia ograniczenia, to zwrócono co najmniej 1 element
            Problem problem = new Problem(10, 1);
            Result result = problem.Solve(50);
            Debug.WriteLine(result);
            Assert.AreNotEqual(result.id.Count, 0);
        }

        [TestMethod]
        public void TestMethod2() { //Sprawdzenie, czy jeœli ¿aden przedmiot nie spe³nia ograniczeñ, to zwrócono puste rozwi¹zanie.
            Problem problem = new Problem(3, 1);
            problem.ForceItem(2, 4, 0);
            problem.ForceItem(5, 8, 1);
            problem.ForceItem(1, 3, 2);

            Result result = problem.Solve(2);
            Debug.WriteLine(result);

            Assert.AreEqual(result.sumWeight, 0);
            Assert.AreEqual(result.sumValue, 0);
            Assert.AreEqual(result.id.Count, 0);
        }

        [TestMethod]
        public void TestMethod3() { //Sprawdzenie, czy kolejnoœæ przedmiotów ma wp³ywa na znalezione rozwi¹zanie.
            Problem problem = new Problem(3, 1);
            problem.ForceItem(2, 1, 0);
            problem.ForceItem(5, 8, 1);
            problem.ForceItem(1, 3, 2);

            Problem problem2 = new Problem(3, 1);
            problem2.ForceItem(1, 3, 0);
            problem2.ForceItem(2, 1, 1);
            problem2.ForceItem(5, 8, 2);


            Result result = problem.Solve(5);
            Result result2 = problem2.Solve(5);

            Assert.AreEqual(result.sumValue, result2.sumValue);
            Assert.AreEqual(result.sumWeight, result2.sumWeight);
        }

        [TestMethod]
        public void TestMethod4() { //Sprawdzenie poprawnoœci wyniku dla konkretnej instancji.
            Problem problem = new Problem(3, 1);
            problem.ForceItem(2, 1, 0);
            problem.ForceItem(5, 8, 1);
            problem.ForceItem(1, 3, 2);

            Result result = problem.Solve(5);

            Assert.IsTrue(result.id.Contains(2));
            Assert.IsTrue(result.id.Contains(0));
            Assert.AreEqual(result.sumWeight, 4);
            Assert.AreEqual(result.sumValue, 3);
            Assert.AreEqual(result.id.Count, 2);
        }

        [TestMethod]
        public void TestMethod5() { //testowanie przypadku, gdy wszystkie przedmioty sie zmieszcza
            Problem problem = new Problem(3, 1);
            problem.ForceItem(2, 1, 0);
            problem.ForceItem(5, 8, 1);
            problem.ForceItem(1, 3, 2);

            Result result = problem.Solve(12);
            Debug.WriteLine(result);

            Assert.AreEqual(result.sumWeight, 12);
            Assert.AreEqual(result.sumValue, 8);
            Assert.AreEqual(result.id.Count, 3);

        }

        [TestMethod]
        public void TestMethod6() { //testowanie przypadku, gdy capacity = 0
            Problem problem = new Problem(3, 1);
            problem.ForceItem(2, 4, 0);
            problem.ForceItem(5, 8, 1);
            problem.ForceItem(1, 3, 2);

            Result result = problem.Solve(0);
            Debug.WriteLine(result);

            Assert.AreEqual(result.sumWeight, 0);
            Assert.AreEqual(result.sumValue, 0);
            Assert.AreEqual(result.id.Count, 0);
        }

        [TestMethod]
        public void TestMethod7() { // Testowanie przypadku, gdy tylko jeden przedmiot jest dostêpny:
            Problem problem = new Problem(1, 1);
            problem.ForceItem(5, 3, 0);

            Result result = problem.Solve(6); 

            Assert.AreEqual(5, result.sumValue);
            Assert.AreEqual(3, result.sumWeight);
            Assert.AreEqual(1, result.id.Count);
        }

        [TestMethod]
        public void TestMethod8() { // przedmioty maja 0 wartoœæ
            Problem problem = new Problem(3, 1);
            problem.ForceItem(0, 5, 0);
            problem.ForceItem(0, 7, 1);
            problem.ForceItem(0, 3, 2);

            Result result = problem.Solve(10);

            Assert.AreEqual(0, result.sumValue);
            Assert.AreEqual(0, result.sumWeight);
            Assert.AreEqual(0, result.id.Count);
        }
    }
}