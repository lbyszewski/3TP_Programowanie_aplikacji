#include <iostream>
#include "Person.h"

using namespace std;


void func() {
    double result = 2.24 + 2.33;
    cout << result << endl;
    
}

int funcRet() {
    int result = 3 + 3;
    return result;
}


int main()
{
    // deklaracja zmiennych i wywo³anie
    int firstValue;

    cout << "podaj liczbe: " << endl;

    cin >> firstValue;

    cout << firstValue << "\n";

    // inicjalizacja i wywo³anie

    int secondValue = 5;


    // instrukcja warunkowa
    
    if (firstValue <= 0) {
        cout << "podana liczba nie spelnia wymagan"<<endl;
    }
    else{
        cout << "spelnia wymagania" << endl;
    }


    // petla for

    for (int i = 0; i < 10; i++)
    {
        cout << i << endl;
    }


    // funkcje i wywo³anie
    func();

    cout << "wynik dzialania funkcji drugiej to: " << funcRet() << endl;

    
    
    
    
    
    
    // obiektowoœæ - klasa, metoda, property, object, flags, constructors

    Person osoba;

    osoba.setFirstName("Lukasz");
    osoba.show();



    // paradygmaty programowania, wskaŸniki - agregacja







}


