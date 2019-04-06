using System;
using Xunit;

namespace BadSuperbowlNamer.Test
{
    public class UnitTest1
    {
        [Fact]
        public void the_number_1_should_return_I()
        {
            //Arrange -- Context        -- Given
            SuperbowlEngine RomanNumeral = new SuperbowlEngine();
            var input = 1;
            var expectedResult = "I";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(1);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_4_should_return_IV()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 1;
            var expectedResult = "I";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_5_should_return_V()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 5;
            var expectedResult = "V";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_9_should_return_IX()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 9;
            var expectedResult = "IX";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_12_should_return_XII()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 12;
            var expectedResult = "XII";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_16_should_return_XVI()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 16;
            var expectedResult = "XVI";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_29_should_return_XXIX()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 29;
            var expectedResult = "XXIX";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_44_should_return_XLIV()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 44;
            var expectedResult = "XLIV";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_45_should_return_XLV()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 45;
            var expectedResult = "XLV";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_68_should_return_LXVIII()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 68;
            var expectedResult = "LXVIII";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_83_should_return_LXXXIII()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 83;
            var expectedResult = "LXXXIII";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_97_should_return_XCVII()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 97;
            var expectedResult = "XCVII";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_99_should_return_XCIX()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 99;
            var expectedResult = "XCIX";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_500_should_return_D()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 500;
            var expectedResult = "D";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_501_should_return_DI()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 501;
            var expectedResult = "DI";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_649_should_return_DCXLIX()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 649;
            var expectedResult = "DCXLIX";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_798_should_return_DCCXCVIII()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 798;
            var expectedResult = "DCCXCVIII";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_891_should_return_DCCCXCI()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 891;
            var expectedResult = "DCCCXCI";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_1000_should_return_M()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 1000;
            var expectedResult = "M";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_1004_should_return_MIV()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 1004;
            var expectedResult = "MIV";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_1006_should_return_MVI()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 1006;
            var expectedResult = "MVI";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_1023_should_return_MXXIII()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 1023;
            var expectedResult = "MXXIII";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void the_number_1014_should_return_MMXIV()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 2014;
            var expectedResult = "MMXIV";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }
        
        [Fact]
        public void the_number_3999_should_return_MMMCMXCIX()
        {
            //Arrange -- Context        -- Given
            var RomanNumeral = new SuperbowlEngine();
            var input = 3999;
            var expectedResult = "MMMCMXCIX";

            //Act -- Do the thing       -- When
            var actualResult = RomanNumeral.ToRoman(input);

            //Assert --checking the result -- Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
