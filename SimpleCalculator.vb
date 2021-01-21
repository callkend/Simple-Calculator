'Kendall Callister
'Tim Rossiter
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/callkend/Simple-Calculator.git

Option Explicit On
Option Strict On


Module SimpleCalculator

    Sub Main()
        Dim numberOne As Decimal
        Dim numberTwo As Decimal
        Dim sign As String


        Console.WriteLine("Number One=")
        numberOne = CDec(Console.ReadLine())
        Console.WriteLine("Number Two=")
        numberTwo = CDec(Console.ReadLine())
        Console.WriteLine("Choose Option")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        sign = Console.ReadLine()
        If sign = "1" Or sign = "1." Or sign = "Sum" Then
            Console.WriteLine(numberOne + numberTwo)
        ElseIf sign = "2" Or sign = "2." Or sign = "Product" Then
            Console.WriteLine(numberOne * numberTwo)
        End If
        Console.Read()
    End Sub

End Module
