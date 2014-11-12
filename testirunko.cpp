#include <stdio.h>
#include "hlo.h"


int main(void) {
	int jee;
    Thlo henkilo, klooni;
    alusta_hlo(&henkilo, "Matti", 20);
    alusta_hlo(&klooni,"", 0);		
    tulosta_hlo(&henkilo);	// tulostetaan henkilo
    tulosta_hlo(&klooni);	// tulostetaan kloonausta varten alustettu klooni

    // kloonataan sijoituksella	       
    klooni = henkilo;
    tulosta_hlo(&henkilo);	// tulostetaan henkilo
    tulosta_hlo(&klooni);	// tulostetaan kloonattu klooni
             
    // kloonattu henkilö tarvitsee oman nimen
    muuta_nimi(&klooni, "Pekka");
    tulosta_hlo(&henkilo);	// tulostetaan henkilo
    tulosta_hlo(&klooni);	// tulostetaan klooni, jonka nimi vaihdettu 

	scanf_s("%d", &jee);
    return 0;
}
