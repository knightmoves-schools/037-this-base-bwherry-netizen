namespace knightmoves;

public class Person : Taxable {
   private string firstName;
   private string lastName;

   public Person(string firstName, string lastName){
      this.firstName = firstName;
      this.lastName = lastName;
   }

   public string FullName(){
      return $"{firstName} {lastName}";
   }

   public string LookUpId(){
      return base.LookupTaxId();
   }
}

public class Taxable {

   public string LookupTaxId(){
      return "testTaxId";
   }
}
