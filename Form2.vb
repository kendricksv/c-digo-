Public Class Form2
    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Tabla1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tabla1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database5DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database5DataSet.Tabla1' Puede moverla o quitarla según sea necesario.
        Me.Tabla1TableAdapter.Fill(Me.Database5DataSet.Tabla1)

    End Sub



    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Tabla1TableAdapter.borrar(tbx_id.Text)
        Me.Tabla1TableAdapter.Fill(Me.Database5DataSet.Tabla1)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles tbn_editar.Click
        Tabla1TableAdapter.editar(tbx_titulo.Text, tbx_autor.Text, tbx_fecha.Text, tbx_editorial.Text, tbx_genero.Text, tbx_id.Text)
        Me.Tabla1TableAdapter.Fill(Me.Database5DataSet.Tabla1)
    End Sub

    Private Sub tbn_agregar_Click(sender As Object, e As EventArgs) Handles tbn_agregar.Click
        Tabla1TableAdapter.agregar(tbx_titulo.Text, tbx_autor.Text, tbx_fecha.Text, tbx_editorial.Text, tbx_genero.Text)
        Me.Tabla1TableAdapter.Fill(Me.Database5DataSet.Tabla1)
    End Sub

    Private Sub tbn_guardar_Click(sender As Object, e As EventArgs) Handles tbn_guardar.Click
        Tabla1BindingSource.EndEdit()
        MsgBox("Guardado", MsgBoxStyle.Information, "")
        Me.Tabla1TableAdapter.Fill(Me.Database5DataSet.Tabla1)
    End Sub
End Class