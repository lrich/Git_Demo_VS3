
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Hiya World")
    End Sub

    Public Sub ProcessInfo()
        While 1
            Response.Write("Process Info")
        End While
    End Sub
End Class
