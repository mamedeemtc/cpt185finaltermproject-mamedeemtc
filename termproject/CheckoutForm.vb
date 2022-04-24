Public Class frmCheckout
    Private Sub CheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.CustomerDataSet.Customer)

        'TODO: This line of code loads data into the 'VideoDataSet.Video' table. You can move, or remove it, as needed.
        Me.VideoTableAdapter.Fill(Me.VideoDataSet.Video)
        CustomerIDLabel1.Text = frmMain.CustomerIDTextBox.Text
        lblNameDisplay.Text = frmMain.FirstNameTextBox.Text & " " & frmMain.LastNameTextBox.Text
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Try
            'Declare Variable for Inserting Row
            Dim newrow As DataRow = CustomerRentalDataSet.CustomerRental.NewRow
            'Move data to new row
            newrow("CustomerID") = Integer.Parse(CustomerIDLabel1.Text)
            newrow("MovieNumber") = lstMovies.SelectedValue.ToString
            newrow("Date") = DateTime.Now
            'Add the row
            CustomerRentalDataSet.CustomerRental.Rows.Add(newrow)
            'Send changes To database
            Me.Validate()
            Me.CustomerRentalBindingSource.EndEdit()
            Me.CustomerRentalTableAdapter.Update(Me.CustomerRentalDataSet.CustomerRental)
            MessageBox.Show(“Record Added”, “Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error Adding Record", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VideoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VideoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VideoDataSet)

    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ' Display About form

        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuDisplayStudio_Click(sender As Object, e As EventArgs) Handles mnuDisplayStudio.Click
        ' Displays Display Studio form

        frmDisplayStudio.ShowDialog()
    End Sub

    Private Sub mnuDisplayVideo_Click(sender As Object, e As EventArgs) Handles mnuDisplayVideo.Click
        ' Displays Video Display form

        frmDisplayVideo.ShowDialog()
    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Exits the Checkout form

        Hide()
    End Sub

    Private Sub CustomerIDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CustomerIDLabel1_Click(sender As Object, e As EventArgs) Handles CustomerIDLabel1.Click

    End Sub
End Class