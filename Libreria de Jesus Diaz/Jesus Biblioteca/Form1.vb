
Public Class Form1
    Private books As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean) From {
        {"El principito", True},
        {"Don Quijote de la Mancha", True},
        {"El resplandor", True},
        {"Cementerio de animales", True}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxLibro.Items.AddRange(books.Keys.ToArray())
        ComboBoxDevolver.Items.AddRange(books.Keys.ToArray())
    End Sub

    Private Sub ButtonPrestar_Click(sender As Object, e As EventArgs) Handles ButtonPrestar.Click
        If ComboBoxLibro.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona un libro para prestar.")
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBoxPrestatario.Text) Then
            MessageBox.Show("Por favor, ingresa el nombre del prestatario.")
            Return
        End If

        Dim selectedBook As String = ComboBoxLibro.SelectedItem.ToString()
        Dim prestatario As String = TextBoxPrestatario.Text

        If books(selectedBook) Then
            books(selectedBook) = False
            MessageBox.Show($"{prestatario} ha prestado '{selectedBook}' exitosamente.")
        Else
            MessageBox.Show($"Lo siento, '{selectedBook}' ya está prestado.")
        End If
    End Sub

    Private Sub ButtonDevolver_Click(sender As Object, e As EventArgs) Handles ButtonDevolver.Click
        If ComboBoxDevolver.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona un libro para devolver.")
            Return
        End If

        Dim selectedBook As String = ComboBoxDevolver.SelectedItem.ToString()

        If Not books(selectedBook) Then
            books(selectedBook) = True
            MessageBox.Show($"'{selectedBook}' ha sido devuelto exitosamente.")
        Else
            MessageBox.Show($"'{selectedBook}' ya está en la biblioteca.")
        End If
    End Sub
End Class
