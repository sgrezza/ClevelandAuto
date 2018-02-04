Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        ListBox1.Items.Clear()
        lstAverage.Items.Clear() 'Empty out the list boxes

        Dim intStudentCount, intExamCount As Integer
        Dim strHeader = "Student" & vbTab & " " 'Header row 

        intStudentCount = InputBox("Please enter the number of Students") - 1 'Minus one to use an array subscript
        intExamCount = InputBox("Please enter the number of Exams") - 1

        Dim strExamTitles(intExamCount) As String      'Array for holding exam names.
        Dim strStudentNames(intStudentCount) As String 'Array for holding student names.

        For exam = 0 To strExamTitles.Length - 1       'Gets exam names
            strExamTitles(exam) = InputBox("Please enter the name of Exam " & exam)
        Next
        For examName = 0 To strExamTitles.Length - 1   'Header row content
            strHeader += strExamTitles(examName) & vbTab
        Next

        ListBox1.Items.Add(strHeader)                  'Adds exam titles to header
        lstAverage.Items.Add(strHeader)                'Addes exam titles to average box

        For student = 0 To strStudentNames.Length - 1  'Gets student names
            strStudentNames(student) = InputBox("Please enter the name of Student " & student)
            ListBox1.Items.Add(strStudentNames(student) & vbTab + " ") 'Adds student names to listbox
        Next

        Dim strExamScores(intStudentCount, intExamCount) As String   '2d array for holding exam scores.
        'Array for exam averages.

        For student = 0 To strStudentNames.Length - 1
            For exam = 0 To strExamTitles.Length - 1
                strExamScores(student, exam) = InputBox("Please enter " & strStudentNames(student) & "'s score for " & strExamTitles(exam))

                ListBox1.Items(student + 1) += strExamScores(student, exam) & vbTab + " "  'Adds exam scores to listbox
            Next

        Next

        Dim intTotalExamGrades As Integer

        Dim strAveragesString = "" & vbTab
        Dim intExamAverage As Integer
        For exam = 0 To strExamTitles.Length - 1
            intTotalExamGrades = 0
            For student = 0 To strStudentNames.Length - 1
                intTotalExamGrades += Integer.Parse(strExamScores(student, exam))
            Next
            intExamAverage = intTotalExamGrades / (intExamCount + 1)
            strAveragesString += intExamAverage.ToString() & vbTab
        Next
        lstAverage.Items.Add(strAveragesString)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Form1.Close()
    End Sub
End Class
