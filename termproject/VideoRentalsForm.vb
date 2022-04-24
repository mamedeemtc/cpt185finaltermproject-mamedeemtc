Public Class frmVideoRentals
    Private Sub VideoRentalsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.Customer' table. You can move, or remove it, as needed.




        'TODO: This line of code loads data into the 'VideoDataSet.Video' table. You can move, or remove it, as needed.

        CustomerIDLabel1.Text = frmMain.CustomerIDTextBox.Text
        lblNameDisplay.Text = frmMain.FirstNameTextBox.Text & " " & frmMain.LastNameTextBox.Text

        Me.VideoTableAdapter.Fill(Me.VideoDataSet.Video)

        Try
            Me.CustomerRentalTableAdapter.Fill(Me.VideosRentedDataSet.CustomerRental, Integer.Parse(CustomerIDLabel1.Text))
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Try
        'Me.CustomerRentalTableAdapter.Fill(Me.VideosRentedDataSet.CustomerRental, Integer.Parse(CustomerIDLabel1.Text))
        ' Catch ex As System.Exception
        'System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ' Displays About from

        frmAbout.ShowDialog()
    End Sub


    Private Sub mnuDisplayStudio_Click(sender As Object, e As EventArgs) Handles mnuDisplayStudio.Click
        ' Displays Display Studio form

        frmDisplayStudio.ShowDialog()
    End Sub


    Private Sub mnuDisplayVideo_Click(sender As Object, e As EventArgs) Handles mnuDisplayVideo.Click
        ' Displays Display Video form

        frmDisplayVideo.ShowDialog()
    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Exits the Video Rental form

        Hide()
    End Sub

    Private Sub VideoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VideoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VideoDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class