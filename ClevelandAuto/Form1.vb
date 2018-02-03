Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        Dim intCarCount, intPropertyCount As Integer
        Dim strHeader = "CAR" & vbTab  'Header row 
        Dim strOutput As String ' Accumulator for outputing the car + properties

        'Ask user the car count and property count

        'An extra property is added to account for the car name
        intPropertyCount = InputBox("Please enter the number of properties you wish to enter") + 1
        intCarCount = InputBox("Please enter the number of cars you wish to enter") - 1


        Dim strProperties(intPropertyCount - 2) As String         'Holds the property strings for the input box
        Dim strCars(intCarCount, intPropertyCount - 1) As String  'Holds the car name & properties the user puts in

        Dim counter = 0
        For Each prop In strProperties 'Make the property header, populate strProperties
            strProperties(counter) = InputBox("Ok, enter property " & (counter + 1)).ToString.ToUpper
            strHeader += strProperties(counter) & vbTab & "  "
            counter += 1
        Next

        ListBox1.Items.Add(strHeader)

        'The first element of each array is the car name.
        For car = 0 To intCarCount
            strCars(car, 0) = InputBox("Whats the name of car #" & car + 1 & "?")
            strOutput += strCars(car, 0) & vbTab 'Puts the car name in.
            counter = 0                          'Used to get the property from the strProperties array.
            For carProperty = 1 To intPropertyCount - 1 'Counter starts at 1 becuase (x,0) is the car name.
                strCars(car, carProperty) = InputBox("Enter the " & strCars(car, 0) & " " & strProperties(counter) & " property")
                counter += 1
                strOutput += strCars(car, carProperty) & vbTab
            Next
            ListBox1.Items.Add(strOutput)
            strOutput = ""
        Next
    End Sub

End Class
