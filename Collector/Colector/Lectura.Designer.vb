<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Lectura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lectura))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ColectoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColectorDataSet = New Colector.ColectorDataSet
        Me.txtFechaHora = New System.Windows.Forms.TextBox
        Me.txtPrecinto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.OperadorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperadorDataSet = New Colector.OperadorDataSet
        Me.OperadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LugalmDataSet = New Colector.LugalmDataSet
        Me.LugalmBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCodDes = New System.Windows.Forms.ComboBox
        Me.TlBarra = New System.Windows.Forms.ToolBar
        Me.BotGraba = New System.Windows.Forms.ToolBarButton
        Me.BotCancela = New System.Windows.Forms.ToolBarButton
        Me.BotAgrega = New System.Windows.Forms.ToolBarButton
        Me.BotConsulta = New System.Windows.Forms.ToolBarButton
        Me.BotSalir = New System.Windows.Forms.ToolBarButton
        Me.BotLimpia = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList
        Me.ColectorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColectoresTableAdapter = New Colector.ColectorDataSetTableAdapters.colectoresTableAdapter
        Me.LugalmTableAdapter = New Colector.LugalmDataSetTableAdapters.lugalmTableAdapter
        Me.OperadoresTableAdapter = New Colector.OperadorDataSetTableAdapters.operadoresTableAdapter
        Me.BotGenerar = New System.Windows.Forms.Button
        Me.cmbOper = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.Text = "Fecha / Hora:"
        '
        'ColectoresBindingSource
        '
        Me.ColectoresBindingSource.DataMember = "colectores"
        Me.ColectoresBindingSource.DataSource = Me.ColectorDataSet
        '
        'ColectorDataSet
        '
        Me.ColectorDataSet.DataSetName = "ColectorDataSet"
        Me.ColectorDataSet.Prefix = ""
        Me.ColectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtFechaHora
        '
        Me.txtFechaHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtFechaHora.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColectoresBindingSource, "fechahora", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "g"))
        Me.txtFechaHora.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtFechaHora.Location = New System.Drawing.Point(85, 61)
        Me.txtFechaHora.Name = "txtFechaHora"
        Me.txtFechaHora.Size = New System.Drawing.Size(110, 19)
        Me.txtFechaHora.TabIndex = 1
        '
        'txtPrecinto
        '
        Me.txtPrecinto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtPrecinto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColectoresBindingSource, "precinto", True))
        Me.txtPrecinto.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtPrecinto.Location = New System.Drawing.Point(85, 87)
        Me.txtPrecinto.MaxLength = 7
        Me.txtPrecinto.Name = "txtPrecinto"
        Me.txtPrecinto.Size = New System.Drawing.Size(85, 19)
        Me.txtPrecinto.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.Text = "Precinto:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.Text = "Cód. Destino:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(12, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.Text = "Operador:"
        '
        'OperadorDataSetBindingSource
        '
        Me.OperadorDataSetBindingSource.DataSource = Me.OperadorDataSet
        Me.OperadorDataSetBindingSource.Position = 0
        '
        'OperadorDataSet
        '
        Me.OperadorDataSet.DataSetName = "OperadorDataSet"
        Me.OperadorDataSet.Prefix = ""
        Me.OperadorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OperadoresBindingSource
        '
        Me.OperadoresBindingSource.DataMember = "operadores"
        Me.OperadoresBindingSource.DataSource = Me.OperadorDataSetBindingSource
        '
        'LugalmDataSet
        '
        Me.LugalmDataSet.DataSetName = "LugalmDataSet"
        Me.LugalmDataSet.Prefix = ""
        Me.LugalmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LugalmBindingSource1
        '
        Me.LugalmBindingSource1.DataMember = "lugalm"
        Me.LugalmBindingSource1.DataSource = Me.LugalmDataSet
        '
        'cmbCodDes
        '
        Me.cmbCodDes.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ColectoresBindingSource, "cvelugalm", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "''"))
        Me.cmbCodDes.DataSource = Me.LugalmBindingSource1
        Me.cmbCodDes.DisplayMember = "cod"
        Me.cmbCodDes.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.cmbCodDes.Location = New System.Drawing.Point(85, 113)
        Me.cmbCodDes.Name = "cmbCodDes"
        Me.cmbCodDes.Size = New System.Drawing.Size(69, 19)
        Me.cmbCodDes.TabIndex = 3
        Me.cmbCodDes.ValueMember = "cvelugalm"
        '
        'TlBarra
        '
        Me.TlBarra.Buttons.Add(Me.BotGraba)
        Me.TlBarra.Buttons.Add(Me.BotCancela)
        Me.TlBarra.Buttons.Add(Me.BotAgrega)
        Me.TlBarra.Buttons.Add(Me.BotConsulta)
        Me.TlBarra.Buttons.Add(Me.BotSalir)
        Me.TlBarra.Buttons.Add(Me.BotLimpia)
        Me.TlBarra.ImageList = Me.ImageList
        Me.TlBarra.Name = "TlBarra"
        '
        'BotGraba
        '
        Me.BotGraba.ImageIndex = 0
        Me.BotGraba.ToolTipText = "Grabar"
        '
        'BotCancela
        '
        Me.BotCancela.ImageIndex = 1
        Me.BotCancela.ToolTipText = "Cancelar"
        '
        'BotAgrega
        '
        Me.BotAgrega.ImageIndex = 2
        Me.BotAgrega.ToolTipText = "Agregar"
        '
        'BotConsulta
        '
        Me.BotConsulta.ImageIndex = 3
        Me.BotConsulta.ToolTipText = "Consultar"
        '
        'BotSalir
        '
        Me.BotSalir.ImageIndex = 4
        Me.BotSalir.ToolTipText = "Salir"
        '
        'BotLimpia
        '
        Me.BotLimpia.ImageIndex = 5
        Me.BotLimpia.ToolTipText = "Limpiar Todos"
        Me.ImageList.Images.Clear()
        Me.ImageList.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.ImageList.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.ImageList.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.ImageList.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.ImageList.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.ImageList.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        '
        'ColectorDataSetBindingSource
        '
        Me.ColectorDataSetBindingSource.DataMember = "colectores"
        Me.ColectorDataSetBindingSource.DataSource = Me.ColectorDataSet
        '
        'ColectoresTableAdapter
        '
        Me.ColectoresTableAdapter.ClearBeforeFill = True
        '
        'LugalmTableAdapter
        '
        Me.LugalmTableAdapter.ClearBeforeFill = True
        '
        'OperadoresTableAdapter
        '
        Me.OperadoresTableAdapter.ClearBeforeFill = True
        '
        'BotGenerar
        '
        Me.BotGenerar.Location = New System.Drawing.Point(162, 31)
        Me.BotGenerar.Name = "BotGenerar"
        Me.BotGenerar.Size = New System.Drawing.Size(72, 20)
        Me.BotGenerar.TabIndex = 9
        Me.BotGenerar.Text = "Generar"
        '
        'cmbOper
        '
        Me.cmbOper.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ColectoresBindingSource, "cveoper", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "''"))
        Me.cmbOper.DataSource = Me.OperadoresBindingSource
        Me.cmbOper.DisplayMember = "operador"
        Me.cmbOper.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.cmbOper.Location = New System.Drawing.Point(85, 139)
        Me.cmbOper.Name = "cmbOper"
        Me.cmbOper.Size = New System.Drawing.Size(148, 19)
        Me.cmbOper.TabIndex = 15
        Me.cmbOper.ValueMember = "cveoper"
        '
        'Lectura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(245, 175)
        Me.Controls.Add(Me.cmbOper)
        Me.Controls.Add(Me.BotGenerar)
        Me.Controls.Add(Me.cmbCodDes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrecinto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFechaHora)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TlBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lectura"
        Me.Text = "Lecturas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFechaHora As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecinto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColectorDataSet As Colector.ColectorDataSet
    Friend WithEvents ColectoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColectoresTableAdapter As Colector.ColectorDataSetTableAdapters.colectoresTableAdapter
    Friend WithEvents ColectorDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbCodDes As System.Windows.Forms.ComboBox
    Friend WithEvents TlBarra As System.Windows.Forms.ToolBar
    Friend WithEvents BotGraba As System.Windows.Forms.ToolBarButton
    Friend WithEvents BotCancela As System.Windows.Forms.ToolBarButton
    Friend WithEvents BotAgrega As System.Windows.Forms.ToolBarButton
    Friend WithEvents BotConsulta As System.Windows.Forms.ToolBarButton
    Friend WithEvents BotSalir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents LugalmDataSet As Colector.LugalmDataSet
    Friend WithEvents LugalmTableAdapter As Colector.LugalmDataSetTableAdapters.lugalmTableAdapter
    Friend WithEvents OperadorDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperadorDataSet As Colector.OperadorDataSet
    Friend WithEvents OperadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperadoresTableAdapter As Colector.OperadorDataSetTableAdapters.operadoresTableAdapter
    Friend WithEvents LugalmBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BotGenerar As System.Windows.Forms.Button
    Friend WithEvents cmbOper As System.Windows.Forms.ComboBox
    Friend WithEvents BotLimpia As System.Windows.Forms.ToolBarButton
End Class
