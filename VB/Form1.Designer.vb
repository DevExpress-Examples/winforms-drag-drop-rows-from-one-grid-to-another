Namespace DragDropTwoGrids

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(307, 445)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.behaviorManager1.SetBehaviors(Me.gridView1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), True, True, True)), DevExpress.Utils.Behaviors.Behavior)})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Location = New System.Drawing.Point(307, 0)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(5, 445)
            Me.splitterControl1.TabIndex = 1
            Me.splitterControl1.TabStop = False
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl2.Location = New System.Drawing.Point(312, 0)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.Size = New System.Drawing.Size(325, 445)
            Me.gridControl2.TabIndex = 2
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.behaviorManager1.SetBehaviors(Me.gridView2, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), True, True, True)), DevExpress.Utils.Behaviors.Behavior)})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            ' 
            ' Form2
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(637, 445)
            Me.Controls.Add(Me.gridControl2)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form2"
            Me.Text = "Form2"
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    End Class
End Namespace
