<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        HERO_HEADER_1 = New Label()
        HERO_HEADER = New Label()
        HERO_IMAGE_1 = New PictureBox()
        HERO_IMAGE = New PictureBox()
        SIGN_UP = New Button()
        LOGIN = New Button()
        BOOK_A_ROOM = New Button()
        HOME_BUTTON = New Button()
        Brand = New Label()
        PictureBox1 = New PictureBox()
        RichTextBox1 = New RichTextBox()
        Panel1.SuspendLayout()
        CType(HERO_IMAGE_1, ComponentModel.ISupportInitialize).BeginInit()
        CType(HERO_IMAGE, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.Controls.Add(HERO_HEADER_1)
        Panel1.Controls.Add(HERO_HEADER)
        Panel1.Controls.Add(HERO_IMAGE_1)
        Panel1.Controls.Add(HERO_IMAGE)
        Panel1.Controls.Add(SIGN_UP)
        Panel1.Controls.Add(LOGIN)
        Panel1.Controls.Add(BOOK_A_ROOM)
        Panel1.Controls.Add(HOME_BUTTON)
        Panel1.Controls.Add(Brand)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' HERO_HEADER_1
        ' 
        HERO_HEADER_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        HERO_HEADER_1.AutoSize = True
        HERO_HEADER_1.Font = New Font("Arial Black", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HERO_HEADER_1.ForeColor = Color.LimeGreen
        HERO_HEADER_1.Location = New Point(55, 205)
        HERO_HEADER_1.Name = "HERO_HEADER_1"
        HERO_HEADER_1.Padding = New Padding(8)
        HERO_HEADER_1.Size = New Size(225, 42)
        HERO_HEADER_1.TabIndex = 7
        HERO_HEADER_1.Text = "your student Life....."
        ' 
        ' HERO_HEADER
        ' 
        HERO_HEADER.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        HERO_HEADER.AutoSize = True
        HERO_HEADER.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HERO_HEADER.ForeColor = Color.LimeGreen
        HERO_HEADER.Location = New Point(55, 127)
        HERO_HEADER.Name = "HERO_HEADER"
        HERO_HEADER.Padding = New Padding(8)
        HERO_HEADER.Size = New Size(447, 49)
        HERO_HEADER.TabIndex = 7
        HERO_HEADER.Text = "Find the right accomodation for"
        ' 
        ' HERO_IMAGE_1
        ' 
        HERO_IMAGE_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        HERO_IMAGE_1.BackgroundImageLayout = ImageLayout.Center
        HERO_IMAGE_1.BorderStyle = BorderStyle.Fixed3D
        HERO_IMAGE_1.Image = My.Resources.Resources.Screenshot_2024_07_26_212318
        HERO_IMAGE_1.Location = New Point(27, 282)
        HERO_IMAGE_1.Name = "HERO_IMAGE_1"
        HERO_IMAGE_1.Size = New Size(189, 69)
        HERO_IMAGE_1.TabIndex = 6
        HERO_IMAGE_1.TabStop = False
        ' 
        ' HERO_IMAGE
        ' 
        HERO_IMAGE.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        HERO_IMAGE.BorderStyle = BorderStyle.Fixed3D
        HERO_IMAGE.Image = My.Resources.Resources.images
        HERO_IMAGE.Location = New Point(531, 87)
        HERO_IMAGE.Name = "HERO_IMAGE"
        HERO_IMAGE.Size = New Size(239, 99)
        HERO_IMAGE.TabIndex = 6
        HERO_IMAGE.TabStop = False
        ' 
        ' SIGN_UP
        ' 
        SIGN_UP.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SIGN_UP.BackColor = Color.LimeGreen
        SIGN_UP.Cursor = Cursors.Hand
        SIGN_UP.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SIGN_UP.ForeColor = Color.Black
        SIGN_UP.ImageAlign = ContentAlignment.TopLeft
        SIGN_UP.Location = New Point(674, 30)
        SIGN_UP.Name = "SIGN_UP"
        SIGN_UP.Size = New Size(109, 0)
        SIGN_UP.TabIndex = 5
        SIGN_UP.Text = "SIGN UP"
        SIGN_UP.UseVisualStyleBackColor = False
        ' 
        ' LOGIN
        ' 
        LOGIN.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LOGIN.BackColor = SystemColors.AppWorkspace
        LOGIN.Cursor = Cursors.Hand
        LOGIN.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LOGIN.ForeColor = Color.White
        LOGIN.Location = New Point(579, 31)
        LOGIN.Name = "LOGIN"
        LOGIN.Size = New Size(100, 0)
        LOGIN.TabIndex = 5
        LOGIN.Text = "LOGIN"
        LOGIN.UseVisualStyleBackColor = False
        ' 
        ' BOOK_A_ROOM
        ' 
        BOOK_A_ROOM.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        BOOK_A_ROOM.BackColor = SystemColors.AppWorkspace
        BOOK_A_ROOM.Cursor = Cursors.Hand
        BOOK_A_ROOM.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BOOK_A_ROOM.ForeColor = Color.White
        BOOK_A_ROOM.Location = New Point(443, 31)
        BOOK_A_ROOM.Name = "BOOK_A_ROOM"
        BOOK_A_ROOM.Size = New Size(139, 0)
        BOOK_A_ROOM.TabIndex = 5
        BOOK_A_ROOM.Text = "BOOK A ROOM"
        BOOK_A_ROOM.TextAlign = ContentAlignment.MiddleLeft
        BOOK_A_ROOM.UseVisualStyleBackColor = False
        ' 
        ' HOME_BUTTON
        ' 
        HOME_BUTTON.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        HOME_BUTTON.BackColor = SystemColors.AppWorkspace
        HOME_BUTTON.Cursor = Cursors.Hand
        HOME_BUTTON.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HOME_BUTTON.ForeColor = Color.White
        HOME_BUTTON.Location = New Point(345, 31)
        HOME_BUTTON.Name = "HOME_BUTTON"
        HOME_BUTTON.Size = New Size(100, 0)
        HOME_BUTTON.TabIndex = 5
        HOME_BUTTON.Text = "HOME"
        HOME_BUTTON.UseVisualStyleBackColor = False
        ' 
        ' Brand
        ' 
        Brand.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Brand.AutoSize = True
        Brand.BorderStyle = BorderStyle.Fixed3D
        Brand.Cursor = Cursors.Hand
        Brand.Font = New Font("Constantia", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Brand.ForeColor = Color.LimeGreen
        Brand.Location = New Point(79, 21)
        Brand.Name = "Brand"
        Brand.Padding = New Padding(7)
        Brand.Size = New Size(228, 49)
        Brand.TabIndex = 4
        Brand.Text = "Onwards Tower"
        Brand.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.AppWorkspace
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(776, 352)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBox1.Location = New Point(402, 429)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(117, 21)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(HERO_IMAGE_1, ComponentModel.ISupportInitialize).EndInit()
        CType(HERO_IMAGE, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Brand As Label
    Friend WithEvents HOME_BUTTON As Button
    Friend WithEvents SIGN_UP As Button
    Friend WithEvents LOGIN As Button
    Friend WithEvents BOOK_A_ROOM As Button
    Friend WithEvents HERO_IMAGE As PictureBox
    Friend WithEvents HERO_IMAGE_1 As PictureBox
    Friend WithEvents HERO_HEADER As Label
    Friend WithEvents HERO_HEADER_1 As Label

End Class
