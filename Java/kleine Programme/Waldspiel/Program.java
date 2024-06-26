
public class Program {

	public static void main(String[] args) {
		
		DialogString.gameStart();
		
		Encounter encounter = new Encounter();
		
        while (true) {
            encounter = new Encounter().spawnEncounter(); 
            if (LifePoints.getLifePoints() <= 0) {
                encounter.gameOver();
                break;
            }
            encounter.decision(); 
        }
	}
}

