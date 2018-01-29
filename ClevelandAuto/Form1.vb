Public Class Form1
    Dim intCarCount, intPropertyCount As Integer
    Dim strHeader = "CAR" & vbTab 'Header row 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        'if input.yes then else...

        'Ask user the car count and property count
        intCarCount = InputBox("Please enter the number of cars you wish to enter")
        intPropertyCount = InputBox("How many properties do you wish to enter?") - 1

        Dim strProperties(intPropertyCount) As String
        Dim strCars(intCarCount, intPropertyCount) As String

        Dim counter = 0
        For Each prop In strProperties 'Make the property header
            counter += 1
            strProperties(counter) = InputBox("Ok, enter property " & (counter)).ToString.ToUpper
            strHeader += strProperties(counter) & vbTab
        Next

        ListBox1.Items.Add(strHeader)


        'The first element of each array is the car name.
        For car = 0 To intCarCount - 1
            strCars(car, 0) = InputBox("Whats the name of car #" & car + 1 & "?")
            For carProperty = 1 To intPropertyCount
                strCars(car, carProperty) = InputBox("Enter the " & strCars(car, car "property for" & strCars(intCarCount, 0))
            Next
        Next
        ListBox1.Items.Add(strCars(0, 1))
        ListBox1.Items.Add(strCars(1, 1))




    End Sub

End Class
