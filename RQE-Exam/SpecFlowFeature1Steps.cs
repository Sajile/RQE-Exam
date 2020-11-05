using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQE_Exam
{
    
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double firstNumber, calculatedNumber;
        [Given(@"the first number is PI")]
        public void GivenTheFirstNumberIsPI()
        {
            firstNumber = Math.PI;
        }
        
        [Given(@"the chosen function is sinus")]
        public void GivenTheChosenFunctionIsSinus()
        {
            calculatedNumber = Math.Sin(firstNumber);
        }
        
        [Given(@"the chosen function is cosinus")]
        public void GivenTheChosenFunctionIsCosinus()
        {
            calculatedNumber = Math.Cos(firstNumber);
        }
        
        [Given(@"the chosen function is tangens")]
        public void GivenTheChosenFunctionIsTangens()
        {
            calculatedNumber = Math.Tan(firstNumber);
        }
        
        [When(@"this combinatin is choosen")]
        public void WhenThisCombinatinIsChoosen()
        {
 
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            int expected = p0;
            double actual = calculatedNumber;
            Assert.Equal(expected,actual,5);
        }
    }
}
