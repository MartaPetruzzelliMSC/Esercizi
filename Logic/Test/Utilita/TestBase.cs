using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Test.Utilita
{
    public class TestBase
    {
        protected int numeroDiTestEffettuati = 0;
        protected int numeroDiTestCorretti = 0;

        public TestBase()
        {
           numeroDiTestEffettuati = 0;
           numeroDiTestCorretti = 0;
        }

        protected void CompareValues(bool areValuesSame)
        {
            numeroDiTestEffettuati++;
            numeroDiTestCorretti += (areValuesSame ? 1 : 0);
        }

        protected void EseguiEAggiornaStatistiche<P, R>(string title, Func<P, R> myFunc, Func<P, R> sistema, P value1, Func<R, R, bool> equals = null)
        {
            var myRet = myFunc(value1);
            var sysRet = sistema(value1);
            var check = equals == null ? myRet.Equals(sysRet) : equals(myRet,sysRet);
            var successString = check ? "PASSED" : "FAILED";
            var displayValue1 = typeof(P).IsArray ? "array" : value1?.ToString();
            Console.WriteLine($"{title}: values: {displayValue1} - {successString}");
            CompareValues(check);
        }

        protected void EseguiEAggiornaStatistiche<E, P, R>(string title, Func<E, P, R> myFunc, Func<E, P, R> sistema, E value1, P value2, Func<R, R, bool> equals = null)
        {
            var myRet = myFunc(value1, value2);
            var sysRet = sistema(value1, value2);
            var check = equals == null ? myRet.Equals(sysRet) : equals(myRet, sysRet);
            var successString = check ? "PASSED" : "FAILED";
            var displayValue1 = typeof(E).IsArray ? "array" : value1?.ToString();
            var displayValue2 = typeof(P).IsArray ? "array" : value2?.ToString();
            Console.WriteLine($"{title}, values: {displayValue1}, {displayValue2} - {successString}");
            CompareValues(check);
        }

        protected void EseguiEAggiornaStatistiche<E, P, Q, R>(string title, Func<E, P, Q, R> myFunc, Func<E, P, Q, R> sistema, E value1, P value2, Q value3, Func<R, R, bool> equals = null)
        {
            var myRet = myFunc(value1, value2, value3);
            var sysRet = sistema(value1, value2, value3);
            var check = equals == null ? myRet.Equals(sysRet) : equals(myRet, sysRet);
            var displayValue1 = typeof(E).IsArray ? "array" : value1?.ToString();
            var displayValue2 = typeof(P).IsArray ? "array" : value2?.ToString();
            var displayValue3 = typeof(Q).IsArray ? "array" : value3?.ToString();
            var successString = check ? "PASSED" : "FAILED";
            Console.WriteLine($"{title}, values: {displayValue1}, {displayValue2}, {displayValue3} - {successString}");
            CompareValues(check);
        }
    }
}
