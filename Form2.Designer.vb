<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TituloLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim EditorialLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.Tabla1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tabla1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database5DataSet = New WindowsApp4.Database5DataSet()
        Me.tbx_titulo = New System.Windows.Forms.TextBox()
        Me.tbx_autor = New System.Windows.Forms.TextBox()
        Me.tbx_fecha = New System.Windows.Forms.DateTimePicker()
        Me.tbx_id = New System.Windows.Forms.TextBox()
        Me.tbx_editorial = New System.Windows.Forms.TextBox()
        Me.tbx_genero = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.tbn_guardar = New System.Windows.Forms.Button()
        Me.tbn_editar = New System.Windows.Forms.Button()
        Me.tbn_agregar = New System.Windows.Forms.Button()
        Me.Tabla1TableAdapter = New WindowsApp4.Database5DataSetTableAdapters.Tabla1TableAdapter()
        Me.TableAdapterManager = New WindowsApp4.Database5DataSetTableAdapters.TableAdapterManager()
        TituloLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        EditorialLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        CType(Me.Tabla1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(157, 305)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(36, 13)
        TituloLabel.TabIndex = 4
        TituloLabel.Text = "Titulo:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(328, 256)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 6
        AutorLabel.Text = "Autor:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(323, 305)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 8
        FechaLabel.Text = "Fecha:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(174, 256)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 9
        IdLabel.Text = "Id:"
        '
        'EditorialLabel
        '
        EditorialLabel.AutoSize = True
        EditorialLabel.Location = New System.Drawing.Point(499, 256)
        EditorialLabel.Name = "EditorialLabel"
        EditorialLabel.Size = New System.Drawing.Size(47, 13)
        EditorialLabel.TabIndex = 10
        EditorialLabel.Text = "Editorial:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(501, 305)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 12
        GeneroLabel.Text = "Genero:"
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Location = New System.Drawing.Point(737, 379)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(75, 23)
        Me.btn_siguiente.TabIndex = 0
        Me.btn_siguiente.Text = "Creditos"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'Tabla1DataGridView
        '
        Me.Tabla1DataGridView.AutoGenerateColumns = False
        Me.Tabla1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Tabla1DataGridView.DataSource = Me.Tabla1BindingSource
        Me.Tabla1DataGridView.Location = New System.Drawing.Point(79, 12)
        Me.Tabla1DataGridView.Name = "Tabla1DataGridView"
        Me.Tabla1DataGridView.Size = New System.Drawing.Size(641, 220)
        Me.Tabla1DataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Titulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Titulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Editorial"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Editorial"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Genero"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Genero"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Tabla1BindingSource
        '
        Me.Tabla1BindingSource.DataMember = "Tabla1"
        Me.Tabla1BindingSource.DataSource = Me.Database5DataSet
        '
        'Database5DataSet
        '
        Me.Database5DataSet.DataSetName = "Database5DataSet"
        Me.Database5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbx_titulo
        '
        Me.tbx_titulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Titulo", True))
        Me.tbx_titulo.Location = New System.Drawing.Point(199, 302)
        Me.tbx_titulo.Name = "tbx_titulo"
        Me.tbx_titulo.Size = New System.Drawing.Size(100, 20)
        Me.tbx_titulo.TabIndex = 5
        '
        'tbx_autor
        '
        Me.tbx_autor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Autor", True))
        Me.tbx_autor.Location = New System.Drawing.Point(369, 253)
        Me.tbx_autor.Name = "tbx_autor"
        Me.tbx_autor.Size = New System.Drawing.Size(100, 20)
        Me.tbx_autor.TabIndex = 7
        '
        'tbx_fecha
        '
        Me.tbx_fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tabla1BindingSource, "Fecha", True))
        Me.tbx_fecha.Location = New System.Drawing.Point(369, 302)
        Me.tbx_fecha.Name = "tbx_fecha"
        Me.tbx_fecha.Size = New System.Drawing.Size(100, 20)
        Me.tbx_fecha.TabIndex = 9
        '
        'tbx_id
        '
        Me.tbx_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Id", True))
        Me.tbx_id.Location = New System.Drawing.Point(199, 253)
        Me.tbx_id.Name = "tbx_id"
        Me.tbx_id.Size = New System.Drawing.Size(100, 20)
        Me.tbx_id.TabIndex = 10
        '
        'tbx_editorial
        '
        Me.tbx_editorial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Editorial", True))
        Me.tbx_editorial.Location = New System.Drawing.Point(552, 253)
        Me.tbx_editorial.Name = "tbx_editorial"
        Me.tbx_editorial.Size = New System.Drawing.Size(100, 20)
        Me.tbx_editorial.TabIndex = 11
        '
        'tbx_genero
        '
        Me.tbx_genero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Genero", True))
        Me.tbx_genero.Location = New System.Drawing.Point(552, 302)
        Me.tbx_genero.Name = "tbx_genero"
        Me.tbx_genero.Size = New System.Drawing.Size(100, 20)
        Me.tbx_genero.TabIndex = 13
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(129, 355)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 14
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'tbn_guardar
        '
        Me.tbn_guardar.Location = New System.Drawing.Point(305, 355)
        Me.tbn_guardar.Name = "tbn_guardar"
        Me.tbn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.tbn_guardar.TabIndex = 15
        Me.tbn_guardar.Text = "Guardar"
        Me.tbn_guardar.UseVisualStyleBackColor = True
        '
        'tbn_editar
        '
        Me.tbn_editar.Location = New System.Drawing.Point(471, 355)
        Me.tbn_editar.Name = "tbn_editar"
        Me.tbn_editar.Size = New System.Drawing.Size(75, 23)
        Me.tbn_editar.TabIndex = 16
        Me.tbn_editar.Text = "Editar"
        Me.tbn_editar.UseVisualStyleBackColor = True
        '
        'tbn_agregar
        '
        Me.tbn_agregar.Location = New System.Drawing.Point(617, 355)
        Me.tbn_agregar.Name = "tbn_agregar"
        Me.tbn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.tbn_agregar.TabIndex = 17
        Me.tbn_agregar.Text = "Agregar"
        Me.tbn_agregar.UseVisualStyleBackColor = True
        '
        'Tabla1TableAdapter
        '
        Me.Tabla1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tabla1TableAdapter = Me.Tabla1TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp4.Database5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 450)
        Me.Controls.Add(Me.tbn_agregar)
        Me.Controls.Add(Me.tbn_editar)
        Me.Controls.Add(Me.tbn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.tbx_genero)
        Me.Controls.Add(EditorialLabel)
        Me.Controls.Add(Me.tbx_editorial)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.tbx_id)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.tbx_fecha)
        Me.Controls.Add(AutorLabel)
        Me.Controls.Add(Me.tbx_autor)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.tbx_titulo)
        Me.Controls.Add(Me.Tabla1DataGridView)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.Tabla1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_siguiente As Button
    Friend WithEvents Database5DataSet As Database5DataSet
    Friend WithEvents Tabla1BindingSource As BindingSource
    Friend WithEvents Tabla1TableAdapter As Database5DataSetTableAdapters.Tabla1TableAdapter
    Friend WithEvents TableAdapterManager As Database5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tabla1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents tbx_titulo As TextBox
    Friend WithEvents tbx_autor As TextBox
    Friend WithEvents tbx_fecha As DateTimePicker
    Friend WithEvents tbx_id As TextBox
    Friend WithEvents tbx_editorial As TextBox
    Friend WithEvents tbx_genero As TextBox
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents tbn_guardar As Button
    Friend WithEvents tbn_editar As Button
    Friend WithEvents tbn_agregar As Button
End Class
