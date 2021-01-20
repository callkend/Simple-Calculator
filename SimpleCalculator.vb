'Kendall Callister
'Tim Rossiter
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/callkend/Simple-Calculator.git


Module SimpleCalculator

    Sub Main()
        Dim numberOne As Decimal
        Dim numberTwo As Decimal
        Dim sign As Int16


        Console.WriteLine("Number One=")
        numberOne = Console.ReadLine()
        Console.WriteLine("Number Two=")
        numberTwo = Console.ReadLine
        Console.WriteLine("Choose Option")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        sign = Console.ReadLine()
        If sign = 1 Then
            Console.WriteLine(numberOne + numberTwo)
        ElseIf sign = 2 Then
            Console.WriteLine(numberOne * numberTwo)
        End If
        Console.Read()
    End Sub

End Module
