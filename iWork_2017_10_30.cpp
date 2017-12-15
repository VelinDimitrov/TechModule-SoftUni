// Задача за самостоятелно упражнение от 30.10.2017 г.
#include <iostream>
using namespace std;
bool Correct(int year, int month, int date) {
  switch (month) {
    case 4: case 6: case 9: case 11:
      return 1 <= date && date <= 30;
    case 2:
      return 1<=date && date<= 28+(year%400==0 || year%100 && year%4==0);
    default:
      return 1<=month && month<=12 && 1<=date && date<=31;
  }
}
int main(){
  //system("chcp 1251");
  int y,m,d;
  cout<<"Въведете година: "; cin>>y;
  cout<<"Въведете месец: "; cin>>m;
  cout<<"Въведете дата: "; cin>>d;
  cout<<"Датата е "<< (Correct(y, m, d) ? "правилна." : "неправилна.") <<"\n\n";

  //system("pause");
  return 0;
}
