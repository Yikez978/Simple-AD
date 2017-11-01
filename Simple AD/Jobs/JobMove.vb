Imports SimpleLib
Imports System.Runtime.Serialization
Imports System.Security.Permissions

<Serializable()>
Public Class JobMove
    Inherits SimpleADJob
    Implements ISerializable

    Private TargetDomainObject As DomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New
        JobType = SimpleADJobType.Move
        JobName = DomainObject.Name

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            NewTask(Me)
            MoveObject()
        End If

    End Sub

    Private Sub MoveObject()

        Dim MoveForm = New FormMoveObject
        MoveForm.Location = GetDialogLocation(MoveForm)
        MoveForm.ShowDialog()
        If MoveForm.DialogResult = DialogResult.Yes Then
            If MoveADObject(TargetDomainObject, MoveForm.SelecetdOU) = True Then
                JobStatus = SimpleADJobStatus.Completed
                TargetExplorerJob.Refresh()
                Dim ResultForm = New FormAlert(TargetDomainObject.Name & " has been moved to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.Success) With {.Location = GetDialogLocation(MoveForm)}
                ResultForm.StartPosition = FormStartPosition.CenterScreen
                ResultForm.ShowDialog()
            Else
                JobStatus = SimpleADJobStatus.Failed
                Dim ResultForm = New FormAlert("An Error occured while trying to move " & TargetDomainObject.Name & " to:" & Environment.NewLine & MoveForm.SelecetdOU, AlertType.ErrorAlert) With {.Location = GetDialogLocation(MoveForm)}
                ResultForm.StartPosition = FormStartPosition.CenterScreen
                ResultForm.ShowDialog()
            End If
        Else
            JobStatus = SimpleADJobStatus.Canceled
        End If

    End Sub

#Region "Serialisation"
    Protected Sub New(info As SerializationInfo, context As StreamingContext)
        JobName = info.GetString("JobName")
        JobType = DirectCast([Enum].Parse(GetType(SimpleADJobType), info.GetString("JobType")), SimpleADJobType)
        JobOwner = info.GetString("JobOwner")
        JobCreated = info.GetDateTime("JobCreated")
        JobDescription = info.GetString("JobDescription")
        JobStatus = DirectCast([Enum].Parse(GetType(SimpleADJobStatus), info.GetString("JobStatus")), SimpleADJobStatus)
    End Sub

    <SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter:=True)>
    Public Overrides Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        info.AddValue("JobName", JobName)
        info.AddValue("JobType", JobType.ToString)
        info.AddValue("JobOwner", JobOwner)
        info.AddValue("JobCreated", JobCreated)
        info.AddValue("JobDescription", JobDescription)
        info.AddValue("JobStatus", JobStatus)
    End Sub
#End Region

End Class
