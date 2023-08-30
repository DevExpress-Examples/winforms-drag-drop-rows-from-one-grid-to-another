Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DragDropTwoGrids

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private dataSet1 As DataSet

        Private gridControl1 As GridControl

        Private gridView1 As GridView

        Private gridControl2 As GridControl

        Private gridView2 As GridView

        Private splitter1 As Splitter

        Private dataTable1 As DataTable

        Private dataColumn1 As DataColumn

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            dataSet1 = New DataSet()
            dataTable1 = New DataTable()
            dataColumn1 = New DataColumn()
            gridControl1 = New GridControl()
            gridView1 = New GridView()
            gridControl2 = New GridControl()
            gridView2 = New GridView()
            splitter1 = New Splitter()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataSet1
            ' 
            dataSet1.DataSetName = "NewDataSet"
            dataSet1.Locale = New Globalization.CultureInfo("en-US")
            dataSet1.Tables.AddRange(New DataTable() {dataTable1})
            ' 
            ' dataTable1
            ' 
            dataTable1.Columns.AddRange(New DataColumn() {dataColumn1})
            dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            dataColumn1.ColumnName = "Column1"
            ' 
            ' gridControl1
            ' 
            gridControl1.Dock = DockStyle.Left
            ' 
            ' gridControl1.EmbeddedNavigator
            ' 
            gridControl1.EmbeddedNavigator.Name = ""
            gridControl1.Location = New System.Drawing.Point(0, 0)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New System.Drawing.Size(240, 282)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New BaseView() {gridView1})
            ' 
            ' gridView1
            ' 
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            ' 
            ' gridControl2
            ' 
            gridControl2.Dock = DockStyle.Fill
            ' 
            ' gridControl2.EmbeddedNavigator
            ' 
            gridControl2.EmbeddedNavigator.Name = ""
            gridControl2.Location = New System.Drawing.Point(240, 0)
            gridControl2.MainView = gridView2
            gridControl2.Name = "gridControl2"
            gridControl2.Size = New System.Drawing.Size(248, 282)
            gridControl2.TabIndex = 1
            gridControl2.ViewCollection.AddRange(New BaseView() {gridView2})
            ' 
            ' gridView2
            ' 
            gridView2.GridControl = gridControl2
            gridView2.Name = "gridView2"
            ' 
            ' splitter1
            ' 
            splitter1.Location = New System.Drawing.Point(240, 0)
            splitter1.Name = "splitter1"
            splitter1.Size = New System.Drawing.Size(2, 282)
            splitter1.TabIndex = 2
            splitter1.TabStop = False
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(488, 282)
            Me.Controls.Add(splitter1)
            Me.Controls.Add(gridControl2)
            Me.Controls.Add(gridControl1)
            Name = "Form1"
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillTable(dataTable1)
            SetUpGrid(gridControl1)
            SetUpGrid(gridControl2)
            gridControl1.DataSource = dataTable1
            gridControl2.DataSource = dataTable1.Clone()
        End Sub

        Public Sub FillTable(ByVal table As DataTable)
            For i As Integer = 1 To 5
                table.Rows.Add(New Object() {"Item " & i.ToString()})
            Next
        End Sub

        Public Sub SetUpGrid(ByVal grid As GridControl)
            grid.AllowDrop = True
            AddHandler grid.DragOver, New DragEventHandler(AddressOf grid_DragOver)
            AddHandler grid.DragDrop, New DragEventHandler(AddressOf grid_DragDrop)
            Dim view As GridView = TryCast(grid.MainView, GridView)
            view.OptionsBehavior.Editable = False
            AddHandler view.MouseMove, New MouseEventHandler(AddressOf view_MouseMove)
            AddHandler view.MouseDown, New MouseEventHandler(AddressOf view_MouseDown)
        End Sub

        Private downHitInfo As GridHitInfo = Nothing

        Private Sub view_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            downHitInfo = Nothing
            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ModifierKeys <> Keys.None Then Return
            If e.Button = MouseButtons.Left AndAlso hitInfo.RowHandle >= 0 Then downHitInfo = hitInfo
        End Sub

        Private Sub view_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
                Dim dragSize As Size = SystemInformation.DragSize
                Dim dragRect As Rectangle = New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width \ 2, downHitInfo.HitPoint.Y - dragSize.Height \ 2), dragSize)
                If Not dragRect.Contains(New Point(e.X, e.Y)) Then
                    Dim row As DataRow = view.GetDataRow(downHitInfo.RowHandle)
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move)
                    downHitInfo = Nothing
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
                End If
            End If
        End Sub

        Private Sub grid_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(GetType(DataRow)) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        End Sub

        Private Sub grid_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim grid As GridControl = TryCast(sender, GridControl)
            Dim table As DataTable = TryCast(grid.DataSource, DataTable)
            Dim row As DataRow = TryCast(e.Data.GetData(GetType(DataRow)), DataRow)
            If row IsNot Nothing AndAlso table IsNot Nothing AndAlso row.Table IsNot table Then
                table.ImportRow(row)
                row.Delete()
            End If
        End Sub
    End Class
End Namespace
