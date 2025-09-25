Partial Class reportsform

    Private Sub reportsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: initialize defaults
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ' Ensure consistent fonts
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim marginLeft As Single = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top
        Dim lineHeight As Single = 24

        Dim titleFont As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim labelFont As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim bodyFont As New Font("Segoe UI", 10, FontStyle.Regular)

        e.Graphics.DrawString(txtTitle.Text, titleFont, Brushes.Black, marginLeft, y)
        y += 2 * lineHeight

        e.Graphics.DrawString("Subject:", labelFont, Brushes.Black, marginLeft, y)
        e.Graphics.DrawString(txtSubject.Text, bodyFont, Brushes.Black, marginLeft + 80, y)
        y += lineHeight * 1.5F

        e.Graphics.DrawString("Body:", labelFont, Brushes.Black, marginLeft, y)
        y += lineHeight

        Dim bodyRect As New RectangleF(marginLeft, y, e.MarginBounds.Width, e.MarginBounds.Height - (y - e.MarginBounds.Top))
        e.Graphics.DrawString(txtBody.Text, bodyFont, Brushes.Black, bodyRect)

        e.HasMorePages = False
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub btnPageSetup_Click(sender As Object, e As EventArgs) Handles btnPageSetup.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.ShowDialog()
    End Sub

End Class

 