#include <iostream>
#include <cmath>
#include <Windows.h>
using namespace std;

int main() 
{
    SetConsoleCP(1251);
    setlocale(0, "Russian");
    int choice;
    double a, b, result;

    do 
    {
        cout << "1. Сложение" << endl;
        cout << "2. Вычитание" << endl;
        cout << "3. Умножение" << endl;
        cout << "4. Деление" << endl;
        cout << "5. Возведение в степень" << endl;
        cout << "6. Нахождение квадратного корня" << endl;
        cout << "7. Нахождение 1 процента от числа" << endl;
        cout << "8. Найти факториал числа" << endl;
        cout << "9. Выйти из программы" << endl;
        cout << "Выберите операцию: ";
        cin >> choice;

        switch (choice) 
        {
        case 1:
            cout << "Введите два числа, которые хотите сложить: ";
            cin >> a >> b;
            result = a + b;
            cout << "\nРезультат: " << result << endl;
            break;
        case 2:
            cout << "Введите два числа, которые хотите вычесть: ";
            cin >> a >> b;
            result = a - b;
            cout << "\nРезультат: " << result << endl;
            break;
        case 3:
            cout << "Введите два числа, которые хотите умножить: ";
            cin >> a >> b;
            result = a * b;
            cout << "\nРезультат: " << result << endl;
            break;
        case 4:
            cout << "Введите два числа, которые хотите разделить: ";
            cin >> a >> b;
            if (b != 0) 
            {
                result = a / b;
                cout << "\nРезультат: " << result << endl;
            }
            else 
            {
                cout << "\nОшибка! Нельзя делить на ноль." << endl;
            }
            break;
        case 5:
            cout << "Введите число и степень, в которую хотите возвести: ";
            cin >> a >> b;
            result = pow(a, b);
            cout << "\nРезультат: " << result << endl;
            break;
        case 6:
            cout << "Введите число, для которого хотите найти квадратный корень: ";
            cin >> a;
            if (a >= 0) 
            {
                result = sqrt(a);
                cout << "\nРезультат: " << result << endl;
            }
            else {
                cout << "\nОшибка! Нельзя извлечь корень из отрицательного числа." << endl;
            }
            break;
        case 7:
            cout << "Введите число, для которого хотите найти 1 процент: ";
            cin >> a;
            result = a * 0.01;
            cout << "\nРезультат: " << result << endl;
            break;
        case 8:
            cout << "Введите число, для которого хотите найти факториал: ";
            cin >> a;
            if (a >= 0) 
            {
                result = 1;
                for (int i = 1; i <= a; i++) {
                    result *= i;
                }
                cout << "\nРезультат: " << result << endl;
            }
            else 
            {
                cout << "Ошибка. Факториал определен только для неотрицательных чисел." << endl;
            }
            break;
        case 9:
            cout << "\nПрограмма завершена." << endl;
            break;
        default:
            cout << "\nОшибка! Неверный выбор операции." << endl;
            break;
        }
        cout << endl;

    } while (choice != 9);

    return 0;
}
