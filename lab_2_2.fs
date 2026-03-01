// Задача 2
// Найти сумму тех элементов списка, которые начинаются на заданную цифру.

open System

// Функция для нахождения первой цифры числа
let firstDigit n =
    let rec loop x = 
        if x < 10 then
            x
        else 
            loop (x / 10)
    loop (abs n)

// Фунция ввода списка
let inputList n = 
    [
    for i in 1..n do
        printf "Введите число: "
        let num = int(Console.ReadLine())
        yield num
    ]

[<EntryPoint>]
let main args = 
    printf "Введите количество чисел в списке: "
    let n = int(Console.ReadLine())
    if n <= 0 then 
        printfn "Ошибка! Количество должно быть положительным числом!"
    else
        let numbers = inputList n

        printfn "Введите цифру (0-9): "
        let digit = int(Console.ReadLine())
        let result = List.fold (fun sum x -> if firstDigit x = digit then sum + x else sum) 0 numbers
        printfn "Сумма элементов, начинающихся на %d = %d" digit result
    0