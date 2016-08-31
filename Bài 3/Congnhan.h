#include <stdio.h>

#include <string.h>
#include <iostream>
using namespace std;

class Cong_nhan: public Nhan_vien {
private:
	int luong;
	int ngay_cong;
public:
	Cong_nhan () {
		
	}
	Cong_nhan(int x,int y){
		luong = x;
		ngay_cong = y;
	}
	void Nhap1(){
		Nhap();
		cout<< " Luong cua cong nhan la: ";
		cin>> luong;
		cout<< " Ngay cong cua cong nhan la: ";
		cin>> ngay_cong;
	}	
	void Hien_thi1() {
		Hien_thi();
		cout<< " Luong : " << luong << endl;
		cout<< " Ngay cong: " << ngay_cong << endl;
	}
	int Tinh_luong1() {
		int Tong;
		Tong = (int)((luong * ngay_cong) / 26);
		return Tong;
	}
		
};
