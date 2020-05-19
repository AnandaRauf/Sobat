Public Class HalamanLoading

    Private Sub HalamanLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        MessageBox.Show("Selamat datang di Sobat (Software Bucin Authentik) ^-^")
        MessageBox.Show("Mohon tunggu loadingnya kakak ganteng dan cantik >_< ")

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If LoadingProgressBucin.Value < 100 Then
            LoadingProgressBucin.Value += 1
        Else LoadingProgressBucin.Value = 100
            Timer1.Stop()

            MessageBox.Show("Loading Complete kakak ^-^", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loadingcompletenotif.Show()
        End If

        If LoadingProgressBucin.Value = 1 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 10 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 15 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 20 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 25 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 30 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 35 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 40 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 45 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 50 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 55 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 60 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 65 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 70 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 75 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 80 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 85 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 90 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 95 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
            PictureLoading.ImageLocation = "https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif"
        ElseIf LoadingProgressBucin.Value = 100 Then
            Status_loadingLBL.ForeColor = Color.Green
            Status_loadingLBL.Text = "Loading Complete !"
            PictureLoading.Image = My.Resources._480WedKis1

        End If
        Percent_loadingLBL.Text = LoadingProgressBucin.Value & "%"
    End Sub
    Private Sub LoadingProgressBucin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()
    End Sub
End Class