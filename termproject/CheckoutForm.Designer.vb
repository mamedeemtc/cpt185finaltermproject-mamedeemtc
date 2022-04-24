<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCheckout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckout))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayStudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.VideoDataSet = New termproject.VideoDataSet()
        Me.VideoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VideoTableAdapter = New termproject.VideoDataSetTableAdapters.VideoTableAdapter()
        Me.TableAdapterManager = New termproject.VideoDataSetTableAdapters.TableAdapterManager()
        Me.lblNameDisplay = New System.Windows.Forms.Label()
        Me.CustomerRentalDataSet = New termproject.CustomerRentalDataSet()
        Me.CustomerRentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerRentalTableAdapter = New termproject.CustomerRentalDataSetTableAdapters.CustomerRentalTableAdapter()
        Me.TableAdapterManager1 = New termproject.CustomerRentalDataSetTableAdapters.TableAdapterManager()
        Me.lstMovies = New System.Windows.Forms.ListBox()
        Me.CustomerDataSet = New termproject.CustomerDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New termproject.CustomerDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager2 = New termproject.CustomerDataSetTableAdapters.TableAdapterManager()
        Me.CustomerIDLabel1 = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.VideoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(16, 123)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(91, 14)
        CustomerIDLabel.TabIndex = 12
        CustomerIDLabel.Text = "Customer ID:"
        AddHandler CustomerIDLabel.Click, AddressOf Me.CustomerIDLabel_Click
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(382, 123)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 18)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Morgan's Video Store"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(386, 39)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuWindows, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(605, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(40, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(97, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplayStudio, Me.mnuDisplayVideo})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(77, 20)
        Me.mnuWindows.Text = "Windows"
        '
        'mnuDisplayStudio
        '
        Me.mnuDisplayStudio.Name = "mnuDisplayStudio"
        Me.mnuDisplayStudio.Size = New System.Drawing.Size(163, 22)
        Me.mnuDisplayStudio.Text = "Display Studio"
        '
        'mnuDisplayVideo
        '
        Me.mnuDisplayVideo.Name = "mnuDisplayVideo"
        Me.mnuDisplayVideo.Size = New System.Drawing.Size(163, 22)
        Me.mnuDisplayVideo.Text = "Display Video"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(47, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(111, 22)
        Me.mnuAbout.Text = "About"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(16, 172)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 14)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name:"
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(197, 380)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(137, 34)
        Me.btnCheckout.TabIndex = 8
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'VideoDataSet
        '
        Me.VideoDataSet.DataSetName = "VideoDataSet"
        Me.VideoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VideoBindingSource
        '
        Me.VideoBindingSource.DataMember = "Video"
        Me.VideoBindingSource.DataSource = Me.VideoDataSet
        '
        'VideoTableAdapter
        '
        Me.VideoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = termproject.VideoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VideoTableAdapter = Me.VideoTableAdapter
        '
        'lblNameDisplay
        '
        Me.lblNameDisplay.AutoSize = True
        Me.lblNameDisplay.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameDisplay.Location = New System.Drawing.Point(117, 172)
        Me.lblNameDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameDisplay.Name = "lblNameDisplay"
        Me.lblNameDisplay.Size = New System.Drawing.Size(49, 14)
        Me.lblNameDisplay.TabIndex = 12
        Me.lblNameDisplay.Text = "Label2"
        '
        'CustomerRentalDataSet
        '
        Me.CustomerRentalDataSet.DataSetName = "CustomerRentalDataSet"
        Me.CustomerRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerRentalBindingSource
        '
        Me.CustomerRentalBindingSource.DataMember = "CustomerRental"
        Me.CustomerRentalBindingSource.DataSource = Me.CustomerRentalDataSet
        '
        'CustomerRentalTableAdapter
        '
        Me.CustomerRentalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CustomerRentalTableAdapter = Me.CustomerRentalTableAdapter
        Me.TableAdapterManager1.UpdateOrder = termproject.CustomerRentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lstMovies
        '
        Me.lstMovies.DataSource = Me.VideoBindingSource
        Me.lstMovies.DisplayMember = "Title"
        Me.lstMovies.FormattingEnabled = True
        Me.lstMovies.ItemHeight = 14
        Me.lstMovies.Location = New System.Drawing.Point(120, 243)
        Me.lstMovies.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstMovies.Name = "lstMovies"
        Me.lstMovies.Size = New System.Drawing.Size(321, 116)
        Me.lstMovies.TabIndex = 10
        Me.lstMovies.ValueMember = "Movie Number"
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager2.UpdateOrder = termproject.CustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerIDLabel1
        '
        Me.CustomerIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.CustomerIDLabel1.Location = New System.Drawing.Point(113, 123)
        Me.CustomerIDLabel1.Name = "CustomerIDLabel1"
        Me.CustomerIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CustomerIDLabel1.TabIndex = 13
        Me.CustomerIDLabel1.Text = "Label1"
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(605, 436)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDLabel1)
        Me.Controls.Add(Me.lblNameDisplay)
        Me.Controls.Add(Me.lstMovies)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmCheckout"
        Me.Text = "CheckoutForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.VideoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuWindows As ToolStripMenuItem
    Friend WithEvents mnuDisplayStudio As ToolStripMenuItem
    Friend WithEvents mnuDisplayVideo As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents lblName As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents VideoDataSet As VideoDataSet
    Friend WithEvents VideoBindingSource As BindingSource
    Friend WithEvents VideoTableAdapter As VideoDataSetTableAdapters.VideoTableAdapter
    Friend WithEvents TableAdapterManager As VideoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblNameDisplay As Label
    Friend WithEvents CustomerRentalDataSet As CustomerRentalDataSet
    Friend WithEvents CustomerRentalBindingSource As BindingSource
    Friend WithEvents CustomerRentalTableAdapter As CustomerRentalDataSetTableAdapters.CustomerRentalTableAdapter
    Friend WithEvents TableAdapterManager1 As CustomerRentalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lstMovies As ListBox
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As CustomerDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager2 As CustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerIDLabel1 As Label
End Class
