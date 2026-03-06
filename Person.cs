namespace knightmoves;

public class Person : Taxable{
   private string firstName;
   private string lastName;

   public Person(string firstName, string lastName){
      //Add your code here
   }
   public string FullName(){
      return $"{firstName} {lastName}";
   }

   public string LookUpId(){
      return ""; //Add your code here
   }
}

public class Taxable{

   public string LookupTaxId(){
      return "testTaxId";
   }
}