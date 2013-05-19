Imports Siak.Business.Models

Imports System.Collections.Generic

Imports Siak.BusinessModel.Interfaces

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Siak.Core



'''<summary>
'''This is a test class for GuruCoreTest and is intended
'''to contain all GuruCoreTest Unit Tests
'''</summary>
<TestClass()> _
Public Class GuruCoreTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region



    '''<summary>
    '''A test for GetGuru
    '''</summary>
    <TestMethod()> _
    Public Sub GetGuruTest()
        Dim target As GuruCore = New GuruCore() ' TODO: Initialize to an appropriate value
        Dim id As Integer = 6 ' TODO: Initialize to an appropriate value
        Dim expected As IGuruModel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As IGuruModel
        actual = target.GetGuru(id)
        Assert.AreEqual("Veronica Crosby", actual.Nama)
    End Sub

    '''<summary>
    '''A test for GetListGuru
    '''</summary>
    <TestMethod()> _
    Public Sub GetListGuruTest()
        Dim target As GuruCore = New GuruCore() ' TODO: Initialize to an appropriate value
        Dim actual As IList(Of IGuruModel)
        actual = target.GetListGuru
        Assert.AreEqual(85, actual.Count)
    End Sub

    '''<summary>
    '''A test for GetListGuru
    '''</summary>
    <TestMethod()> _
    Public Sub GetListGuruTest1()
        Dim target As GuruCore = New GuruCore() ' TODO: Initialize to an appropriate value
        Dim namaGuru As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As IList(Of IGuruModel) = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As IList(Of IGuruModel)
        actual = target.GetListGuru(namaGuru)
        Assert.AreEqual(expected, actual)
    End Sub

    '''<summary>
    '''A test for GetListGuru
    '''</summary>
    <TestMethod()> _
    Public Sub GetListGuruTest2()
        Dim target As GuruCore = New GuruCore() ' TODO: Initialize to an appropriate value
        Dim matapelajaranid As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim tahun As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As IList(Of IGuruModel) = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As IList(Of IGuruModel)
        actual = target.GetListGuru(matapelajaranid, tahun)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for SaveGuru
    '''</summary>
    <TestMethod()> _
    Public Sub SaveGuruTest()
        Dim target As GuruCore = New GuruCore() ' TODO: Initialize to an appropriate value
        Dim gurumodel As IGuruModel = Nothing ' TODO: Initialize to an appropriate value
        target.SaveGuru(gurumodel)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SubmitGuruMataPelajaran
    '''</summary>
    <TestMethod()> _
    Public Sub SubmitGuruMataPelajaranTest()
        Dim target As GuruCore = New GuruCore() ' TODO: Initialize to an appropriate value
        Dim mguru As IEnumerable(Of GuruMataPelajaranModel) = Nothing ' TODO: Initialize to an appropriate value
        target.SubmitGuruMataPelajaran(mguru)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for UpdateGuru
    '''</summary>
    <TestMethod()> _
    Public Sub UpdateGuruTest()
        Dim target As GuruCore = New GuruCore() ' TODO: Initialize to an appropriate value
        Dim gurumodel As IGuruModel = Nothing ' TODO: Initialize to an appropriate value
        target.UpdateGuru(gurumodel)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
End Class
