package comcave;

import java.util.Collections;
import java.util.Vector;

public class Program {

	public static void main(String[] args) {
		
		Vector<Athleten> athletenVector = new Vector<Athleten>();
		athletenVector.add(new Athleten(3, "Medvedev", "Daniil", "Russia"));
		athletenVector.add(new Athleten(1, "Djokovic", "Novac", "Serbia"));
		athletenVector.add(new Athleten(2, "Alcaraz", "Carlos", "Spain"));
		athletenVector.add(new Athleten(4, "Federer", "Roger", "Switzerland"));
		athletenVector.add(new Athleten(5, "Osaka", "Naomi", "Japan"));
		athletenVector.add(new Athleten(6, "Nadal", "Rafael", "Spain"));
		athletenVector.add(new Athleten(7, "Williams", "Serena", "USA"));
		athletenVector.add(new Athleten(8, "Thiem", "Dominic", "Austria"));
		athletenVector.add(new Athleten(9, "Barty", "Ashleigh", "Australia"));
		athletenVector.add(new Athleten(10, "Zverev", "Alexander", "Germany"));
		athletenVector.add(new Athleten(11, "Swiatek", "Iga", "Poland"));
		athletenVector.add(new Athleten(12, "Rublev", "Andrey", "Russia"));
		athletenVector.add(new Athleten(13, "Tsitsipas", "Stefanos", "Greece"));
		athletenVector.add(new Athleten(14, "Halep", "Simona", "Romania"));
		athletenVector.add(new Athleten(15, "Pliskova", "Karolina", "Czech Republic"));
		athletenVector.add(new Athleten(16, "Berrettini", "Matteo", "Italy"));
		athletenVector.add(new Athleten(17, "Muguruza", "Garbiñe", "Spain"));
		athletenVector.add(new Athleten(18, "Auger-Aliassime", "Felix", "Canada"));
		athletenVector.add(new Athleten(19, "Medvedeva", "Anastasia", "Russia"));
		athletenVector.add(new Athleten(20, "Monfils", "Gaël", "France"));

		
		Collections.shuffle(athletenVector);
		
		for (int i = 0; i < athletenVector.size(); i++) {
			System.out.println( athletenVector.get(i) );
		}
		
		System.out.println();

		// Bubblesort deluxe
		for (int i = 0; i < athletenVector.size() - 1; i++) {
			for (int j = 0; j < athletenVector.size() - 1 - i; j++) {
				if( athletenVector.get(j).getRang() > (athletenVector.get(j+1).getRang()) ) {
					Athleten temp = athletenVector.get(j);
					athletenVector.set(j, athletenVector.get(j+1));
					athletenVector.set(j+1, temp);
				}
			}
		}
		
		for (int i = 0; i < athletenVector.size(); i++) {
			System.out.println( athletenVector.get(i) );
		}
		
	}
}


