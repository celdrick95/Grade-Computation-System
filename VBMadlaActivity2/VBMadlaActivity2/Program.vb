Imports System

Module Program
    Sub Main()
        Dim Name As String
        Dim Math, Science, English, Average As Integer
        Dim Grade As Double

        Console.WriteLine("Enter Name: ")
        Name = Console.ReadLine()
        Console.WriteLine("Enter Math: ")
        Math = Console.ReadLine()
        Console.WriteLine("Enter Science: ")
        Science = Console.ReadLine()
        Console.WriteLine("Enter English: ")
        English = Console.ReadLine()

        Average = Math + Science + English
        Grade = Average / 3

        Console.WriteLine()
        Console.WriteLine("Name: " & Name)
        Console.WriteLine("Math: " & Math)
        Console.WriteLine("Science: " & Science)
        Console.WriteLine("English: " & English)
        Console.WriteLine("Average Grade: " & Grade.ToString("#.##"))

        If (Grade >= 75) Then
            Console.WriteLine()
            Console.WriteLine("Congratulations!")
            Console.WriteLine("You passed the semester.")
        Else
            Console.WriteLine()
            Console.WriteLine("You failed the semester.")
        End If
        If (Math < 75 Or Science < 75 Or English < 75) Then
            Console.WriteLine()
            Console.WriteLine("but you need to retake the")
            Console.WriteLine("following subject(s):")
        End If
        If (Math < 75) Then
            Console.WriteLine("Math")
        End If
        If (Science < 75) Then
            Console.WriteLine("Science")
        End If
        If (English < 75) Then
            Console.WriteLine("English")
        End If
        Console.ReadLine()
    End Sub
End Module
