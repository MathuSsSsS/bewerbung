#include <stdio.h>

int main() {
	double bruttogehalt;
	int verheiratet, kinder;
	float netto, steuersatz, heirat;
		
		scanf("%lf%d%d", &bruttogehalt, &verheiratet, &kinder);
		
		
		
		
		if (bruttogehalt <= 12000);
			{steuersatz = 0.12;
			}
		
		
		if (bruttogehalt <=20000);
			{if(bruttogehalt > 12000);
				steuersatz = 0.15;
			}
			
		if (bruttogehalt <= 30000);
			{if(bruttogehalt > 20000);
				steuersatz = 0.2;
			}
		
		if (bruttogehalt > 30000);
			{steuersatz = 0.25;
			}
					
		
		
		if (verheiratet < 0){
			printf("Eingabefehler\n");
			return 0;
		}
		
		if (verheiratet > 1){
		
			printf("Eingabefehler\n");	
			return 0;	
		}
		else {
			if (verheiratet == 1)
				heirat = 0.2;
			else
				heirat = 0;
			}
			
		if (kinder < 0){
		
			printf("Eingabefehler\n");
			return 0;
		}
			
		if (bruttogehalt < 0){
		
			printf("Eingabefehler\n");
			return 0;
		}
	
		
		netto = bruttogehalt * steuersatz * (1 - (heirat + kinder * 0.1));
	
		if (netto < 0)
			netto = (netto / netto) - 1;
		
		printf("%.2lf\n", netto);      
	
	return 0;
}
