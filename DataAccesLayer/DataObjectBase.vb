Public MustInherit Class DataObjectBase(Of T)
    Implements IDisposable

    Public MustOverride Function GetList() As IList(Of T)
    Public MustOverride Function Gets(id As Integer) As T
    Public MustOverride Sub Insert(model As T)
    Public MustOverride Sub Update(model As T)
    Public MustOverride Sub Delete(id As Integer)

    Public Overridable Sub Dispose() Implements IDisposable.Dispose

    End Sub
End Class
