#include <iostream>
using namespace std;

 class matranvuong{
private:
	int **node;
	int size;

public:
	 matranvuong(){

	}
	void capPhat(){
		node= new int*[size];
		for(int i=0; i<size;++i) node[i]= new int[size];
		 
	} // end of capPhat

	void nhapMang()
{
	for (int i = 0; i < size; i++)
	{
		for (int j = 0; j < size; j++)
		{
			cout << "phan tu node[" << i << "][" << j << "]" << endl;
			cin >> node[i][j];
		}
	}
} // end of nhapMang


	void inMang()
	{
		cout << "mang sau khi nhap la:\n";
		for (int i = 0; i < size; i++)
		{
			for (int j = 0; j < size; j++)
			{
				cout << node[i][j]<<" ";
			}
			cout<<endl;
		}
		cout << endl;
	} // end of inMang

	void giaiPhong(){
		for(int i=0;i<3;i++) delete[] node[i];
	 delete[] node;
	}

	void setSize(int size){
		this->size = size;
	}
	int getSize(){
		return size;
	}

// Các hàm tính toán 
	int tongCheoChinh(){
		int sum=0;
		for(int i=0;i< size;i++){
			sum+=node[i][i];
		}
		return sum;
	}
	int tongCheoPhu(){
		int sum=0;
		for(int i=0;i< size;i++){
			sum+=node[i][size-i-1];	
		}
		return sum;
	}


}; // end of class matranvuong

 int main(){

	 matranvuong *matran = new matranvuong();
	matran->setSize(4);
	cout<< matran->getSize()<<endl;
	 matran->capPhat();
	 matran->nhapMang();
	 matran->inMang();
	 cout<<"dcmm";
	cout << matran->tongCheoChinh()<<endl;
	cout<< matran->tongCheoPhu();
	 matran->giaiPhong();

	 
}