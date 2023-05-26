
Public Class KRviewer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        lblWhatisViewed.Text = Path.GetFileName(KRCST_FileExtracted)
        PopulateLViewer()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(fileopened As String, FileList() As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Friend Sub PopulateLViewer()
        Dim subItems() As ListViewItem.ListViewSubItem
        Dim item As ListViewItem = Nothing
        Dim file As FileInfo
        Dim dirinfo As New DirectoryInfo(KRCST_PassPath)
        For Each file In dirinfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)
            item = New ListViewItem(file.Name)
            Dim fsize As String = ToFileSizeApi(file.Length)
            subItems = New ListViewItem.ListViewSubItem() _
            {New ListViewItem.ListViewSubItem(item, fsize), New ListViewItem.ListViewSubItem(item, file.Extension), New ListViewItem.ListViewSubItem(item, file.FullName)}
            item.SubItems.AddRange(subItems)
            lvKRCSTViewer.Items.Add(item)
        Next file
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim indexes As ListView.SelectedIndexCollection = Me.lvKRCSTViewer.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            Dim filetoopen = lvKRCSTViewer.Items(index).SubItems(3).Text
            Process.Start(filetoopen)
        Next
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim dirSelected As String = String.Empty
        Dim indexes As ListView.SelectedIndexCollection = Me.lvKRCSTViewer.SelectedIndices
        Dim index As Integer
        Dim counter As Integer
        If System.IO.Directory.Exists(My.Settings.mappaExtract) Then dirSelected = MappaBeállító.ValasszKonyvtarat(My.Settings.mappaExtract)
        If dirSelected <> "" Then
            For Each index In indexes
                Dim filetocopy = lvKRCSTViewer.Items(index).SubItems(3).Text
                Try
                    System.IO.File.Copy(filetocopy, dirSelected & Path.DirectorySeparatorChar & Path.GetFileName(filetocopy))
                    counter += 1
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            MyLoader.AddLogBook(Fnc.extr, "Kimásolva " & indexes.Count & " fájlból " & counter & " fájl a " & dirSelected & " célkönyvtárba.", LogTip.norm)
        End If
    End Sub

    Private Sub lvKRCSTViewer_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvKRCSTViewer.MouseDoubleClick
        Process.Start(lvKRCSTViewer.HitTest(e.X, e.Y).Item.SubItems(3).Text)
    End Sub

    Private Sub lvKRCSTViewer_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles lvKRCSTViewer.ItemDrag
        Dim strFullPath As String = String.Empty
        Dim Lview As ListView = sender
        Dim items As ListView.SelectedListViewItemCollection = Lview.SelectedItems
        Dim DropList As New Specialized.StringCollection
        For Each item As ListViewItem In items
            strFullPath = item.SubItems(3).Text
            Dim FtoDrop As FileInfo = New FileInfo(strFullPath)
            DropList.Add(strFullPath)
        Next
        Dim DragPaths As New DataObject()
        DragPaths.SetFileDropList(DropList)
        DoDragDrop(DragPaths, DragDropEffects.Copy)
    End Sub
End Class