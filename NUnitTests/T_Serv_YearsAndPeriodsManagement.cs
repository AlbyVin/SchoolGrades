using SchoolGrades.BusinessObjects;

namespace NUnitDbTests
{
    public class T_Serv_YearsAndPeriodsManagement
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void T_TableSchoolYears()
        {
            Test_Commons.dl.CreateTableSchoolYears();

            SchoolYear sy = new();
            sy.IdSchoolYear = "23-24";
            sy.Notes = "Anno di prova";
            sy.ShortDescription = "2023-2024";
            sy.Notes = "Anno scolastico introdotto per sola prova";
            Assert.That(!Test_Commons.dl.SchoolYearExists(sy.IdSchoolYear));
            Test_Commons.dl.AddSchoolYear(sy);
            Assert.That(Test_Commons.dl.SchoolYearExists(sy.IdSchoolYear));
            List<SchoolYear> list = Test_Commons.dl.GetSchoolYearsThatHaveClasses();
            // Assert the results
            // !!!! TODO

        }
    }
}