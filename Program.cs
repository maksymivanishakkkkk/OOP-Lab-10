
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Завдання 1: Робота з класом Stack для різних типів
        Console.WriteLine("Завдання 1: Робота з класом Stack");

        Stack<object> myStack = new Stack<object>();

        // Створення об’єкта класу-колекції
        Console.WriteLine("Створено стек:");

        // Додавання значень різних типів
        myStack.Push("Hello");
        myStack.Push(3.14);
        myStack.Push(42);

        // Додавання/вилучення елементів в/із колекції;
        Console.WriteLine("Елементи в стеці:");

        // Виведення значень на екран
        foreach (var item in myStack)
        {
            Console.WriteLine(item);
        }

        // Пошук елементів в колекції
        Console.WriteLine("\nПошук значення 'Hello' в стеці:");

        if (myStack.Contains("Hello"))
        {
            Console.WriteLine("Знайдено 'Hello' в стеці.");
        }
        else
        {
            Console.WriteLine("Не знайдено 'Hello' в стеці.");
        }

        // Визначення кількості елементів, що містяться в колекції
        Console.WriteLine($"\nКількість елементів в стеці: {myStack.Count}");

        // Очищення колекції
        myStack.Clear();
        Console.WriteLine("\nСтек очищено.");

        // Завдання 2: Робота з класом Dictionary для колекції об'єктів Product
        Console.WriteLine("\nЗавдання 2: Робота з класом Dictionary");

        Dictionary<int, Product> productDictionary = new Dictionary<int, Product>();

        // Створення об’єкта класу-колекції
        Console.WriteLine("Створено словник продуктів:");

        // Додавання елементів в словник
        productDictionary.Add(1, new Product(1, "Лаптоп", 999.99));
        productDictionary.Add(2, new Product(2, "Смартфон", 599.99));

        // Додавання/вилучення елементів в/із колекції;
        Console.WriteLine("Елементи в словнику:");

        // Виведення елементів словника на екран
        foreach (var pair in productDictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }

        // Пошук елементів в колекції
        Console.WriteLine("\nПошук продукту з ID=2 в словнику:");

        if (productDictionary.ContainsKey(2))
        {
            Console.WriteLine($"Знайдено продукт з ID=2: {productDictionary[2]}");
        }
        else
        {
            Console.WriteLine("Не знайдено продукт з ID=2.");
        }

        // Визначення кількості елементів, що містяться в колекції
        Console.WriteLine($"\nКількість елементів в словнику: {productDictionary.Count}");

        // Очищення колекції
        productDictionary.Clear();
        Console.WriteLine("\nСловник продуктів очищено.");

        // Аналіз особливостей роботи з класами-колекціями та відмінностей між ними
        Console.WriteLine("\nАналіз особливостей роботи з класами-колекціями:");

        Console.WriteLine("1. Клас Stack - це колекція, яка працює за принципом Last-In-First-Out (LIFO).");
        Console.WriteLine("2. Клас Dictionary - це колекція, яка містить пари ключ-значення. Кожен елемент унікальний за ключем.");

        Console.ReadLine();
    }
}

class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        ID = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Price: {Price:C}";
    }
}

