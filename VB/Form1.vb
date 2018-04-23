Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerAptIdGeneration
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)
			' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)

			AddHandler carsDBDataSet.CarScheduling.TableNewRow, AddressOf CarScheduling_TableNewRow

			schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek
			schedulerControl1.Start = schedulerStorage1.Appointments(0).Start
		End Sub

		Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsChanged, schedulerStorage1.AppointmentsInserted, schedulerStorage1.AppointmentsDeleted
			Me.carSchedulingTableAdapter.Update(Me.carsDBDataSet)
			UpdateGridSelection()
		End Sub

		Private Sub CarScheduling_TableNewRow(ByVal sender As Object, ByVal e As DataTableNewRowEventArgs)
			e.Row("ID") = GenerateNewAppointmentId()
		End Sub

		Private Function GenerateNewAppointmentId() As Integer
			Dim freeId As Integer = 0

			For i As Integer = 0 To schedulerControl1.Storage.Appointments.Count - 1
				Dim apt As Appointment = schedulerControl1.Storage.Appointments(i)

				Dim aptId As Integer = Convert.ToInt32(apt.GetValue(schedulerControl1.Storage, "ID"))

				If aptId > freeId Then
					freeId = aptId
				End If

				If apt.Type = AppointmentType.Pattern Then
					Dim exceptions As AppointmentBaseCollection = apt.GetExceptions()

					For j As Integer = 0 To exceptions.Count - 1
						aptId = Convert.ToInt32(exceptions(j).GetValue(schedulerControl1.Storage, "ID"))

						If aptId > freeId Then
							freeId = aptId
						End If
					Next j
				End If
			Next i

			freeId += 1
			Return freeId
		End Function

		Private Sub UpdateGridSelection()
			dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1
			dataGridView1.Rows(dataGridView1.RowCount - 1).Selected = True
		End Sub
	End Class
End Namespace