Imports SimpleLib
Imports System.Runtime.Serialization
Imports System.Security.Permissions

<Serializable()>
Public Class JobEnableDisable
    Inherits SimpleADJob
    Implements ISerializable

    Private TargetDomainObject As UserDomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New
        JobType = SimpleADJobType.EnableDisable
        JobName = DomainObject.Name
        NewTask(Me)

        TargetDomainObject = DomainObject
        TargetExplorerJob = Job

        If Not TargetDomainObject Is Nothing Then
            EnableDisableObject()
        End If

    End Sub

    Private Sub EnableDisableObject()
        Try
            If IsAccountEnabled(TargetDomainObject) Then
                Dim IsEnableAccountSuccessfull As Integer = EnableADUserUsingUserAccountControl(TargetDomainObject)
                If Not IsEnableAccountSuccessfull = Nothing Then
                    TargetExplorerJob.Refresh()
                End If
            Else
                Dim IsDisnableAccountSuccessfull As Integer = DisableADUserUsingUserAccountControl(TargetDomainObject)
                If Not IsDisnableAccountSuccessfull = Nothing Then
                    TargetExplorerJob.Refresh()
                End If
            End If
            JobStatus = SimpleADJobStatus.Completed
        Catch AccessDenideEx As UnauthorizedAccessException
            JobStatus = SimpleADJobStatus.AccessDenied

            Dim ErrorDialog = New FormAlert("Access Denied", AlertType.ErrorAlert)
            ErrorDialog.Location = GetDialogLocation(ErrorDialog)
            ErrorDialog.ShowDialog()
        Catch Ex As Exception
            JobStatus = SimpleADJobStatus.Failed
            Debug.WriteLine("[Error] Unable to Disable User account though userAccountControl property: " & Ex.Message)
        End Try

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
