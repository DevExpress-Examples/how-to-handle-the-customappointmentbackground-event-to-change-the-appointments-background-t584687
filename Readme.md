<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/CustomAppointmentBackground/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/CustomAppointmentBackground/MainViewModel.vb))
* [MainWindow.xaml](./CS/CustomAppointmentBackground/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomAppointmentBackground/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomAppointmentBackground/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomAppointmentBackground/MainWindow.xaml.vb))
* [Doctor.cs](./CS/CustomAppointmentBackground/Model/Doctor.cs) (VB: [Doctor.vb](./VB/CustomAppointmentBackground/Model/Doctor.vb))
* [MedicalAppointment.cs](./CS/CustomAppointmentBackground/Model/MedicalAppointment.cs) (VB: [MedicalAppointment.vb](./VB/CustomAppointmentBackground/Model/MedicalAppointment.vb))
<!-- default file list end -->
# How to handle the CustomAppointmentBackground event to change the appointment's background color


The following code example shows to to change the appointment's background by handling the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.CustomAppointmentBackground.event">SchedulerControl.CustomAppointmentBackground</a> event. In the event handler, the normal, recurrent and all-day appointments are customized so they appear as shown in the image below:<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-handle-the-customappointmentbackground-event-to-change-the-appointments-background-t584687/17.2.4+/media/bebcb0df-bc6b-416b-9974-3091d8fc8910.png">

<br/>


