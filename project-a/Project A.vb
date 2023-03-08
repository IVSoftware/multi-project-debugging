Public Class ProjectAForm
    Private Sub ButtonRunProjectB_Click(sender As Object, e As EventArgs) Handles ButtonRunProjectB.Click
        Process.Start("D:\Github\stackoverflow\multi-project-debugging\project-b\bin\Debug\netcoreapp3.1\project-b.exe")
    End Sub
End Class
