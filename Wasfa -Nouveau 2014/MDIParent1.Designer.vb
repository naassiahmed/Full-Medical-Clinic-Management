<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NouveauPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NouvelleOrdonnanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.GestionDesRendezvousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.GestionDesPosologiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.Ordonnance = New System.Windows.Forms.ToolStripButton
        Me.Patient = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Med = New System.Windows.Forms.ToolStripButton
        Me.Dose = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.Find = New System.Windows.Forms.ToolStripButton
        Me.RendezVous = New System.Windows.Forms.ToolStripButton
        Me.Memo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Medecin = New System.Windows.Forms.ToolStripButton
        Me.Horloge = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.Settings = New System.Windows.Forms.ToolStripButton
        Me.Activation = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.About = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton
        Me.Sortir = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1276, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(54, 20)
        Me.FileMenu.Text = "&Fichier"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauPatientToolStripMenuItem, Me.NouvelleOrdonnanceToolStripMenuItem, Me.ToolStripSeparator3, Me.GestionDesRendezvousToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(128, 20)
        Me.ViewMenu.Text = "&Gestion des données"
        '
        'NouveauPatientToolStripMenuItem
        '
        Me.NouveauPatientToolStripMenuItem.Name = "NouveauPatientToolStripMenuItem"
        Me.NouveauPatientToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.NouveauPatientToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.NouveauPatientToolStripMenuItem.Text = "Gestion des patients"
        '
        'NouvelleOrdonnanceToolStripMenuItem
        '
        Me.NouvelleOrdonnanceToolStripMenuItem.Name = "NouvelleOrdonnanceToolStripMenuItem"
        Me.NouvelleOrdonnanceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.NouvelleOrdonnanceToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.NouvelleOrdonnanceToolStripMenuItem.Text = "Gestion des ordonnances"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(223, 6)
        '
        'GestionDesRendezvousToolStripMenuItem
        '
        Me.GestionDesRendezvousToolStripMenuItem.Name = "GestionDesRendezvousToolStripMenuItem"
        Me.GestionDesRendezvousToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.GestionDesRendezvousToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.GestionDesRendezvousToolStripMenuItem.Text = "Gestion des rendez-vous"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.ToolStripSeparator4, Me.GestionDesPosologiesToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(159, 20)
        Me.ToolsMenu.Text = "&Médicament et Posologies"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.OptionsToolStripMenuItem.Text = "Gestion des médicaments"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(226, 6)
        '
        'GestionDesPosologiesToolStripMenuItem
        '
        Me.GestionDesPosologiesToolStripMenuItem.Name = "GestionDesPosologiesToolStripMenuItem"
        Me.GestionDesPosologiesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.GestionDesPosologiesToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.GestionDesPosologiesToolStripMenuItem.Text = "Gestion des posologies"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.ToolStripSeparator5, Me.CascadeToolStripMenuItem, Me.ToolStripSeparator6, Me.TileVerticalToolStripMenuItem, Me.ToolStripSeparator7, Me.TileHorizontalToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(50, 20)
        Me.WindowsMenu.Text = "&Outils"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.NewWindowToolStripMenuItem.Text = "Information du médecin"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(222, 6)
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CascadeToolStripMenuItem.Text = "Les horaires de travail"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(222, 6)
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Mémos"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(222, 6)
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Configuer l'ordonnance"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(165, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ordonnance, Me.Patient, Me.ToolStripSeparator1, Me.Med, Me.Dose, Me.ToolStripSeparator9, Me.Find, Me.RendezVous, Me.Memo, Me.ToolStripSeparator2, Me.Medecin, Me.Horloge, Me.ToolStripSeparator10, Me.Settings, Me.Activation, Me.ToolStripSeparator11, Me.About, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton1, Me.ToolStripButton8, Me.ToolStripButton9, Me.Sortir})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1276, 71)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'Ordonnance
        '
        Me.Ordonnance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ordonnance.Image = CType(resources.GetObject("Ordonnance.Image"), System.Drawing.Image)
        Me.Ordonnance.ImageTransparentColor = System.Drawing.Color.Black
        Me.Ordonnance.Name = "Ordonnance"
        Me.Ordonnance.Size = New System.Drawing.Size(68, 68)
        Me.Ordonnance.Text = "Ordonnance"
        Me.Ordonnance.ToolTipText = "Ajouter Nouvelle Ordonnace"
        '
        'Patient
        '
        Me.Patient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patient.Image = CType(resources.GetObject("Patient.Image"), System.Drawing.Image)
        Me.Patient.ImageTransparentColor = System.Drawing.Color.Black
        Me.Patient.Name = "Patient"
        Me.Patient.Size = New System.Drawing.Size(68, 68)
        Me.Patient.Text = "Open"
        Me.Patient.ToolTipText = "Gestion des Patients"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 71)
        '
        'Med
        '
        Me.Med.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Med.Image = CType(resources.GetObject("Med.Image"), System.Drawing.Image)
        Me.Med.ImageTransparentColor = System.Drawing.Color.Black
        Me.Med.Name = "Med"
        Me.Med.Size = New System.Drawing.Size(68, 68)
        Me.Med.Text = "Help"
        Me.Med.ToolTipText = "Gestion des Médicaments"
        '
        'Dose
        '
        Me.Dose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Dose.Image = CType(resources.GetObject("Dose.Image"), System.Drawing.Image)
        Me.Dose.ImageTransparentColor = System.Drawing.Color.Black
        Me.Dose.Name = "Dose"
        Me.Dose.Size = New System.Drawing.Size(68, 68)
        Me.Dose.Text = "Print Preview"
        Me.Dose.ToolTipText = "Gestion des Posologies"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 71)
        '
        'Find
        '
        Me.Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Find.Image = CType(resources.GetObject("Find.Image"), System.Drawing.Image)
        Me.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Find.Name = "Find"
        Me.Find.Size = New System.Drawing.Size(68, 68)
        Me.Find.Text = "ToolStripButton10"
        Me.Find.ToolTipText = "Gestion de la Recherche"
        '
        'RendezVous
        '
        Me.RendezVous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RendezVous.Image = CType(resources.GetObject("RendezVous.Image"), System.Drawing.Image)
        Me.RendezVous.ImageTransparentColor = System.Drawing.Color.Black
        Me.RendezVous.Name = "RendezVous"
        Me.RendezVous.Size = New System.Drawing.Size(68, 68)
        Me.RendezVous.Text = "Save"
        Me.RendezVous.ToolTipText = "Gestion des Rendez-vous"
        '
        'Memo
        '
        Me.Memo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Memo.Image = CType(resources.GetObject("Memo.Image"), System.Drawing.Image)
        Me.Memo.ImageTransparentColor = System.Drawing.Color.Black
        Me.Memo.Name = "Memo"
        Me.Memo.Size = New System.Drawing.Size(68, 68)
        Me.Memo.Text = "Print"
        Me.Memo.ToolTipText = "Gestion des Mémos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 71)
        '
        'Medecin
        '
        Me.Medecin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Medecin.Image = CType(resources.GetObject("Medecin.Image"), System.Drawing.Image)
        Me.Medecin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Medecin.Name = "Medecin"
        Me.Medecin.Size = New System.Drawing.Size(68, 68)
        Me.Medecin.Text = "ToolStripButton1"
        Me.Medecin.ToolTipText = "Les informations du Médecin"
        '
        'Horloge
        '
        Me.Horloge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Horloge.Image = CType(resources.GetObject("Horloge.Image"), System.Drawing.Image)
        Me.Horloge.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Horloge.Name = "Horloge"
        Me.Horloge.Size = New System.Drawing.Size(68, 68)
        Me.Horloge.Text = "ToolStripButton3"
        Me.Horloge.ToolTipText = "Les horaires de travail"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 71)
        '
        'Settings
        '
        Me.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Settings.Image = CType(resources.GetObject("Settings.Image"), System.Drawing.Image)
        Me.Settings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(68, 68)
        Me.Settings.Text = "ToolStripButton2"
        Me.Settings.ToolTipText = "Gestion des styles des ordonannaces"
        '
        'Activation
        '
        Me.Activation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Activation.Image = CType(resources.GetObject("Activation.Image"), System.Drawing.Image)
        Me.Activation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Activation.Name = "Activation"
        Me.Activation.Size = New System.Drawing.Size(68, 68)
        Me.Activation.Text = "ToolStripButton4"
        Me.Activation.ToolTipText = "Activer cette version"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 71)
        '
        'About
        '
        Me.About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.About.Image = CType(resources.GetObject("About.Image"), System.Drawing.Image)
        Me.About.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(68, 68)
        Me.About.Text = "ToolStripButton11"
        Me.About.ToolTipText = "A propos de ce logiciel"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Enabled = False
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 68)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 68)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 68)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 68)
        Me.ToolStripButton9.Text = "ToolStripButton9"
        '
        'Sortir
        '
        Me.Sortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Sortir.Image = CType(resources.GetObject("Sortir.Image"), System.Drawing.Image)
        Me.Sortir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Sortir.Name = "Sortir"
        Me.Sortir.Size = New System.Drawing.Size(68, 68)
        Me.Sortir.Text = "ToolStripButton5"
        Me.Sortir.ToolTipText = "Sortir de programme"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1276, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(1112, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(185, 83)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Informations :"
        Me.TextBox1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Button1
        '
        Me.Button1.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.warning_64
        Me.Button1.Location = New System.Drawing.Point(1112, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 88)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Wasfa__Nouveau_2014.My.Resources.Resources.faculte_de_medecine
        Me.PictureBox1.Location = New System.Drawing.Point(0, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1276, 336)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 3000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Backup"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 453)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wasfa Pro - Programmé par NAAS Si Ahmed "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Med As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Dose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Memo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Ordonnance As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Patient As System.Windows.Forms.ToolStripButton
    Friend WithEvents RendezVous As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Medecin As System.Windows.Forms.ToolStripButton
    Friend WithEvents Settings As System.Windows.Forms.ToolStripButton
    Friend WithEvents Horloge As System.Windows.Forms.ToolStripButton
    Friend WithEvents Activation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Sortir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Find As System.Windows.Forms.ToolStripButton
    Friend WithEvents About As System.Windows.Forms.ToolStripButton
    Friend WithEvents NouveauPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvelleOrdonnanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GestionDesRendezvousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GestionDesPosologiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
