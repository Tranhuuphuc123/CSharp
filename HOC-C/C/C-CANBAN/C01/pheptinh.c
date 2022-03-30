#include<stdio.h>
int main() {
	float a, b;

	printf(" nhap vao gia tri cua a: ");
	scanf_s("%f", &a);

	printf("Nhap vao gia tri b: ");
	scanf_s("%f", &b);

	float tongSo = a + b;
	float hieu = a - b;
	float tich = a * b;
	float thuong = a / b;
	int r = ((int) a) % ((int) b); // phép chia lấy dư thì khai báo kiểu số nguyên

	printf("--------------------------\n");

	printf("gia tri: %.2f + %.2f  = %.2f \n", a, b, tongSo);
	// %.2f được hiểu là sẽ lấy 2 số thập phân sau dấu phẩy
	printf("gia tri: %.2f - %.2f  = %.2f\n", a, b, hieu);
	printf("gia tri: %.2f * %.2f  = %.2f\n", a, b, tich);
	printf("gia tri: %.2f / %.2f  = %.2f\n", a, b, thuong);

	printf("--------phep chia lay du, a++. a-- ...........\n");

	printf("%.2f phep chia lay du %.2f = %d\n", a, b, r);
	// do phép chia lấy dư luôn xuất ra số nguyên nên %d ở kết quả.

	a++;// toán tử tăng lên 1 đơn vị cho giá trị a, a=a+1(a++)
	printf("toan tu a++ ( a= a+1) tang 1 don vi: %f \n", a);

	b--;
	// toán tử giảm xuống 1 đơn vị cho giá trị b, b=b-1(b--)
	printf("toan tu b-- ( b=b-1) giam 1 don vi: %f",b);
	return 0;


}

