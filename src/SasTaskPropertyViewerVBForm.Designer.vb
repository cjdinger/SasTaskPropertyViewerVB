<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SasTaskPropertyViewerVBForm
    Inherits SAS.Tasks.Toolkit.Controls.TaskForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblLastModified = New System.Windows.Forms.Label()
        Me.lblModifiedBy = New System.Windows.Forms.Label()
        Me.gbProperties = New System.Windows.Forms.GroupBox()
        Me.lblTaskType = New System.Windows.Forms.Label()
        Me.lblInternal = New System.Windows.Forms.Label()
        Me.txtInternal = New System.Windows.Forms.TextBox()
        Me.btnViewXml = New System.Windows.Forms.Button()
        Me.btnViewText = New System.Windows.Forms.Button()
        Me.pbTaskIcon = New System.Windows.Forms.PictureBox()
        Me.panelNoTask = New System.Windows.Forms.Panel()
        Me.lbTasks = New System.Windows.Forms.ListBox()
        Me.lblFlows = New System.Windows.Forms.Label()
        Me.cmbProcessFlows = New System.Windows.Forms.ComboBox()
        Me.lblTasks = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbProperties.SuspendLayout()
        CType(Me.pbTaskIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNoTask.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(11, 267)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 23)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh Contents"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.label2.Location = New System.Drawing.Point(0, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(267, 231)
        Me.label2.TabIndex = 0
        Me.label2.Text = "No task selected"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastModified
        '
        Me.lblLastModified.AutoSize = True
        Me.lblLastModified.Location = New System.Drawing.Point(48, 16)
        Me.lblLastModified.Name = "lblLastModified"
        Me.lblLastModified.Size = New System.Drawing.Size(72, 13)
        Me.lblLastModified.TabIndex = 0
        Me.lblLastModified.Text = "Last modified:"
        '
        'lblModifiedBy
        '
        Me.lblModifiedBy.AutoSize = True
        Me.lblModifiedBy.Location = New System.Drawing.Point(48, 35)
        Me.lblModifiedBy.Name = "lblModifiedBy"
        Me.lblModifiedBy.Size = New System.Drawing.Size(64, 13)
        Me.lblModifiedBy.TabIndex = 1
        Me.lblModifiedBy.Text = "Modified by:"
        '
        'gbProperties
        '
        Me.gbProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProperties.Controls.Add(Me.lblLastModified)
        Me.gbProperties.Controls.Add(Me.lblModifiedBy)
        Me.gbProperties.Controls.Add(Me.lblTaskType)
        Me.gbProperties.Controls.Add(Me.lblInternal)
        Me.gbProperties.Controls.Add(Me.txtInternal)
        Me.gbProperties.Controls.Add(Me.btnViewXml)
        Me.gbProperties.Controls.Add(Me.btnViewText)
        Me.gbProperties.Controls.Add(Me.pbTaskIcon)
        Me.gbProperties.Controls.Add(Me.panelNoTask)
        Me.gbProperties.Location = New System.Drawing.Point(224, 10)
        Me.gbProperties.Name = "gbProperties"
        Me.gbProperties.Size = New System.Drawing.Size(273, 250)
        Me.gbProperties.TabIndex = 11
        Me.gbProperties.TabStop = False
        Me.gbProperties.Text = "Properties"
        '
        'lblTaskType
        '
        Me.lblTaskType.AutoSize = True
        Me.lblTaskType.Location = New System.Drawing.Point(7, 51)
        Me.lblTaskType.Name = "lblTaskType"
        Me.lblTaskType.Size = New System.Drawing.Size(58, 13)
        Me.lblTaskType.TabIndex = 2
        Me.lblTaskType.Text = "Task Type"
        '
        'lblInternal
        '
        Me.lblInternal.AutoSize = True
        Me.lblInternal.Location = New System.Drawing.Point(7, 77)
        Me.lblInternal.Name = "lblInternal"
        Me.lblInternal.Size = New System.Drawing.Size(73, 13)
        Me.lblInternal.TabIndex = 3
        Me.lblInternal.Text = "Internal State:"
        '
        'txtInternal
        '
        Me.txtInternal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInternal.Location = New System.Drawing.Point(10, 93)
        Me.txtInternal.Multiline = True
        Me.txtInternal.Name = "txtInternal"
        Me.txtInternal.ReadOnly = True
        Me.txtInternal.Size = New System.Drawing.Size(257, 122)
        Me.txtInternal.TabIndex = 4
        '
        'btnViewXml
        '
        Me.btnViewXml.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnViewXml.Location = New System.Drawing.Point(10, 221)
        Me.btnViewXml.Name = "btnViewXml"
        Me.btnViewXml.Size = New System.Drawing.Size(73, 23)
        Me.btnViewXml.TabIndex = 5
        Me.btnViewXml.Text = "View XML"
        Me.btnViewXml.UseVisualStyleBackColor = True
        '
        'btnViewText
        '
        Me.btnViewText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnViewText.Location = New System.Drawing.Point(89, 221)
        Me.btnViewText.Name = "btnViewText"
        Me.btnViewText.Size = New System.Drawing.Size(73, 23)
        Me.btnViewText.TabIndex = 6
        Me.btnViewText.Text = "View text"
        Me.btnViewText.UseVisualStyleBackColor = True
        '
        'pbTaskIcon
        '
        Me.pbTaskIcon.Location = New System.Drawing.Point(10, 16)
        Me.pbTaskIcon.Name = "pbTaskIcon"
        Me.pbTaskIcon.Size = New System.Drawing.Size(32, 32)
        Me.pbTaskIcon.TabIndex = 1
        Me.pbTaskIcon.TabStop = False
        '
        'panelNoTask
        '
        Me.panelNoTask.Controls.Add(Me.label2)
        Me.panelNoTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelNoTask.Location = New System.Drawing.Point(3, 16)
        Me.panelNoTask.Name = "panelNoTask"
        Me.panelNoTask.Size = New System.Drawing.Size(267, 231)
        Me.panelNoTask.TabIndex = 7
        '
        'lbTasks
        '
        Me.lbTasks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbTasks.FormattingEnabled = True
        Me.lbTasks.Location = New System.Drawing.Point(11, 87)
        Me.lbTasks.Name = "lbTasks"
        Me.lbTasks.Size = New System.Drawing.Size(207, 173)
        Me.lbTasks.TabIndex = 10
        '
        'lblFlows
        '
        Me.lblFlows.AutoSize = True
        Me.lblFlows.Location = New System.Drawing.Point(11, 10)
        Me.lblFlows.Name = "lblFlows"
        Me.lblFlows.Size = New System.Drawing.Size(102, 13)
        Me.lblFlows.TabIndex = 7
        Me.lblFlows.Text = "Select process flow:"
        '
        'cmbProcessFlows
        '
        Me.cmbProcessFlows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProcessFlows.FormattingEnabled = True
        Me.cmbProcessFlows.Location = New System.Drawing.Point(11, 29)
        Me.cmbProcessFlows.Name = "cmbProcessFlows"
        Me.cmbProcessFlows.Size = New System.Drawing.Size(207, 21)
        Me.cmbProcessFlows.TabIndex = 8
        '
        'lblTasks
        '
        Me.lblTasks.AutoSize = True
        Me.lblTasks.Location = New System.Drawing.Point(11, 68)
        Me.lblTasks.Name = "lblTasks"
        Me.lblTasks.Size = New System.Drawing.Size(72, 13)
        Me.lblTasks.TabIndex = 9
        Me.lblTasks.Text = "Tasks in flow:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(441, 271)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SasTaskPropertyViewerVBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 305)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.gbProperties)
        Me.Controls.Add(Me.lbTasks)
        Me.Controls.Add(Me.lblFlows)
        Me.Controls.Add(Me.cmbProcessFlows)
        Me.Controls.Add(Me.lblTasks)
        Me.Controls.Add(Me.btnCancel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SasTaskPropertyViewerVBForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Task Property Viewer (VB)"
        Me.gbProperties.ResumeLayout(False)
        Me.gbProperties.PerformLayout()
        CType(Me.pbTaskIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNoTask.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnRefresh As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents lblLastModified As System.Windows.Forms.Label
    Private WithEvents lblModifiedBy As System.Windows.Forms.Label
    Private WithEvents gbProperties As System.Windows.Forms.GroupBox
    Private WithEvents lblTaskType As System.Windows.Forms.Label
    Private WithEvents lblInternal As System.Windows.Forms.Label
    Private WithEvents txtInternal As System.Windows.Forms.TextBox
    Private WithEvents btnViewXml As System.Windows.Forms.Button
    Private WithEvents btnViewText As System.Windows.Forms.Button
    Private WithEvents pbTaskIcon As System.Windows.Forms.PictureBox
    Private WithEvents panelNoTask As System.Windows.Forms.Panel
    Private WithEvents lbTasks As System.Windows.Forms.ListBox
    Private WithEvents lblFlows As System.Windows.Forms.Label
    Private WithEvents cmbProcessFlows As System.Windows.Forms.ComboBox
    Private WithEvents lblTasks As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
End Class
