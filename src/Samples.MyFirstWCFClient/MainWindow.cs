using System;
using Gtk;
using System.ServiceModel;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnOkClicked (object sender, EventArgs e)
	{
		var proxy = GetProxy ();
		int intToDisplay = 0;
		if (!string.IsNullOrEmpty (txtInteger.Text)) 
		{
			intToDisplay = Convert.ToInt32 (txtInteger.Text);
			txtOutput.Text = proxy.DisplayToBits (intToDisplay);
		}
	}

	IDisplayBitsServiceContract GetProxy(){
		EndpointAddress address = new EndpointAddress ("http://localhost:8080/Samples/DisplayBitsService");
		BasicHttpBinding binding = new BasicHttpBinding ();
		IDisplayBitsServiceContract proxy = ChannelFactory<IDisplayBitsServiceContract>.CreateChannel (binding,address);
		return proxy;
	}
}
