
public class DialogString {
	
	public static void gameStart() {
		System.out.println("Du bist in einem Wald und hast einen Wanderstab sowie einen Rucksack voll mit Eier-Tomaten-Gurken-Sandwiches.");
		System.out.println("Es ist sehr dunkel und du kannst kaum die Hand vor Deinen Augen sehen, als Dir plötzlich etwas begegnet. Du hast keine Ahnung, wer oder was es ist.");
	}
	
	public static void encounterQuestion() {
		System.out.println("Du begegenst etwas unbekannten. Was möchtest du tun? ");
		System.out.println("1 - Mit Eier-Tomaten-Gurken-Sandwich füttern");
		System.out.println("2 - Mit Liebe streicheln");
		System.out.println("3 - Mit einem Stock hauen");
	}
	
	public static void encounterResultGood(String name) {
		System.out.println("Gut Entschieden. Du bist " + name + " begegnet. Lebenspunkte: " + LifePoints.getLifePoints());
		System.out.println();
	}
	
	public static void encounterResultBad(String name) {
		LifePoints.setLifePoints(LifePoints.getLifePoints() - 1);
		System.out.println("Falsche Entscheidung. Du bist " + name + " begegnet. Lebenspunkte: " + LifePoints.getLifePoints());
		System.out.println();
	}
}
