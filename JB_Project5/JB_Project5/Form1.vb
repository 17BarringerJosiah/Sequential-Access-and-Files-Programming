'Sequential Access and Files Programming Assignment
'Purpose: Input/Output Files w/ data
'Josiah Barringer
'I will Not use code that was never covered in class Or in our textbook. If you do you
'must be able To explain your code When asked by the professor. Using code
'outside of the resources provided, it can be flagged And reported as an academic
'integrity violation If there Is any suspicion Of copying/cheating.

Public Class Form1
    Private membersFile As String

    ' Form Load Event: Load file when the form is opened
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        membersFile = InputBox("Enter the name of the file to load:")
        If Not String.IsNullOrWhiteSpace(membersFile) Then
            LoadMembers(membersFile)
        End If
    End Sub

    ' Load members from the text file into the ListBox
    Private Sub LoadMembers(fileName As String)
        If IO.File.Exists(fileName) Then
            lstMembers.Items.Clear()
            Dim members As String() = IO.File.ReadAllLines(fileName)
            lstMembers.Items.AddRange(members)
            UpdateCount()
        Else
            MessageBox.Show("File not found.")
        End If
    End Sub

    ' Exit the application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Create a new file and clear the ListBox
    Private Sub CreateFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateFileToolStripMenuItem.Click
        membersFile = InputBox("Enter the name of the new file:")
        If Not String.IsNullOrWhiteSpace(membersFile) Then
            IO.File.WriteAllText(membersFile, "")
            lstMembers.Items.Clear()
            UpdateCount()
        End If
    End Sub

    ' Add a new member to the ListBox and save it to the file
    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        Dim newMember As String = InputBox("Enter the name of the new member:")
        If Not String.IsNullOrWhiteSpace(newMember) Then
            lstMembers.Items.Add(newMember)
            IO.File.AppendAllText(membersFile, newMember & Environment.NewLine)
            UpdateCount()
        End If
    End Sub

    ' Delete a selected member from the ListBox and the file
    Private Sub DeleteMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMemberToolStripMenuItem.Click
        If lstMembers.SelectedIndex >= 0 Then
            lstMembers.Items.RemoveAt(lstMembers.SelectedIndex)
            IO.File.WriteAllLines(membersFile, lstMembers.Items.Cast(Of String).ToArray())
            UpdateCount()
        Else
            MessageBox.Show("Please select a member to delete.")
        End If
    End Sub

    ' Sort members in ascending or descending order
    Private Sub AscendToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AscendToolStripMenuItem.Click
        SortMembers(True)
    End Sub

    Private Sub DescendToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescendToolStripMenuItem.Click
        SortMembers(False)
    End Sub

    ' Sorting logic for members
    Private Sub SortMembers(ascend As Boolean)
        Dim members As List(Of String) = lstMembers.Items.Cast(Of String).ToList()
        members.Sort()
        If Not ascend Then members.Reverse()
        lstMembers.Items.Clear()
        lstMembers.Items.AddRange(members.ToArray())
        IO.File.WriteAllLines(membersFile, lstMembers.Items.Cast(Of String).ToArray())
        UpdateCount()
    End Sub

    ' Update member count
    Private Sub UpdateCount()
        txtCount.Text = lstMembers.Items.Count.ToString()
    End Sub
End Class

