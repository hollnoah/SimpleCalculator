'Noah Holloway
'RCET 2265
'Spring 2025
'Simple Calculator
Module SimpleCalculator

    Sub Main()
        'declaring variables
        Dim userinput As String
        Dim firstnumber As Integer
        Dim secondnumber As Integer

        'reads the first number typed by the user as an integer
        Console.WriteLine("Please enter a whole number")
        userinput = Console.ReadLine()
        firstnumber = CInt(userinput)

        'reads the second number typed by the user as an integer
        Console.WriteLine("Please enter another whole number")
        userinput = Console.ReadLine()
        secondnumber = CInt(userinput)

        'dictates addition or multiplication and displays the choice to the user
        Console.WriteLine("Please select from the following: " & vbNewLine _
                          & "1.) Add" & vbNewLine _
                          & "2.) Multiply"
                          )
        userinput = Console.ReadLine()
        Console.WriteLine($"You have selected {userinput}")

        'determines user selection, performs math operation, and displays a message
        If userinput = "1" Then
            Console.WriteLine("Add-a boy!")
            Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}")

        ElseIf userinput = "2" Then
            Console.WriteLine("Good times!")
            Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}")

        Else
            Console.WriteLine("Looks like somebody can't follow directions")
        End If

    End Sub

End Module
