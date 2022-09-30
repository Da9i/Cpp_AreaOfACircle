//calculating the area or circumference of a circle.
#include <iostream>
using namespace std;
float circle(float r, char ch)
{
	float area=0, circumference=0, pi=3.14;
	if(ch=='a')
	{
		area=pi*(r*r);
		return area;
	}
	else if(ch=='c')
	{
			circumference=2*pi*r;
			return circumference;
	}
	else
		cout<<"you enter wrong character .";
}
int main()
{
	float radius;
	char ch;
	cout<<"enter radius :";
	cin>>radius;
	cout<<"enter 'a' for area, or 'c' for circumference :";
	cin>>ch;
	cout<<"area/circumference of a circle ="<<circle(radius,ch);
	return 0;
}
