#include <stdio.h>

int main() {
	int J, a, b, c, k, p, q, M, d, N, e, Ostern, z, y, x, w;
	
		scanf("%d", &J);
		
		a = J % 19;
		b = J % 4;
		c = J % 7;
		k = J / 100;
		p = (8 * k +13) / 25;
		q = k / 4;
		M = (15 + k - p - q) % 30;
		d = (19 * a + M) % 30;
		N = (4 + k - q) % 7;
		e = (2 * b + 4 * c + 6 * d + N) % 7;
		Ostern = (22 + d + e);
	
		z = (Ostern > 31);
		M = 3 + z;
		y = (M > 3);
		x = 31;
		w = x * y;
		Ostern = Ostern - w;
		
		
		

		printf("%02d.%02d.%04d\n", Ostern, M, J);	
	
	return 0;
}
