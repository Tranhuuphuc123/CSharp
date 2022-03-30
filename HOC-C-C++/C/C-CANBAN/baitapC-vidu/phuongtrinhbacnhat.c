// p/t bac nhat co dang ax +b = 0;
// ---> x=-b/a

#include<stdio.h>
int main() {
	float a, b, x;

	printf("tinh toan phuong trinh bac nhat: ax+b=0\n");

	printf("nhap vao gia tri a: ");
	scanf_s("%f", &a);
	printf("nhap vao gia tri b: ");
	scanf_s("%f", &b);

	x = -b / a;
	printf("\n");
	printf("ket qua p/t bac nhat: x = %.2f", x);
	return 0;
}