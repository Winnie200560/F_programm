// Лабораторная №2
// Задача 1
// Получить список из сумм цифр натуральных чисел, содержащихся в исходном списке

open System

// Функция для вычисления суммы цифр числа
let rec SummDigit n =
    if n = 0 then
        0
    else
        (n % 10) + SummDigit (n / 10)

// Функция для формирования списка из чисел введных с клавиатуры
let ListDigit n = 
    [
    for i in 1..n do
        printf "Введите число %d: " i
        let num = int (Console.ReadLine())

        if num < 0 then
            printfn "Ошибка! Число должно быть натуральным!"
            yield 0
        else
            yield num
    ]

[<EntryPoint>]
let main args = 
    printf "Введите количество чисел в списке: "
    let n = int (Console.ReadLine())

    if n <= 0 then 
        printfn "Ошибка! Количество должно быть положительным числом!"
    else
        let numbers = ListDigit n
        let result = List.map SummDigit numbers

        printfn "Список сумм цифр: %A" result

    0