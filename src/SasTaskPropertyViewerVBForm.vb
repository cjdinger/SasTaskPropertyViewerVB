Imports SAS.Tasks.Toolkit
Imports SAS.Shared.AddIns
Imports System.Windows.Forms
Imports System.IO
Imports System.Text

''' <summary>
''' The dialog window that allows you to see process flows,
''' tasks, and the task state
''' </summary>
''' <remarks></remarks>
Public Class SasTaskPropertyViewerVBForm : Inherits SAS.Tasks.Toolkit.Controls.TaskForm

    ' keep track of temp files we might create while viewing task XML in external viewers
    Private tempfiles As List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tempfiles = New List(Of String)

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        RefreshProjectContent()
        MyBase.OnLoad(e)
    End Sub

    ' Get the process flow objects from the current project
    Private Sub RefreshProjectContent()
        Dim list As List(Of ISASProjectProcessFlow) = Consumer.GetProject.ProcessFlows
        Me.cmbProcessFlows.DisplayMember = "Name"
        Me.cmbProcessFlows.DataSource = list
        Me.cmbProcessFlows.SelectedIndex = 0
    End Sub

    ' when the process flow selection changes, get the list of tasks within the process flow
    Private Sub OnSelectedFlowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProcessFlows.SelectedIndexChanged
        Dim selectedItem As ISASProjectProcessFlow = TryCast(Me.cmbProcessFlows.SelectedItem, ISASProjectProcessFlow)
        Me.lblTasks.Text = String.Format("Tasks in ""{0}""", selectedItem.Name)
        Me.lbTasks.DisplayMember = "Name"
        Dim tasks As List(Of ISASProjectTask) = selectedItem.GetTasks
        If tasks.Contains(MyBase.Consumer.GetThisTask) Then
            tasks.Remove(MyBase.Consumer.GetThisTask)
        End If
        Me.lbTasks.DataSource = tasks

    End Sub

    ' When the selected task changes, change the task state controls
    Private Sub OnSelectedTaskChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbTasks.SelectedIndexChanged
        Dim selectedItem As ISASProjectTask = TryCast(Me.lbTasks.SelectedItem, ISASProjectTask)
        Dim item As ISASProjectItem = TryCast(Me.lbTasks.SelectedItem, ISASProjectItem)
        If ((Not selectedItem Is Nothing) AndAlso (Not item Is Nothing)) Then
            Me.panelNoTask.Visible = False
            Me.panelNoTask.SendToBack()
            Me.gbProperties.Text = String.Format("Properties for ""{0}""", item.Name)
            Me.pbTaskIcon.Image = item.GetIcon(False).ToBitmap
            Me.lblLastModified.Text = String.Format("Last modified: {0}", item.DateModified.ToShortDateString)
            Me.lblModifiedBy.Text = String.Format("By: {0}", item.ModifiedByUserId)
            Me.lblTaskType.Text = selectedItem.TaskType
            Me.txtInternal.Text = selectedItem.InternalState
            Me.btnViewText.Enabled = Not String.IsNullOrEmpty(selectedItem.InternalState)
            Me.btnViewXml.Enabled = Not String.IsNullOrEmpty(selectedItem.InternalState)
        Else
            Me.gbProperties.Text = "No selected task"
            Me.panelNoTask.Visible = True
            Me.panelNoTask.BringToFront()
        End If

    End Sub

    ' Cancel clicked - Close the window
    ' Clean up any temp files first
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim str As String
        For Each str In Me.tempfiles
            Try
                If File.Exists(str) Then
                    File.Delete(str)
                End If
            Catch
            End Try
        Next
        MyBase.Close()
    End Sub

    ' Project can change while task is open
    ' This allows you to refresh the views
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Me.RefreshProjectContent()
        Catch
            ' May throw exception if a different project is open
            ' so in that case, close the task window
            MessageBox.Show("Cannot refresh the content for this project.  Close this task and try again.")
            Me.btnCancel_Click(Nothing, Nothing)
        End Try
    End Sub

    ' Allow user to view the task state (usually XML) in a text viewer or XML viewer
    Private Sub btnViewExternal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewXml.Click, btnViewText.Click
        Try
            Dim str As String = ".txt"
            If (sender Is Me.btnViewText) Then
                str = ".txt"
            Else
                str = ".xml"
            End If
            Dim tempFileName As String = Path.GetTempFileName
            Dim destFileName As String = String.Format("{0}.{1}", tempFileName, str)
            File.Move(tempFileName, destFileName)
            File.WriteAllText(destFileName, Me.txtInternal.Text, Encoding.Default)
            Me.tempfiles.Add(destFileName)
            Process.Start(destFileName)
        Catch exception As Exception
            MessageBox.Show(String.Format("Unable to create external file: {0}", exception.Message), "Error")
        End Try
    End Sub

End Class