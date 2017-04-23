<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ParalympicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighlightsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeaturedEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParticipantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RankingChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutdoorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AquaticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndoorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutdoorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AquaticsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndoorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParalympicsToolStripMenuItem, Me.PicturesToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.HighlightsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ParalympicsToolStripMenuItem
        '
        Me.ParalympicsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeaturedEventsToolStripMenuItem, Me.CountriesToolStripMenuItem, Me.ParticipantsToolStripMenuItem, Me.RankingChartToolStripMenuItem})
        Me.ParalympicsToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParalympicsToolStripMenuItem.Name = "ParalympicsToolStripMenuItem"
        Me.ParalympicsToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ParalympicsToolStripMenuItem.Text = "Paralympics"
        '
        'PicturesToolStripMenuItem
        '
        Me.PicturesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutdoorToolStripMenuItem, Me.AquaticsToolStripMenuItem, Me.IndoorToolStripMenuItem})
        Me.PicturesToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PicturesToolStripMenuItem.Name = "PicturesToolStripMenuItem"
        Me.PicturesToolStripMenuItem.Size = New System.Drawing.Size(74, 22)
        Me.PicturesToolStripMenuItem.Text = "Pictures"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutdoorToolStripMenuItem1, Me.AquaticsToolStripMenuItem1, Me.IndoorToolStripMenuItem1})
        Me.RecordsToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'HighlightsToolStripMenuItem
        '
        Me.HighlightsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsToolStripMenuItem})
        Me.HighlightsToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighlightsToolStripMenuItem.Name = "HighlightsToolStripMenuItem"
        Me.HighlightsToolStripMenuItem.Size = New System.Drawing.Size(89, 22)
        Me.HighlightsToolStripMenuItem.Text = "Highlights"
        '
        'FeaturedEventsToolStripMenuItem
        '
        Me.FeaturedEventsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FeaturedEventsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FeaturedEventsToolStripMenuItem.Name = "FeaturedEventsToolStripMenuItem"
        Me.FeaturedEventsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.FeaturedEventsToolStripMenuItem.Text = "Featured Events"
        '
        'CountriesToolStripMenuItem
        '
        Me.CountriesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CountriesToolStripMenuItem.Name = "CountriesToolStripMenuItem"
        Me.CountriesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CountriesToolStripMenuItem.Text = "Countries"
        '
        'ParticipantsToolStripMenuItem
        '
        Me.ParticipantsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ParticipantsToolStripMenuItem.Name = "ParticipantsToolStripMenuItem"
        Me.ParticipantsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ParticipantsToolStripMenuItem.Text = "Participants"
        '
        'RankingChartToolStripMenuItem
        '
        Me.RankingChartToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RankingChartToolStripMenuItem.Name = "RankingChartToolStripMenuItem"
        Me.RankingChartToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RankingChartToolStripMenuItem.Text = "Ranking Chart"
        '
        'OutdoorToolStripMenuItem
        '
        Me.OutdoorToolStripMenuItem.Name = "OutdoorToolStripMenuItem"
        Me.OutdoorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OutdoorToolStripMenuItem.Text = "Outdoor"
        '
        'AquaticsToolStripMenuItem
        '
        Me.AquaticsToolStripMenuItem.Name = "AquaticsToolStripMenuItem"
        Me.AquaticsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AquaticsToolStripMenuItem.Text = "Aquatics"
        '
        'IndoorToolStripMenuItem
        '
        Me.IndoorToolStripMenuItem.Name = "IndoorToolStripMenuItem"
        Me.IndoorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IndoorToolStripMenuItem.Text = "Indoor"
        '
        'OutdoorToolStripMenuItem1
        '
        Me.OutdoorToolStripMenuItem1.Name = "OutdoorToolStripMenuItem1"
        Me.OutdoorToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.OutdoorToolStripMenuItem1.Text = "Outdoor"
        '
        'AquaticsToolStripMenuItem1
        '
        Me.AquaticsToolStripMenuItem1.Name = "AquaticsToolStripMenuItem1"
        Me.AquaticsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AquaticsToolStripMenuItem1.Text = "Aquatics"
        '
        'IndoorToolStripMenuItem1
        '
        Me.IndoorToolStripMenuItem1.Name = "IndoorToolStripMenuItem1"
        Me.IndoorToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.IndoorToolStripMenuItem1.Text = "Indoor"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.rio
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(576, 425)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ParalympicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeaturedEventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParticipantsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RankingChartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PicturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutdoorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AquaticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndoorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutdoorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AquaticsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndoorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighlightsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
