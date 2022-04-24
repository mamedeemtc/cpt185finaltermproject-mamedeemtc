Public Class frmMain
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.CustomerDataSet.Customer)

    End Sub

    Private Sub btnRentals_Click(sender As Object, e As EventArgs) Handles btnRentals.Click
        ' Displays the video rental form

        frmVideoRentals.ShowDialog()
    End Sub

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Hold the splash screen for 5 seconds

        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Displays the checkout form

        frmCheckout.ShowDialog()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Exits application

        Application.Exit()
    End Sub

    Private Sub mnuDisplayStudio_Click(sender As Object, e As EventArgs) Handles mnuDisplayStudio.Click
        ' Displays studio form

        frmDisplayStudio.ShowDialog()
    End Sub

    Private Sub mnuDisplayVideo_Click(sender As Object, e As EventArgs) Handles mnuDisplayVideo.Click
        ' Displays video form

        frmDisplayVideo.ShowDialog()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ' Displays about form

        frmAbout.ShowDialog()
    End Sub

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerDataSet)

    End Sub


End Class
