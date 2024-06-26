package comcave;

public class Athleten {
	
	private int rang;
	private String nachname;
	private String vorname;
	private String nation;
	
	// von Object toString überschreiben
	@Override
	public String toString() {
		return this.rang + " " + this.nachname + " " + this.vorname + " " + this.nation;
	}

	public Athleten(int rang, String nachname, String vorname, String nation) {
		super();
		this.rang = rang;
		this.nachname = nachname;
		this.vorname = vorname;
		this.nation = nation;
	}

	public int getRang() {
		return rang;
	}

	public void setRang(int rang) {
		this.rang = rang;
	}

	public String getNachname() {
		return nachname;
	}

	public void setNachname(String nachname) {
		this.nachname = nachname;
	}

	public String getVorname() {
		return vorname;
	}

	public void setVorname(String vorname) {
		this.vorname = vorname;
	}

	public String getNation() {
		return nation;
	}

	public void setNation(String nation) {
		this.nation = nation;
	}
	
	
	
	
	
}
