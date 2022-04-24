<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVideoRentals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoRentals))
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayStudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayVideo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.VideoDataSet = New termproject.VideoDataSet()
        Me.VideoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VideoTableAdapter = New termproject.VideoDataSetTableAdapters.VideoTableAdapter()
        Me.TableAdapterManager = New termproject.VideoDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNameDisplay = New System.Windows.Forms.Label()
        Me.CustomerDataSet = New termproject.CustomerDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New termproject.CustomerDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager1 = New termproject.CustomerDataSetTableAdapters.TableAdapterManager()
        Me.CustomerIDLabel1 = New System.Windows.Forms.Label()
        Me.CustomerRentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VideosRentedDataSet = New termproject.VideosRentedDataSet()
        Me.CustomerRentalTableAdapter = New termproject.VideosRentedDataSetTableAdapters.CustomerRentalTableAdapter()
        Me.TableAdapterManager2 = New termproject.VideosRentedDataSetTableAdapters.TableAdapterManager()
        Me.CustomerRentalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CustomerIDLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideosRentedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRentalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuWindows, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.mnuWindows.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.mnuHelp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(406, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(391, 94)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 18)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Morgan's Video Store"
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Movie Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Movie Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Studio ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Studio ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Length"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Length"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(25, 137)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(48, 14)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'lblNameDisplay
        '
        Me.lblNameDisplay.AutoSize = True
        Me.lblNameDisplay.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameDisplay.Location = New System.Drawing.Point(122, 137)
        Me.lblNameDisplay.Name = "lblNameDisplay"
        Me.lblNameDisplay.Size = New System.Drawing.Size(49, 14)
        Me.lblNameDisplay.TabIndex = 6
        Me.lblNameDisplay.Text = "Label4"
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
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager1.UpdateOrder = termproject.CustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomerIDLabel.Location = New System.Drawing.Point(25, 94)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(91, 14)
        CustomerIDLabel.TabIndex = 8
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerIDLabel1
        '
        Me.CustomerIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.CustomerIDLabel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDLabel1.Location = New System.Drawing.Point(122, 94)
        Me.CustomerIDLabel1.Name = "CustomerIDLabel1"
        Me.CustomerIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CustomerIDLabel1.TabIndex = 9
        Me.CustomerIDLabel1.Text = "Label1"
        '
        'CustomerRentalBindingSource
        '
        Me.CustomerRentalBindingSource.DataMember = "CustomerRental"
        Me.CustomerRentalBindingSource.DataSource = Me.VideosRentedDataSet
        '
        'VideosRentedDataSet
        '
        Me.VideosRentedDataSet.DataSetName = "VideosRentedDataSet"
        Me.VideosRentedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerRentalTableAdapter
        '
        Me.CustomerRentalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = termproject.VideosRentedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerRentalDataGridView
        '
        Me.CustomerRentalDataGridView.AutoGenerateColumns = False
        Me.CustomerRentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerRentalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CustomerRentalDataGridView.DataSource = Me.CustomerRentalBindingSource
        Me.CustomerRentalDataGridView.Location = New System.Drawing.Point(164, 206)
        Me.CustomerRentalDataGridView.Name = "CustomerRentalDataGridView"
        Me.CustomerRentalDataGridView.Size = New System.Drawing.Size(251, 220)
        Me.CustomerRentalDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'frmVideoRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(579, 467)
        Me.Controls.Add(Me.CustomerRentalDataGridView)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDLabel1)
        Me.Controls.Add(Me.lblNameDisplay)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmVideoRentals"
        Me.Text = "VideoRentals"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideosRentedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRentalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuWindows As ToolStripMenuItem
    Friend WithEvents mnuDisplayStudio As ToolStripMenuItem
    Friend WithEvents mnuDisplayVideo As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents VideoDataSet As VideoDataSet
    Friend WithEvents VideoBindingSource As BindingSource
    Friend WithEvents VideoTableAdapter As VideoDataSetTableAdapters.VideoTableAdapter
    Friend WithEvents TableAdapterManager As VideoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents lblName As Label
    Friend WithEvents lblNameDisplay As Label
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As CustomerDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager1 As CustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VideosRentedDataSet As VideosRentedDataSet
    Friend WithEvents CustomerRentalBindingSource As BindingSource
    Friend WithEvents CustomerRentalTableAdapter As VideosRentedDataSetTableAdapters.CustomerRentalTableAdapter
    Friend WithEvents TableAdapterManager2 As VideosRentedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerIDLabel1 As Label
    Friend WithEvents CustomerRentalDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
