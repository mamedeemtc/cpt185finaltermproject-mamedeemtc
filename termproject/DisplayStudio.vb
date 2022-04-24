Public Class frmDisplayStudio
    Private Sub frmDisplayStudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudioDataSet.Studio' table. You can move, or remove it, as needed.
        Me.StudioTableAdapter.Fill(Me.StudioDataSet.Studio)

    End Sub


    Private Sub mnuDisplayVideo_Click(sender As Object, e As EventArgs) Handles mnuDisplayStudio.Click
        ' Displays the Display Studio form

        frmDisplayVideo.ShowDialog()
    End Sub


    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ' Displays the About form

        frmAbout.ShowDialog()
    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Returns to Main form

        Hide()
    End Sub

    Private Sub StudioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudioDataSet)

    End Sub
End Class