<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to provide manually calculated IDs when inserting new appointments to SchedulerControl


<p>Usually the ID column of the database table for appointments is defined as an Identity Column. This means that when a new data row is inserted, its ID column value is calculated automatically (i. e. you should not be concerned about maintaining the correct value for this column). In some scenarios the existing database schema does not allow you to use an Identity Column and you should generate and insert appropriate IDs manually. To do this, first, specify the ID in the TableAdapter.InsertCommand of the TableAdapter that is used to retrieve appointments (CarSchedulingTableAdapter in this example). Then, handle the <a href="http://msdn.microsoft.com/en-us/library/system.data.datatable.tablenewrow.aspx"><u>DataTable.TableNewRow Event</u></a> of DataTable with appointments (CarsScheduling in this example) to assign manually calculated ID to the e.Row["ID"] parameter in this event handler. This should be sufficient in inserting new appointment rows with correct IDs into the database with a corresponding schema.</p><p>Here is the example of a similar scenario, but in the ASP.NET environment:<br />
<a href="https://www.devexpress.com/Support/Center/p/E2657">How to provide manually calculated IDs when inserting new appointments to ASPxScheduler bound to the SQL Server database</a></p>

<br/>


