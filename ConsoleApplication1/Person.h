#pragma once

#include <iostream>

using namespace std;


class Person
{
public:
	string firstName;
	string lastName;
	Person(){}
	Person(string f, string l) {
		this->firstName = f;
		this->lastName = l;
	}

	void setFirstName(string f) {
		this->firstName = f;
	}

	

	string getFirstName() {
		return this->firstName;
	}


	void show() {
		cout << "hi my name is: " << this->getFirstName() << endl;
	}

};

