Option Strict On
Imports System.IO
Public Class Form1

    Dim pathStudent As String = "Students.txt"
    Dim pathClasses As String = "Classes.txt"
    Dim StudentsIn As New StreamReader(New FileStream(pathStudent, FileMode.Open, FileAccess.Read))
    Dim ClassesIn As New StreamReader(New FileStream(pathClasses, FileMode.Open, FileAccess.Read))
    Dim StudentList As New List(Of Students)
    Dim ClassesList As New List(Of Classes)


    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'Reads in students and adds them to list
        Do While StudentsIn.Peek <> -1
            Dim row As String = StudentsIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            Dim StudentRecord As New Students
            StudentRecord.StudentID = columns(0)
            StudentRecord.FirstName = columns(1)
            StudentRecord.LastName = columns(2)
            StudentRecord.Major = columns(3)
            StudentList.Add(StudentRecord)
        Loop
        StudentsIn.Close()

        'Reads in classes and adds them to list
        Do While ClassesIn.Peek <> -1
            Dim row As String = ClassesIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            Dim ClassRecord As New Classes
            ClassRecord.StuID = columns(0)
            ClassRecord.Department = columns(1)
            ClassRecord.Credits = Convert.ToInt32(columns(3))
            ClassRecord.ClassNumber = columns(2)
            ClassesList.Add(ClassRecord)
        Loop
        ClassesIn.Close()

        'Here is the query
        'Every class has some STU, not every STU has that class!
        Dim Enrolled =
            From classesRecord In ClassesList
            Join studentRecord In StudentList
                On classesRecord.StuID Equals studentRecord.StudentID
            Order By studentRecord.StudentID
            Select studentRecord.StudentID, classesRecord.StuID, studentRecord.LastName, studentRecord.FirstName, classesRecord.Department, classesRecord.ClassNumber, classesRecord.Credits
        'Each property it finds here will be a new property of "classes" down below

        Dim tempStudentID As String = ""
        Dim i As Integer = 0
        'REMEMBER TO ADD ALL CREDITS WITH THIS (v), MAY HAVE TO MOVE SOMEWHERE ELSE
        Dim tempTotalCredits As Integer
        For Each classes In Enrolled
            'classes is the name for each record in Enrolled!!
            If classes.StuID <> tempStudentID And i = 0 Then
                lvStudentRecords.Items.Add(classes.StuID)
                tempStudentID = classes.StuID
            ElseIf classes.StuID <> tempStudentID Then
                'could not finish the total line in time.
                lvStudentRecords.Items.Add(classes.StuID)
                tempStudentID = classes.StuID
                lvStudentRecords.Items(i).SubItems.Add(classes.LastName)
                lvStudentRecords.Items(i).SubItems.Add(classes.FirstName)
                lvStudentRecords.Items(i).SubItems.Add(classes.Department)
                lvStudentRecords.Items(i).SubItems.Add(classes.ClassNumber)
                lvStudentRecords.Items(i).SubItems.Add(Convert.ToString(classes.Credits))
            Else
                lvStudentRecords.Items.Add("")
            End If
            lvStudentRecords.Items(i).SubItems.Add(classes.LastName)
            lvStudentRecords.Items(i).SubItems.Add(classes.FirstName)
            lvStudentRecords.Items(i).SubItems.Add(classes.Department)
            lvStudentRecords.Items(i).SubItems.Add(classes.ClassNumber)
            lvStudentRecords.Items(i).SubItems.Add(Convert.ToString(classes.Credits))
            tempTotalCredits = +classes.Credits
            i += 1
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
