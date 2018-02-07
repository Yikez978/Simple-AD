Imports System.Windows.Forms
Imports SimpleLib

Public Class TaskNewOu
    Inherits ActiveTask

    Private TargetExplorerJob As TaskExplorer
    Private TargetContainer As String
    Private NewOuName As String

    Private NewOuForm As FormNewOu

    Private Delegate Sub Delegate_NewOrganizationalUnit(ByVal Result As SimpleResult)

    Public Sub New(ByVal Container As String, ByVal Job As TaskExplorer)
        MyBase.New
        TaskType = ActiveTaskType.NewOu
        TaskName = "New Organizational Unit"

        TargetExplorerJob = Job
        TargetContainer = Container

        If Not TargetContainer Is Nothing Then

            NewOuForm = New FormNewOu

            With NewOuForm
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With

            If NewOuForm.DialogResult = DialogResult.Yes Then
                NewOuName = NewOuForm.OuName
                Threading.ThreadPool.QueueUserWorkItem(Sub() NewOrganizationalUnit(TargetContainer, NewOuForm.OuName))
            Else
                TaskStatus = ActiveTaskStatus.Canceled
            End If

        End If

    End Sub

    Private Sub NewOrganizationalUnit(ByVal Container As String, ByVal Name As String)
        Dim Result As SimpleResult = CreateNewOu(Container, Name)

        If GetContainerExplorer.InvokeRequired Then
            GetContainerExplorer.Invoke(New Delegate_NewOrganizationalUnit(AddressOf NewOrganizationalUnitFinished), Result)
        End If
    End Sub

    Private Sub NewOrganizationalUnitFinished(ByVal Result As SimpleResult)

        Debug.WriteLine("[Info] New Organizational Unit Request Finished with state: " & Result.Status.ToString)

        If Result.IsSuccess = True Then
            TaskStatus = ActiveTaskStatus.Completed

            Dim NewNode As TreeNode = GetMainDomainTreeView.SelectedNode.Nodes.Add(NewOuName)

            With NewNode
                NewNode.Tag = ADNodeType.OU
                NewNode.ImageKey = "OuImage"
                NewNode.SelectedImageKey = "OuImage"
                NewNode.ToolTipText = String.Format("OU={0},{1}", NewOuName, GetMainDomainTreeView.SelectedNode.Name)
            End With

            GetMainDomainTreeView.SelectedNode.Expand()
            NewNode.EnsureVisible()

        Else

            Dim Message As String = String.Empty
            Dim MessageType As AlertType = AlertType.ErrorAlert

            If Result.Status = ActiveTaskStatus.AccessDenied Then
                Message = "Unable create new organizational unit in the seleceted directory, access is denied"
                MessageType = AlertType.AccessDenied
            Else
                Message = "An Error occured while trying to create the organizational unit"
            End If

            Dim ResultForm As FormAlert = New FormAlert(Message, MessageType) With {
                .StartPosition = FormStartPosition.CenterScreen
                }

            ResultForm.ShowDialog()

        End If

    End Sub


End Class

