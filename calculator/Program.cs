package org.example;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        try {
            // Создаение объекта FileWriter для записи данных в файл
            FileWriter writer = new FileWriter("C:\\Users\\kostu\\OneDrive\\Рабочий стол\\students.txt");

            // Создание объекта Scanner для чтения данных с консоли
            Scanner scanner = new Scanner(System.in);

            // Запрос  информации о студентах у пользователя
            System.out.print("Введите количество студентов: ");
            int count = scanner.nextInt();
            scanner.nextLine(); // Считываем лишний символ переноса строки после ввода числа

            for (int i = 1; i <= count; i++) {
                System.out.println("Введите информацию о студенте " + i + ":");
                System.out.print("Имя: ");
                String name = scanner.nextLine();
                System.out.print("Возраст: ");
                int age = scanner.nextInt();
                System.out.print("Средний балл: ");
                double averageGrade = scanner.nextDouble();
                scanner.nextLine(); // Считываем лишний символ переноса строки после считывания числа

                // Записываем информацию о студенте в файл
                writer.write("Студент " + i + ": " + name + ", Возраст: " + age +
                        ", Средний балл: " + averageGrade + System.lineSeparator());
            }

            // Закрываем файл после записи данных
            writer.close();

            // Вывод сообщение об успешной записи данных
            System.out.println("Данные успешно записаны в файл students.txt");

            // Открытие файла для проверки записанных данных

        } catch (IOException e) {
            System.out.println("Ошибка при записи данных в файл: " + e.getMessage());
        }
    }
}
