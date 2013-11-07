<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageWindow
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageWindow))
        Me.imageWindowPictureBox = New System.Windows.Forms.PictureBox()
        Me.ImageWindowMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CropToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Level3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageWindowSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.imageWindowPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImageWindowMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'imageWindowPictureBox
        '
        Me.imageWindowPictureBox.BackgroundImage = CType(resources.GetObject("imageWindowPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.imageWindowPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imageWindowPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.imageWindowPictureBox.Name = "imageWindowPictureBox"
        Me.imageWindowPictureBox.Size = New System.Drawing.Size(300, 300)
        Me.imageWindowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imageWindowPictureBox.TabIndex = 0
        Me.imageWindowPictureBox.TabStop = False
        '
        'ImageWindowMenuStrip
        '
        Me.ImageWindowMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EffectsToolStripMenuItem})
        Me.ImageWindowMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ImageWindowMenuStrip.Name = "ImageWindowMenuStrip"
        Me.ImageWindowMenuStrip.Size = New System.Drawing.Size(300, 24)
        Me.ImageWindowMenuStrip.TabIndex = 1
        Me.ImageWindowMenuStrip.Text = "MenuStrip1"
        Me.ImageWindowMenuStrip.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1})
        Me.FileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.CloseToolStripMenuItem.MergeIndex = 2
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+W"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.SaveToolStripMenuItem.MergeIndex = 2
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SaveToolStripMenuItem.Text = "Save..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.SaveAsToolStripMenuItem.MergeIndex = 3
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeyDisplayString = "F12"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.ToolStripSeparator1.MergeIndex = 4
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'EffectsToolStripMenuItem
        '
        Me.EffectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResizeToolStripMenuItem, Me.CropToolStripMenuItem, Me.InvertToolStripMenuItem, Me.GrayscaleToolStripMenuItem, Me.BlurToolStripMenuItem})
        Me.EffectsToolStripMenuItem.Name = "EffectsToolStripMenuItem"
        Me.EffectsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.EffectsToolStripMenuItem.Text = "&Effects"
        '
        'ResizeToolStripMenuItem
        '
        Me.ResizeToolStripMenuItem.Name = "ResizeToolStripMenuItem"
        Me.ResizeToolStripMenuItem.ShortcutKeyDisplayString = "Clrt+R"
        Me.ResizeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResizeToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ResizeToolStripMenuItem.Text = "Resize..."
        '
        'CropToolStripMenuItem
        '
        Me.CropToolStripMenuItem.CheckOnClick = True
        Me.CropToolStripMenuItem.Name = "CropToolStripMenuItem"
        Me.CropToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CropToolStripMenuItem.Text = "Crop"
        '
        'InvertToolStripMenuItem
        '
        Me.InvertToolStripMenuItem.Name = "InvertToolStripMenuItem"
        Me.InvertToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+I"
        Me.InvertToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.InvertToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.InvertToolStripMenuItem.Text = "Invert"
        '
        'GrayscaleToolStripMenuItem
        '
        Me.GrayscaleToolStripMenuItem.Name = "GrayscaleToolStripMenuItem"
        Me.GrayscaleToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+G"
        Me.GrayscaleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GrayscaleToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GrayscaleToolStripMenuItem.Text = "Grayscale"
        '
        'BlurToolStripMenuItem
        '
        Me.BlurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Level1ToolStripMenuItem, Me.Level2ToolStripMenuItem, Me.Level3ToolStripMenuItem})
        Me.BlurToolStripMenuItem.Name = "BlurToolStripMenuItem"
        Me.BlurToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.BlurToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.BlurToolStripMenuItem.Text = "Blur"
        '
        'Level1ToolStripMenuItem
        '
        Me.Level1ToolStripMenuItem.Name = "Level1ToolStripMenuItem"
        Me.Level1ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Level1ToolStripMenuItem.Text = "Level 1"
        '
        'Level2ToolStripMenuItem
        '
        Me.Level2ToolStripMenuItem.Name = "Level2ToolStripMenuItem"
        Me.Level2ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Level2ToolStripMenuItem.Text = "Level 2"
        '
        'Level3ToolStripMenuItem
        '
        Me.Level3ToolStripMenuItem.Name = "Level3ToolStripMenuItem"
        Me.Level3ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Level3ToolStripMenuItem.Text = "Level 3"
        '
        'imageWindowSaveFileDialog
        '
        Me.imageWindowSaveFileDialog.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif|Bitmap|*.bmp|All Files|*.*"
        Me.imageWindowSaveFileDialog.Title = "Save As"
        '
        'ImageWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.imageWindowPictureBox)
        Me.Controls.Add(Me.ImageWindowMenuStrip)
        Me.MainMenuStrip = Me.ImageWindowMenuStrip
        Me.Name = "ImageWindow"
        Me.Text = "ImageWindow"
        CType(Me.imageWindowPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImageWindowMenuStrip.ResumeLayout(False)
        Me.ImageWindowMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imageWindowPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ImageWindowMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EffectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imageWindowSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GrayscaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Level1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Level2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Level3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CropToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
