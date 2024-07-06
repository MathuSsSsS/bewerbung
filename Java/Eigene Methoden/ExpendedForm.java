
public class ExpendedForm {
	
	
	// Diese Methode bekommt einen Parameter vom typ int, rechnet die Zahl
	// in ihre erweiterte Form um und gibt das alles dann als String zurück
	
	public static String expandedForm(int num)
    {
      
      String fn = "";
      int teiler = 1000000000;
      int a = 0;
      

        for(int i = 0; i <= 9; i++){
          a = num / teiler;
          a *= teiler;
          num -= a;
          if (a != 0){
            
            fn += a + " + ";
          }
          teiler /= 10;
        }
      
      
      return fn.substring(0, fn.length() - 3); 
      
    }
	
}
