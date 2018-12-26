Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerAptIdGeneration
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet = New CarsDBDataSet()
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carSchedulingTableAdapter = New CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
            Me.carsTableAdapter = New CarsDBDataSetTableAdapters.CarsTableAdapter()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.iDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.subjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.startTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.endTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.eventTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.recurrenceInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.schedulerControl1.Location = New System.Drawing.Point(16, 15)
			Me.schedulerControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.OptionsView.ResourceHeaders.Height = 100
			Me.schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top
			Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSize = New System.Drawing.Size(100, 100)
			Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage
			Me.schedulerControl1.Size = New System.Drawing.Size(940, 353)
			Me.schedulerControl1.Start = New System.DateTime(2008, 10, 24, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' schedulerStorage1
			' 
			Me.schedulerStorage1.Appointments.DataSource = Me.carSchedulingBindingSource
			Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
			Me.schedulerStorage1.Appointments.Mappings.End = "EndTime"
			Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
			Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
			Me.schedulerStorage1.Appointments.Mappings.ResourceId = "CarId"
			Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
			Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
			Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
			Me.schedulerStorage1.Resources.DataSource = Me.carsBindingSource
			Me.schedulerStorage1.Resources.Mappings.Caption = "Model"
			Me.schedulerStorage1.Resources.Mappings.Id = "ID"
			Me.schedulerStorage1.Resources.Mappings.Image = "Picture"
'			Me.schedulerStorage1.AppointmentsChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
'			Me.schedulerStorage1.AppointmentsInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
'			Me.schedulerStorage1.AppointmentsDeleted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.OnApptChangedInsertedDeleted);
			' 
			' carSchedulingBindingSource
			' 
			Me.carSchedulingBindingSource.DataMember = "CarScheduling"
			Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carSchedulingTableAdapter
			' 
			Me.carSchedulingTableAdapter.ClearBeforeFill = True
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AllowUserToAddRows = False
			Me.dataGridView1.AllowUserToDeleteRows = False
			Me.dataGridView1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataGridView1.AutoGenerateColumns = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.iDDataGridViewTextBoxColumn, Me.subjectDataGridViewTextBoxColumn, Me.startTimeDataGridViewTextBoxColumn, Me.endTimeDataGridViewTextBoxColumn, Me.eventTypeDataGridViewTextBoxColumn, Me.recurrenceInfoDataGridViewTextBoxColumn})
			Me.dataGridView1.DataSource = Me.carSchedulingBindingSource
			Me.dataGridView1.Location = New System.Drawing.Point(16, 375)
			Me.dataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.ReadOnly = True
			Me.dataGridView1.Size = New System.Drawing.Size(940, 156)
			Me.dataGridView1.TabIndex = 1
			' 
			' iDDataGridViewTextBoxColumn
			' 
			Me.iDDataGridViewTextBoxColumn.DataPropertyName = "ID"
			Me.iDDataGridViewTextBoxColumn.HeaderText = "ID"
			Me.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn"
			Me.iDDataGridViewTextBoxColumn.ReadOnly = True
			' 
			' subjectDataGridViewTextBoxColumn
			' 
			Me.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
			Me.subjectDataGridViewTextBoxColumn.HeaderText = "Subject"
			Me.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn"
			Me.subjectDataGridViewTextBoxColumn.ReadOnly = True
			' 
			' startTimeDataGridViewTextBoxColumn
			' 
			Me.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime"
			Me.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime"
			Me.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn"
			Me.startTimeDataGridViewTextBoxColumn.ReadOnly = True
			' 
			' endTimeDataGridViewTextBoxColumn
			' 
			Me.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime"
			Me.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime"
			Me.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn"
			Me.endTimeDataGridViewTextBoxColumn.ReadOnly = True
			' 
			' eventTypeDataGridViewTextBoxColumn
			' 
			Me.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType"
			Me.eventTypeDataGridViewTextBoxColumn.HeaderText = "EventType"
			Me.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn"
			Me.eventTypeDataGridViewTextBoxColumn.ReadOnly = True
			' 
			' recurrenceInfoDataGridViewTextBoxColumn
			' 
			Me.recurrenceInfoDataGridViewTextBoxColumn.DataPropertyName = "RecurrenceInfo"
			Me.recurrenceInfoDataGridViewTextBoxColumn.HeaderText = "RecurrenceInfo"
			Me.recurrenceInfoDataGridViewTextBoxColumn.Name = "recurrenceInfoDataGridViewTextBoxColumn"
			Me.recurrenceInfoDataGridViewTextBoxColumn.ReadOnly = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(972, 546)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private carsDBDataSet As CarsDBDataSet
		Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private carSchedulingBindingSource As System.Windows.Forms.BindingSource
        Private carSchedulingTableAdapter As CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
        Private carsBindingSource As System.Windows.Forms.BindingSource
        Private carsTableAdapter As CarsDBDataSetTableAdapters.CarsTableAdapter
        Private dataGridView1 As System.Windows.Forms.DataGridView
		Private iDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private subjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private startTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private endTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private eventTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private recurrenceInfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace

