#include<stdio.h>
int main() {
	int a, b;

	printf("nhap vao gia tri a: ");
	scanf_s("%d", &a);
	printf("nhap vao gia tri b: ");
	scanf_s("%d", &b);

	printf("\n\n");
	printf("------------------------");

	printf("\n so sanh %d==%d kq la %d", a, b, a == b);
	printf("\n so sanh %d > %d kq la %d", a, b, a > b);
	printf("\n so sanh %d < %d kq la %d", a, b, a < b);
	printf("\n so sanh %d # %d kq la %d", a, b, a != b);
	printf("\n so sanh %d >= %d kq la %d", a, b, a >= b);
	printf("\n so sanh %d <= %d kq la %d", a, b, a <= b);

	return 0;
}