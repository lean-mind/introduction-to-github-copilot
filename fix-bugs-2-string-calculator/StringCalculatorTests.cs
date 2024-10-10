namespace fix_bugs_2_string_calculator;

public class StringCalculatorTests
{
    public class HappyPath
    {
        [Fact]
        public void Add_SingleNumber_ReturnsSameNumber()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("5");
            Assert.Equal("5", result);
        }

        [Fact]
        public void Add_TwoNumbersSeparatedByComma_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.Equal("3", result);
        }

        [Fact]
        public void Add_MultipleNumbersSeparatedByComma_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4");
            Assert.Equal("10", result);
        }

        [Fact]
        public void Add_NumbersSeparatedByNewline_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1\n2\n3");
            Assert.Equal("6", result);
        }

        [Fact]
        public void Add_CustomDelimiter_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("//;\n1;2");
            Assert.Equal("3", result);
        }
    }

    public class EdgeCases
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("");
            Assert.Equal("0", result);
        }
        
        [Fact]
        public void Add_InvalidNewlineSeparator_ReturnsErrorMessage()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("175.2,\n35");
            Assert.Equal("Number expected but '\\n' found at position 6.", result);
        }

        [Fact]
        public void Add_MissingNumberInLastPosition_ReturnsErrorMessage()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,3,");
            Assert.Equal("Number expected but EOF found.", result);
        }

        [Fact]
        public void Add_CustomDelimiterWithInvalidSeparator_ReturnsErrorMessage()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("//|\n1|2,3");
            Assert.Equal("'|' expected but ',' found at position 3.", result);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsErrorMessage()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("-1,2");
            Assert.Equal("Negative not allowed : -1", result);
        }

        [Fact]
        public void Add_MultipleNegativeNumbers_ReturnsErrorMessage()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("2,-4,-5");
            Assert.Equal("Negative not allowed : -4, -5", result);
        }

        [Fact]
        public void Add_MultipleErrors_ReturnsAllErrorMessages()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("-1,,2");
            Assert.Equal("Negative not allowed : -1\nNumber expected but ',' found at position 3.", result);
        }
    }
}