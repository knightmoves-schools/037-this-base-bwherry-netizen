namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Set_The_Class_Level_Varaibles_FirstName_And_LastName_With_The_Constructer_Parameters_FirstName_And_LastName(){
      var person = new Person("mary", "smith");

      Assert.Equal("mary smith", person.FullName());
    }

    [Fact]
    public void Should_Return_The_Value_That_Is_Returned_From_The_Parent_Classes_Method_LookupTaxId_From_Within_The_LookUpId_Method(){
      var taxable = new Taxable();
      var person = new Person("", "");

      Assert.Equal(taxable.LookupTaxId(), person.LookUpId());
    }
}