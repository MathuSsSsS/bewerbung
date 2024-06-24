#include <stdio.h>




int main() {

int eingabe, teiler, echteeingabe;


	scanf("%d", &eingabe);
	echteeingabe = eingabe;
	
	
		if(eingabe > 2){
			
			for(teiler = 2; teiler <= eingabe; teiler++){
				
				if(eingabe == teiler){
						if(eingabe == echteeingabe){
						printf("%d ist prim.\n", eingabe);
						return 0;
						}
				printf("%d\n", eingabe);
				return 0;
				}
				
					while(eingabe % teiler == 0){
						eingabe = eingabe / teiler;
					
					
/*						if(eingabe == teiler){
						printf("%d ist prim.\n", eingabe);
						return 0;
						}*/
					
					
					printf("%d\n", teiler);
				}		
				
				
				if(teiler >= eingabe){
					teiler = 2;
				}
			
				
			
			}
			
		}
		else {
		printf("%d kann nicht zerlegt werden.\n", eingabe);
		}
		
	

	return 0;
}

