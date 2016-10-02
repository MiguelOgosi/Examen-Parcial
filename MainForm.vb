Public Class MainForm

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pbProdTitulo.Image = ilHombresN.Images.Item(2)
        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
        lblPrecio.Text = "$ 95"
        lblTotal.Text = "$ 720"

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        pbProdTitulo.Image = ilHombresN.Images.Item(2)
        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
        lblPrecio.Text = "$ 110"
        lblTotal.Text = "$ 720"

        pbProdTitulo.Image = ilHombresN.Images.Item(1)
        lblTitulo.Text = "Plated Sub Cashmere Blend Jumper"
        lblPrecio.Text = "$ 85"
        lblTotal.Text = "$ 720"

        pbProdTitulo.Image = ilHombresN.Images.Item(0)
        lblTitulo.Text = "Eng Poplin Shirt"
        lblPrecio.Text = "$ 95"
        lblTotal.Text = "$ 720"

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        pbProdTitulo.Image = ilHombresN.Images.Item(0)
        lblTitulo.Text = "Eng Poplin Shirt"
        lblPrecio.Text = "$ 95"
        lblTotal.Text = "$ 720"

        pbProdTitulo.Image = ilHombresN.Images.Item(1)
        lblTitulo.Text = "Plated Sub Cashmere Blend Jumper"
        lblPrecio.Text = "$ 85"
        lblTotal.Text = "$ 720"

        pbProdTitulo.Image = ilHombresN.Images.Item(2)
        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
        lblPrecio.Text = "$ 110"
        lblTotal.Text = "$ 720"

    End Sub
End Class