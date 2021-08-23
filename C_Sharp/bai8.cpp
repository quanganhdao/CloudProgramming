#include <iostream>
using namespace std;

 class Matran{
private:
	int **node;
	int column, row;

public:
	 Matran(){

	}
	void capPhat(){
		node= new int*[column];
		for(int i=0; i<column;++i) node[i]= new int[row];
		 
	} // end of capPhat

	void nhapMang()
{
	for (int i = 0; i < column; i++)
	{
		for (int j = 0; j < row; j++)
		{
			cout << "phan tu node[" << i << "][" << j << "]" << endl;
			cin >> node[i][j];
		}
	}
} // end of nhapMang


	void inMang()
	{
		cout << "mang sau khi nhap la:\n";
		for (int i = 0; i < column; i++)
		{
			for (int j = 0; j < row; j++)
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

	void setSize(int column, int row){
		this->column = column;
		this->row = row;
	}
	//  string  getSize(){
	// 	 return column + "x" + row;
	//  }

// Các hàm tính toán 
	
	int sumOfEdges(){
		int sum=0;
		for(int i=0; i <column; i++){
			sum+=node[i][0]+node[i][row-1];
		}

		for(int i=0; i <row; i++){
			sum+= node[0][i]+node[column-1][i];
		}
		sum=sum -node[0][0]-node[0][row-1]-node[column-1][0] - node[column-1][row-1];
		return sum;
	}


}; // end of class Matran

 int main(){
int temp;
	 Matran *matran = new Matran();
	matran->setSize(4,5);
	// cout<< matran->getSize()<<endl;
	 matran->capPhat();
	 matran->nhapMang();
	 matran->inMang();
	//  cout<< matran->getSize()<<endl;
	 cout<<"tong tren 4 duong vien la: ";
	 cout<<matran->sumOfEdges();
	 
	 matran->giaiPhong();

	 
}
