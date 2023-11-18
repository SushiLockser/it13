Module GVAlias_Mod

    Public Sub childForm(ByVal panel As Form)
        sideBar.pagePlaceholder.Controls.Clear()
        panel.TopLevel = False
        sideBar.pagePlaceholder.Controls.Add(panel)
        panel.Show()

    End Sub

End Module
