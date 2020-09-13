'David Harmon
'RCET0265
'Fall 2020
'Fortune Cookie
'https://github.com/harmdavi/fortuneCookie.git

'This code made possible by viewers like you... also Lane Coleman.

Option Strict On
Option Explicit On
Option Compare Text



Module fortuneCookie

    Sub Main()
        Dim randomNumber As Integer
        'This randomizes the seed for Visual Basic so that you dont get the same pattern of randomness 
        'when the program is run multiple times. 
        Randomize()
        Do

            Console.WriteLine("Please Press Enter to gain wisdom")
            Console.ReadLine()

            randomNumber = GetRandomNumber(1, 2)

            If randomNumber = 1 Then
                Console.WriteLine($"Help I am stuck in a fortune cookie factory. {vbNewLine}")

            ElseIf randomNumber = 2 Then
                Console.WriteLine($"Licking door knobs is illegal on other planets. {vbNewLine}")
            ElseIf randomNumber = 3 Then
                Console.WriteLine($"Surround yourself with tacos and not negativity. {vbNewLine}")
            End If
            Console.ReadLine()

        Loop






    End Sub

    Function GetRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Dim value As Single
        value = ((maximum - minimum + 1) * Rnd()) + minimum
        Return CInt(value)
    End Function
End Module
