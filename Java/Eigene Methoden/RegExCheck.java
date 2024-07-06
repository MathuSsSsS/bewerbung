public class RegExCheck {
	
	public static void main(String[] args) {
			// Methodenprüfer
			System.out.println(RegExCheck.isDatum("31.11.2011"));
		}
		
		public static boolean isDouble(String zahl) {
			String regExDouble = "-?[0-9.,]{1,8}";
					return zahl.matches(regExDouble);
		}
		
		public static boolean isUrl(String Url) {
			String regExUrl = "((http|https)://)?(www.)?[a-zA-Z0-9@:%\\+~#?&//=-]{​​2,256}​​\\.[a-z]{​​2,6}​​\\b([-a-zA-Z0-9@:%.\\+~#?&//=]*)";
			return Url.matches(regExUrl);
		}
		
		public static boolean isTelefon(String telefon) {
			String regExTelefon = "(((\\+|0{2})(\\d{2})\\s(\\d{4})\\s(\\d{6})|\\(?(0\\d{3,4})\\)?(-|\\s)(\\d{6}|\\d{7})))";
			return telefon.matches(regExTelefon);
		}
		
		public static boolean isPlz(String plz) {
			String regExPlz = "[0-9]{5}";
			return plz.matches(regExPlz);
		}
		
		public static boolean isDatum(String datum) {
			String regExDatum = "(0?[1-9]|[12][0-9]|3[01])\\.(0?[1-9]|1[0-2])\\.(19|20)[0-9]{2}";
			if(datum.matches( regExDatum )){
	        	String[] datumArray = datum.split("\\.");
	    		int tag = Integer.parseInt( datumArray[0] );
	    		int monat = Integer.parseInt( datumArray[1] );
	    		int jahr = Integer.parseInt( datumArray[2] );
	    		
	    		int maxTag = 30;
	    		if(monat != 2) {
	    			switch(monat) {
	    			case 1: case 3: case 5: case 7: case 8: case 10: case 12:
	    				maxTag = 31;
	    				break;
	    			}
	    		}else {
	    			// Schaltjahr?
	    			if((jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0)) {
	    				maxTag = 29;
	    			}else {
	    				maxTag = 28;
	    			}
	    		}
	    		return tag <= maxTag;
	        }
	        return false;
	        
		}
		
	}
