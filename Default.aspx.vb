
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Hiya Worldski")
        '* ProcessInfo()
    End Sub

    Public Sub ProcessInfo()
        While 1
            Response.Write("Process Info")
        End While
    End Sub

    Public Sub TestThisNow()
        Response.Write("test")
    End Sub
End Class
