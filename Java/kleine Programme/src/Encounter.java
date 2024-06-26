import java.util.Random;
import java.util.Scanner;

public class Encounter {
	

	private String name;
	private boolean feed;
	private boolean pet;
	private boolean hit;

	
	
	public Encounter spawnEncounter(){
		Random rand = new Random();
		int i = rand.nextInt(5);
		i += 1;
		
		switch (i) {
		case 1:
			return new Encounter("dem Förster", false, false, true);
		case 2:
			return new Encounter("dem Jeep vom Förster", false, false, false);
		case 3:
			return new Encounter("einem Krokodil", true, true, false);
		case 4:
			return new Encounter("einem Löwen", false, true, true);
		case 5:
			return new Encounter("einem Reh", false, false, false);
		case 6:
			return new Encounter("einem Pitbull (100kg Kampfgewicht)", false, false, true);
		case 7:
			return new Encounter("einem Drachen", false, true, true);
		case 8:
			return new Encounter("einer Ziege", true, false, true);
		case 9:
			return new Encounter("Olaf Scholz", false, false, false);
		default:
            return new Encounter("", false, false, false);
		}
	}
		
	public boolean decision() {
		DialogString.encounterQuestion();
		
		while(true) {
			int decision = new Scanner(System.in).nextInt();
			
				switch (decision) {
				case 1:
					if (this.pet == true) {
						DialogString.encounterResultBad(this.name);
					} else {
						DialogString.encounterResultGood(this.name);
					}
					return true;
				case 2:
					if (this.feed == true) {
						DialogString.encounterResultBad(this.name);
					} else {
						DialogString.encounterResultGood(this.name);
					}
					return true;
				case 3:
					if (this.hit == true) {
						DialogString.encounterResultBad(this.name);
					} else {
						DialogString.encounterResultGood(this.name);
					}
					return true;
	
				default:
					System.out.println("Falsche Eingabe. Bitte erneut eingeben: ");
				}
		}
	}
	
	//konstruktoren
	public Encounter() {
		
	}
	
	public Encounter(String name, boolean feed, boolean pet, boolean hit) {
		this.name = name;
		this.pet = pet;
		this.feed = feed;
		this.hit = hit;
	}
	
	//getter setter
	public void gameOver() {
		System.out.println("GAME OVER");
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public boolean isFeed() {
		return feed;
	}

	public void setFeed(boolean feed) {
		this.feed = feed;
	}

	public boolean isPet() {
		return pet;
	}

	public void setPet(boolean pet) {
		this.pet = pet;
	}

	public boolean isHit() {
		return hit;
	}

	public void setHit(boolean hit) {
		this.hit = hit;
	}
	
}

