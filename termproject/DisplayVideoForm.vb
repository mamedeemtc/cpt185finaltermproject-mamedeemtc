Public Class frmDisplayVideo
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ' Displays the About form

        frmAbout.ShowDialog()
    End Sub


    Private Sub mnuDisplayStudio_Click(sender As Object, e As EventArgs) Handles mnuDisplayStudio.Click
        ' Displays the Display Studio form

        frmDisplayStudio.ShowDialog()
    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Returns to the Main form

        Hide()
    End Sub

    Private Sub VideoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VideoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VideoDataSet)

    End Sub

    Private Sub frmDisplayVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VideoDataSet.Video' table. You can move, or remove it, as needed.
        Me.VideoTableAdapter.Fill(Me.VideoDataSet.Video)

    End Sub
End Class