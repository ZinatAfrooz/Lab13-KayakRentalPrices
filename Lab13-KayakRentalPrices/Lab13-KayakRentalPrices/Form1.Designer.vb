<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeeklyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalPricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet = New Lab13_KayakRentalPrices.KayaksDataSet()
        Me.RentalPricesTableAdapter = New Lab13_KayakRentalPrices.KayaksDataSetTableAdapters.RentalPricesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalPricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name, Me.DailyRateDataGridViewTextBoxColumn, Me.HourlyRateDataGridViewTextBoxColumn, Me.WeeklyRateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RentalPricesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(567, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'Name
        '
        Me.Name.DataPropertyName = "Name"
        Me.Name.HeaderText = "Name"
        Me.Name.Name = "Name"
        '
        'DailyRateDataGridViewTextBoxColumn
        '
        Me.DailyRateDataGridViewTextBoxColumn.DataPropertyName = "Daily_Rate"
        Me.DailyRateDataGridViewTextBoxColumn.HeaderText = "Daily Rate"
        Me.DailyRateDataGridViewTextBoxColumn.Name = "DailyRateDataGridViewTextBoxColumn"
        '
        'HourlyRateDataGridViewTextBoxColumn
        '
        Me.HourlyRateDataGridViewTextBoxColumn.DataPropertyName = "Hourly_Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.Name = "HourlyRateDataGridViewTextBoxColumn"
        '
        'WeeklyRateDataGridViewTextBoxColumn
        '
        Me.WeeklyRateDataGridViewTextBoxColumn.DataPropertyName = "Weekly_Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.HeaderText = "Weekly Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.Name = "WeeklyRateDataGridViewTextBoxColumn"
        '
        'RentalPricesBindingSource
        '
        Me.RentalPricesBindingSource.DataMember = "RentalPrices"
        Me.RentalPricesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalPricesTableAdapter
        '
        Me.RentalPricesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 261)
        Me.Controls.Add(Me.DataGridView1)
        'Me.Name = "Form1"
        Me.Text = "Kayak Rental Prices"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalPricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents RentalPricesBindingSource As BindingSource
    Friend WithEvents RentalPricesTableAdapter As KayaksDataSetTableAdapters.RentalPricesTableAdapter
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents DailyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
