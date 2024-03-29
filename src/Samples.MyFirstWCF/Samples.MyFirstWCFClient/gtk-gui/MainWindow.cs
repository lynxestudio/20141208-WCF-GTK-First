
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Entry txtInteger;
	
	private global::Gtk.Button btnOk;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Entry txtOutput;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Display the bits");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "stock_script", global::Gtk.IconSize.Dialog);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(3));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter an integer");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.txtInteger = new global::Gtk.Entry ();
		this.txtInteger.CanFocus = true;
		this.txtInteger.Name = "txtInteger";
		this.txtInteger.IsEditable = true;
		this.txtInteger.InvisibleChar = '•';
		this.hbox1.Add (this.txtInteger);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.txtInteger]));
		w2.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnOk = new global::Gtk.Button ();
		this.btnOk.CanFocus = true;
		this.btnOk.Name = "btnOk";
		this.btnOk.UseStock = true;
		this.btnOk.UseUnderline = true;
		this.btnOk.Label = "gtk-ok";
		this.hbox1.Add (this.btnOk);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnOk]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Output bits");
		this.vbox1.Add (this.label2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label2]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.txtOutput = new global::Gtk.Entry ();
		this.txtOutput.CanFocus = true;
		this.txtOutput.Name = "txtOutput";
		this.txtOutput.IsEditable = true;
		this.txtOutput.InvisibleChar = '•';
		this.vbox1.Add (this.txtOutput);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.txtOutput]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 101;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnOk.Clicked += new global::System.EventHandler (this.OnBtnOkClicked);
	}
}
