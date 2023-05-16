<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Consulta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Me.ColectoresConsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColectorDataSet = New Colector.ColectorDataSet
        Me.grdColector = New System.Windows.Forms.DataGrid
        Me.ColectoresConsTableAdapter = New Colector.ColectorDataSetTableAdapters.ColectoresConsTableAdapter
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ColectoresConsBindingSource
        '
        Me.ColectoresConsBindingSource.DataMember = "ColectoresCons"
        Me.ColectoresConsBindingSource.DataSource = Me.ColectorDataSet
        '
        'ColectorDataSet
        '
        Me.ColectorDataSet.DataSetName = "ColectorDataSet"
        Me.ColectorDataSet.Prefix = ""
        Me.ColectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdColector
        '
        Me.grdColector.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdColector.DataSource = Me.ColectoresConsBindingSource
        Me.grdColector.Location = New System.Drawing.Point(9, 26)
        Me.grdColector.Name = "grdColector"
        Me.grdColector.Size = New System.Drawing.Size(227, 122)
        Me.grdColector.TabIndex = 0
        '
        'ColectoresConsTableAdapter
        '
        Me.ColectoresConsTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Button2.Location = New System.Drawing.Point(86, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Salir"
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(245, 192)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grdColector)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdColector As System.Windows.Forms.DataGrid
    Friend WithEvents ColectorDataSet As Colector.ColectorDataSet
    Friend WithEvents ColectoresConsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColectoresConsTableAdapter As Colector.ColectorDataSetTableAdapters.ColectoresConsTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
