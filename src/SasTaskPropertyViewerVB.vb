Imports SAS.Shared.AddIns
Imports SAS.Tasks.Toolkit
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml.Serialization

<ClassId("dfc12ddc-7863-48c1-86dc-17ce514a1ccd")> _
<IconLocation("SASPress.ExamplesVB.task.ico")> _
<InputRequired(InputResourceType.None)> _
Public Class SasTaskPropertyViewerVB : Inherits SAS.Tasks.Toolkit.SasTask

    ' There isn't much to this class
    ' all this part does is to launch the window that shows 
    ' the task properties for the tasks
    ' that are in the current project

#Region "Initialization"

    Sub New()
        InitializeComponent()
    End Sub

    Sub InitializeComponent()
        '
        'SasTaskPropertyViewerVB
        '
        Me.GeneratesReportOutput = False
        Me.GeneratesSasCode = False
        Me.ProductsRequired = "BASE"
        Me.TaskCategory = "SAS Press Examples"
        Me.TaskDescription = "View the contents of tasks in your project file"
        Me.TaskName = "Task Property Viewer (VB)"

    End Sub

#End Region

#Region "Overrides"

    ' This function is called when it's time to show the task window
    Public Overrides Function Show(ByVal Owner As IWin32Window) As SAS.Shared.AddIns.ShowResult
        Dim form As New SasTaskPropertyViewerVBForm
        form.Consumer = Consumer
        form.Show(Owner)
        Return ShowResult.Canceled
    End Function


#End Region

End Class
