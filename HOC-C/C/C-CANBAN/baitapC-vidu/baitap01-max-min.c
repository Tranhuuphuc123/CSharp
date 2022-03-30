#include<stdio.h>

int main() {

	int a, b;
	int max, min;

	printf("nhap vao gia tri a: ");
	scanf_s("%d", &a);
	printf("nhap vao gia tri b: ");
	scanf_s("%d", &b);
	printf("\n");

	// ham xu ly 

	max = (a > b) ? a : b;
	min = (a < b) ? a : b;

	printf("MAX so lon nhat la: %d", max);
	printf("\n");
	printf("MIN so nho nhat la: %d", min);

	return 0;

}