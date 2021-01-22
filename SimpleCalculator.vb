'Kendall Callister
'Tim Rossiter
'RCET0265
'Spring 2021
'Simple Calculator
'https://github.com/callkend/Simple-Calculator.git

Option Explicit On
Option Strict On


Module SimpleCalculator

    Sub Main()
        Dim userInput As String
        Dim numberOne As Decimal
        Dim numberTwo As Decimal
        Dim sign As String
        Dim problem As Boolean


        Console.WriteLine("Number One=")
        Try
            userInput = Console.ReadLine()
            numberOne = CDec(userInput)
        Catch e As Exception
            Console.WriteLine($"{userInput} is a invaild input")
            problem = True
        End Try

        Console.WriteLine("Number Two=")

        Try
            userInput = Console.ReadLine()
            numberTwo = CDec(userInput)
        Catch e As Exception
            Console.WriteLine($"{userInput} is a invaild input")
            problem = True
        End Try

        Console.WriteLine("Choose Option")
            Console.WriteLine("1. Sum")
            Console.WriteLine("2. Product")
            sign = Console.ReadLine()

        If problem = False And sign = "1" Or sign = "1." Or sign = "Sum" Then
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}")
        ElseIf problem = False And sign = "2" Or sign = "2." Or sign = "Product" Then
            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}")
        Else
            Console.WriteLine("Invaild input try later.")
        End If

            Console.Read()
    End Sub

End Module
