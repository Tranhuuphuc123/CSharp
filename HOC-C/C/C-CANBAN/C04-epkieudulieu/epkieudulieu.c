#include<stdio.h>
int main() {
	int a, b;
	// nhập liệu giá trị a, b kiểu tường ngầm định
	printf("nhap vao gia tr a: ");
	scanf_s("%d", &a);
	printf("nhap vao gia tri b: ");
	scanf_s("%d", &b);

	printf("\n\n");
	printf("------bien doi ep kieu sang float: dun cach nao cung dc-------\n");

	float tongSo = a / b;
	printf("\n");

	printf("ket qua ep kieu float: %d/%d = %.2f", a, b, tongSo);
	return 0;

	// nhap liệu kiểu tường minh thì ngược lại từ cao xuống thấp

}
