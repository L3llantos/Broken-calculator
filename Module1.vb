

Module Module1

    Sub Main()
        Dim number1 As Decimal
        Dim number2 As Decimal
        Dim operatorChoice As String



        Console.WriteLine("please enter the first number")
        number1 = Console.ReadLine()

        Console.WriteLine("please enter the operator you want (+ - * /)")
        operatorChoice = Console.ReadLine()

        Console.WriteLine("please enter the second number")
        number2 = Console.ReadLine()


        Debug.Assert(BuggyMaths.Add(1, 1) = 2, "windows encountered a problem it appears to be a butterfly ")
        Debug.Assert(BuggyMaths.Subtract(1, 1) = 0, "windows encountered a problem it appears to be a butterfly ")
        Debug.Assert(BuggyMaths.Multiply(1, 1) = 1, "windows encountered a problem it appears to be a butterfly ")
        Debug.Assert(BuggyMaths.Divide(1, 1) = 1, "windows encountered a problem it appears to be a butterfly ")


        Select Case operatorChoice
            Case "/"
                Console.WriteLine("Answer is: " & BuggyMaths.Divide(number1, number2))
            Case "*"
                Console.WriteLine("Answer is: " & BuggyMaths.Multiply(number1, number2))
            Case "+"
                Console.WriteLine("Answer is: " & BuggyMaths.Add(number1, number2))
            Case "-"
                Console.WriteLine("Answer is: " & BuggyMaths.Subtract(number1, number2))
        End Select

        Console.ReadLine()
    End Sub

End Module
