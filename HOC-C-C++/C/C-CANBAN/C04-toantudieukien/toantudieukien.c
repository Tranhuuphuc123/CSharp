#include<stdio.h>
int main() {
	int a, b;
	printf("nhap vao gia tri a: ");
	scanf_s("%d", &a);
	printf("nhap vao gia tri b: ");
	scanf_s("%d", &b);

	printf("\n");
	printf("---ket qua------\n");

	printf("ket qua: (%d>=%d) kq la: %s",a,b,(a >= b) ? "true" : "false");
	printf("\n");
	// phai gangs gia tri a, b vao truoc lenh moi thuc thi duoc phep toan so sanh (a>b)
	// roi moi tiep tuc so sanh dieu kien a co lon hon b de ra kq true hay false.

	printf("phep tinh: so %d la so '%s' ", a, (a % 2 == 0) ? "chan~" : "le~");
	printf("\n");
	printf("phep tinh: so %d la so '%s'", b, (b % 2 == 0) ? "chan~" : "le~");
	return 0;
}