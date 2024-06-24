public class expendedForm {

    // Diese Methode nimmt ein int als Parameter und gibt dieses als erweiterte Form zurück
    // z.B. input: 5021
    // output: 5000 + 20 + 1
    
    public static String expandedForm(int num)
    {
      
    String finalNumber = "";
    int teiler = 1000000000; 
    int a = 0;
      
    
    for(int i = 0; i <= 9; i++){
        a = num / teiler;
        a *= teiler;
        num -= a;
        if (a != 0){
        
        finalNumber += a + " + ";
        }
        teiler /= 10;
    }
    
    // Die letzten 3 Zeichen " + " aus dem String löschen
    return finalNumber.substring(0, finalNumber.length() - 3); 
      
    }
}
