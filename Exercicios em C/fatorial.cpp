#include<stdio.h>
#include<locale.h>

int main(){
	
	setlocale(LC_ALL, "Portuguese");
	
	int i, j, fat[5], vet[5];
	
	for(i = 0; i < 5; i++){
		printf("Digite o numero %d:", i + 1);
		scanf("%d", &vet[i]);
	}
	
	for(i = 0; i < 5; i++){
		fat[i] = 1;
		
		for(j = 1; j <= vet[i]; j++){
			fat[i] = fat[i] * j;
		}
	}
	
	printf("Primeiro vetor:\n ");
	for(i = 0; i < 5; i++){
	printf("\t%d", vet[i]);
	
	
	}
	
	printf("\n Vetor em fatorial: \n");
	for(i = 0; i < 5; i++){
		printf("\t%d", fat[i]);
		
	}
	
	return 0;
}
