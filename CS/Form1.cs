using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SchedulerAptIdGeneration {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
            // TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);

            this.carsDBDataSet.CarScheduling.TableNewRow += 
                new DataTableNewRowEventHandler(CarScheduling_TableNewRow);

            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
            schedulerControl1.Start = schedulerStorage1.Appointments[0].Start;
        }

        private void OnApptChangedInsertedDeleted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e) {
            this.carSchedulingTableAdapter.Update(this.carsDBDataSet);
            UpdateGridSelection();
        }

        void CarScheduling_TableNewRow(object sender, DataTableNewRowEventArgs e) {
            e.Row["ID"] = GenerateNewAppointmentId();
        }

        private int GenerateNewAppointmentId() {
            int freeId = 0;

            for (int i = 0; i < schedulerControl1.Storage.Appointments.Count; i++) {
                Appointment apt = schedulerControl1.Storage.Appointments[i];

                int aptId = Convert.ToInt32(apt.GetValue(schedulerControl1.Storage, "ID"));

                if (aptId > freeId)
                    freeId = aptId;

                if (apt.Type == AppointmentType.Pattern) {
                    AppointmentBaseCollection exceptions = apt.GetExceptions();

                    for (int j = 0; j < exceptions.Count; j++) {
                        aptId = Convert.ToInt32(exceptions[j].GetValue(schedulerControl1.Storage, "ID"));

                        if (aptId > freeId)
                            freeId = aptId;
                    }
                }
            }

            freeId++;
            return freeId;
        }

        private void UpdateGridSelection() {
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
        }
    }
}