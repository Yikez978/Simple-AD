
Imports System.Runtime.Serialization
Imports System.Security.Permissions
Imports SimpleLib

<Serializable()>
Public Class JobPasswordReset
    Inherits SimpleADJob
    Implements ISerializable

    Private TargetUser As UserDomainObject
    Private TargetExplorerJob As JobExplorer

    Public Sub New(ByVal DomainUserObject As DomainObject, ByVal Job As JobExplorer)
        MyBase.New
        JobType = SimpleADJobType.PasswordReset
        JobName = DomainUserObject.Name
        NewTask(Me)

        TargetUser = DomainUserObject
        TargetExplorerJob = Job

        If Not TargetUser Is Nothing Then
            ResetPassword()
        End If
    End Sub

    Private Sub ResetPassword()

        Dim ResetForm = New FormPasswordReset
        ResetForm.Location = GetDialogLocation(ResetForm)
        ResetForm.ShowDialog()

        If ResetForm.DialogResult = DialogResult.Yes Then
            If ResetUserPassword(TargetUser, ResetForm.Password, ResetForm.ForceResetToggle.Checked) = True Then
                JobStatus = SimpleADJobStatus.Completed
                TargetExplorerJob.Refresh()
                Dim ResultForm = New FormAlert("The Password has been reset for user " & TargetUser.Name, AlertType.Success)
                ResultForm.StartPosition = FormStartPosition.CenterScreen
                ResultForm.ShowDialog()
            Else
                JobStatus = SimpleADJobStatus.Failed
                Dim ResultForm = New FormAlert("An Error occured while trying to set the password for user " & TargetUser.Name, AlertType.ErrorAlert)
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
    End Sub

    <SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter:=True)>
    Public Overrides Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        info.AddValue("JobName", JobName)
        info.AddValue("JobType", JobType.ToString)
        info.AddValue("JobOwner", JobOwner)
        info.AddValue("JobCreated", JobCreated)
        info.AddValue("JobDescription", JobDescription)
    End Sub
#End Region

End Class
