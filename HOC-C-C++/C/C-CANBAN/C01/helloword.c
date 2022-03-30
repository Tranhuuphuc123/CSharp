#include<stdio.h>
int main() {
	int x;
	float y;
	char c;
	 printf("nhap vao 1 chu cai: ");
	 scanf_s("%c", &c);

	printf("nhap vao gia tri x: ");
	scanf_s("%d", &x);
	
	 printf("nhap vao so: ");
	 scanf_s("%f", &y);

	 printf("gia tri x :%d\n diemso y:%.2f\n chu cai: %c", x, y, c);

	 // nhập nhiều giá trị trên 1 hàng

	 int x1, x2,x3;
	 printf("nhap vào giá trị x, x2, x3 lan luot la:");
	 scanf_s("%d%d%d",&x1,&x2,&x3);

	 printf("xuat ra: x1=%d, x2=%d, x=%d", x1, x2, x3);

	 return 0;
}
			